using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public static class RentalsTable
    {
        public static TechableDSTableAdapters.RentalsTableAdapter adapter;

        private static TechableDSTableAdapters.RentalsTableAdapter getNewAdapter()
        {
            return new TechableDSTableAdapters.RentalsTableAdapter();
        }

        public static void add(string upc, int customerId, string userName, DateTime dueDate)
        {
            adapter = getNewAdapter();
            adapter.Insert(upc, customerId, userName, dueDate, false);
            adapter.Dispose();
        }
        public static DataTable getNotReturned()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetCurrentlyRented();
            adapter.Dispose();

            return table;
        }
        public static DataTable getLateMovies()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetLateMovies();
            adapter.Dispose();

            return table;
        }
        public static bool upcIsRenting(string upc)
        {
            bool isRenting;

            adapter = getNewAdapter();
            DataTable table = adapter.GetCurrentByUpc(upc);
            adapter.Dispose();

            isRenting = table.Select().Length > 0;

            return isRenting;
        }
        public static bool customerIsRenting(int customerId)
        {
            bool isRenting;

            adapter = getNewAdapter();
            DataTable table = adapter.GetCurrentByCustomer(customerId);
            adapter.Dispose();

            isRenting = table.Select().Length > 0;

            return isRenting;
        }
        public static void returnMovie(string upc)
        {
            adapter = getNewAdapter();
            adapter.ReturnMovie(upc);
            adapter.Dispose();
        }
    }
}
