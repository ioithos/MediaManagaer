using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class EmployeesTable
    {
        public static TechableDSTableAdapters.EmployeesTableAdapter adapter;

        private static TechableDSTableAdapters.EmployeesTableAdapter getNewAdapter()
        {
            return new TechableDSTableAdapters.EmployeesTableAdapter();
        }

        public static void setPassword(string password, string username)
        {
            adapter = getNewAdapter();
            adapter.UpdatePassword(password, username);
            adapter.Dispose();
        }

        public static void add(string lName, string fName, bool isAdmin, string userName, string password)
        {
            adapter = getNewAdapter();
            adapter.Insert(userName, fName, lName, isAdmin, password, false);
            adapter.Dispose();
        }
        public static void delete(string userName)
        {
            setDeleted(true, userName);
        }

        private static void setDeleted(bool deleted, string userName)
        {
            adapter = new TechableDSTableAdapters.EmployeesTableAdapter();
            adapter.UpdateDeleted(deleted, userName);
            adapter.Dispose();
        }

        public static DataTable getAll()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetData();
            adapter.Dispose();

            return table;
        }
        public static bool hasEmployee(string userName)
        {
            bool hasEmployee;
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetByUserName(userName);
            adapter.Dispose();

            hasEmployee = (table.Select().Length > 0);

            return hasEmployee;
        }

        public static bool hasEverHadEmployee(string userName)
        {
            bool hasEmployee;
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetAllByUserName(userName);
            adapter.Dispose();

            hasEmployee = (table.Select().Length > 0);

            return hasEmployee;
        }
        public static bool validCredentials(string userName, string password)
        {
            bool valid;
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetDataBy(userName, password);
            adapter.Dispose();

            valid = (table.Select().Length > 0);

            return valid;
        }
        public static  Object[] getEmployee(string userName, string password)
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetDataBy(userName, password);
            adapter.Dispose();

            if (table.Select().Length > 0)
            {
                return table.Select()[0].ItemArray;
            }
            else
            {
                return null;
            }
        }
    }
}
