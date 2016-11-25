using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public static class CustomersTable
    {
        public static TechableDSTableAdapters.CustomersTableAdapter adapter;

        private static TechableDSTableAdapters.CustomersTableAdapter getNewAdapter()
        {
            return new TechableDSTableAdapters.CustomersTableAdapter();
        }

        public static DataTable getAll()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetData();
            adapter.Dispose();

            return table;
        }

        public static void add(string lName, string fName, string email, string address, string phone)
        {
            adapter = getNewAdapter();
            adapter.Insert(lName, fName, email, address, phone, false, 0);
            adapter.Dispose();
        }

        public static bool hasCustomer(string firstName, string lastName, string phone)
        {
            bool hasId;
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetDataBy(lastName, firstName, phone);
            adapter.Dispose();

            hasId = table.Select().Length > 0;

            return hasId;
        }

        public static void incrementTimesRented(int customerId)
        {
            adapter = getNewAdapter();
            adapter.IncrementTimesRented(customerId);
            adapter.Dispose();
        }
        public static bool hasCustomer(int customerId)
        {
            bool isCustomer;

            adapter = getNewAdapter();
            DataTable table = adapter.GetById(customerId);
            adapter.Dispose();

            isCustomer = table.Select().Length > 0;

            return isCustomer;
        }

        public static int getCustomerId(string firstName, string lastName, string phone)
        {
            int customerId = 4;
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetDataBy(lastName, firstName, phone);
            adapter.Dispose();

            customerId = (int)table.Select()[0].ItemArray[0];

            return customerId;
        }

        public static void setDeleted(bool deleted, int customerId)
        {
            adapter = getNewAdapter();
            adapter.UpdateDeleted(deleted, customerId);
            adapter.Dispose();
        }
    }
}
