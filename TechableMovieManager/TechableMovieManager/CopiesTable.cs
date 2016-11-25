using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class CopiesTable
    {

        public static TechableDSTableAdapters.CopiesTableAdapter adapter;

        private static TechableDSTableAdapters.CopiesTableAdapter getNewAdapter()
        {
            return new TechableDSTableAdapters.CopiesTableAdapter();
        }

        public static void delete(string upc)
        {
            setDeleted(true, upc);
        }

        public static void unDelete(string upc)
        {
            setDeleted(false, upc);
        }

        private static void setDeleted(bool deleted, string upc)
        {
            adapter = getNewAdapter();
            adapter.UpdateDeleted(deleted, upc);
            adapter.Dispose();
        }

        public static void deleteById(int movieId)
        {
            setDeletedById(true, movieId);
        }

        public static void unDeleteById(int movieId)
        {
            setDeletedById(false, movieId);
        }

        private static void setDeletedById(bool deleted, int movieId)
        {
            adapter = getNewAdapter();
            adapter.UpdateDeletedById(deleted, movieId);
            adapter.Dispose();
        }

        public static bool hasCopy(string upc)
        {
            bool hasCopy;

            adapter = getNewAdapter();
            DataTable table = adapter.GetCopy(upc);
            adapter.Dispose();

            hasCopy = table.Select().Length > 0;

            return hasCopy;
        }

        public static bool hasAnyCopy(string upc)
        {
            bool hasCopy;

            adapter = getNewAdapter();
            DataTable table = adapter.GetAllCopy(upc);
            adapter.Dispose();

            hasCopy = table.Select().Length > 0;

            return hasCopy;
        }

        public static bool hasCopyById(int movieId)
        {
            bool hasCopy;

            adapter = getNewAdapter();
            DataTable table = adapter.GetCopyById(movieId);
            adapter.Dispose();

            hasCopy = table.Select().Length > 0;

            return hasCopy;
        }

        public static bool hasAnyCopyByInfo(string upc, int movieId)
        {
            bool hasCopy;

            adapter = getNewAdapter();
            DataTable table = adapter.GetAllByInfo(upc, movieId);
            adapter.Dispose();

            hasCopy = table.Select().Length > 0;

            return hasCopy;
        }

        public static bool isAvailable(string upc)
        {
            bool isAvailable = false;

            adapter = getNewAdapter();
            DataTable table = adapter.GetCopy(upc);
            adapter.Dispose();

            if (table.Select().Length > 0)
            {
                isAvailable = (bool)table.Select()[0].ItemArray[1];
            }

            return isAvailable;
        }

        public static void makeAvailable(string upc)
        {
            setAvailable(true, upc);
        }
        public static void makeUnavailable(string upc)
        {
            setAvailable(false, upc);
        }
        public static void setAvailable(bool available, string upc)
        {
            adapter = getNewAdapter();
            adapter.UpdateAvailable(available, upc);
            adapter.Dispose();

        }

        public static DataTable getAll()
        {
            TechableDS.CopiesDataTable table;

            adapter = getNewAdapter();
            table = adapter.GetData();
            adapter.Dispose();

            return table;
        }

        public static void add(string upc, int movieId)
        {
            adapter = getNewAdapter();
            adapter.Insert(upc, movieId, true, false);
            adapter.Dispose();
        }
    }
}
