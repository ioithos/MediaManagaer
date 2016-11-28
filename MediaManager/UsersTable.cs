using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class UsersTable
    {
        private static MediaDSTableAdapters.UsersTableAdapter adapter;

        private static MediaDSTableAdapters.UsersTableAdapter getNewAdapter()
        {
            return new MediaDSTableAdapters.UsersTableAdapter();
        }

        public static void disposeAdapter()
        {
            if (adapter != null) adapter.Dispose();
        }

        public static DataTable getAll()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetData();
            adapter.Dispose();

            return table;
        }

        public static bool hasUser(string username, string password)
        {
            bool result;

            adapter = getNewAdapter();
            result = 0 < adapter.GetCountByAll(username, password);
            adapter.Dispose();

            return result;
        }
    }
}
