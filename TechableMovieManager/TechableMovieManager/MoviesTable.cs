using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public static class MoviesTable
    {
        public static TechableDSTableAdapters.MoviesTableAdapter adapter;

        private static TechableDSTableAdapters.MoviesTableAdapter getNewAdapter()
        {
            return new TechableDSTableAdapters.MoviesTableAdapter();
        }

        public static DataTable getAll()
        {
            DataTable table;

            adapter = getNewAdapter();
            table = adapter.GetData();
            adapter.Dispose();

            return table;
        }

        public static void add(string name, int year, string studio)
        {
            adapter = getNewAdapter();
            adapter.Insert(name, year, studio, false, 0);
            adapter.Dispose();
        }

        public static void delete(int movieId)
        {
            setDeleted(true, movieId);
        }
        public static void unDelete(int movieId)
        {
            setDeleted(false, movieId);
        }
        public static void setDeleted(bool deleted, int movieId)
        {
            adapter = getNewAdapter();
            adapter.UpdateDeleted(deleted, movieId);
            adapter.Dispose();
        }
        

        public static bool hasMovieByUpc(string upc)
        {
            bool hasMovie;

            adapter = getNewAdapter();
            DataTable table = adapter.GetMovieByUPC(upc);
            adapter.Dispose();

            hasMovie = (table.Select().Length > 0);

            return hasMovie;
        }
        public static bool hasMovieByInfo(string name, string studio, int year)
        {
            bool hasMovie;

            adapter = getNewAdapter();
            DataTable table = adapter.GetByInfo(name, studio, year);
            adapter.Dispose();

            hasMovie = (table.Select().Length > 0);

            return hasMovie;
        }
        public static bool hasAnyMovieByInfo(string name, string studio, int year)
        {
            bool hasMovie;

            adapter = getNewAdapter();
            DataTable table = adapter.GetAllByInfo(name, studio, year);
            adapter.Dispose();

            hasMovie = (table.Select().Length > 0);

            return hasMovie;
        }
        public static int getMovieId(string name, string studio, int year)
        {
            int id;

            adapter = getNewAdapter();
            DataTable table = adapter.GetByInfo(name, studio, year);
            adapter.Dispose();

            id = (int) table.Select()[0].ItemArray[0];

            return id;
        }
        public static int getAllMovieId(string name, string studio, int year)
        {
            int id;

            adapter = getNewAdapter();
            DataTable table = adapter.GetAllByInfo(name, studio, year);
            adapter.Dispose();

            id = (int)table.Select()[0].ItemArray[0];

            return id;
        }
        public static bool hasMovieById(int movieId)
        {
            bool hasMovie;

            adapter = getNewAdapter();
            DataTable table = adapter.GetById(movieId);
            adapter.Dispose();

            hasMovie = (table.Select().Length > 0);

            return hasMovie;
        }

        public static bool hasRentedCopyById(int movieId)
        {
            bool hasRented;

            adapter = getNewAdapter();
            DataTable table = adapter.GetUnavailableById(movieId);
            adapter.Dispose();

            hasRented = (table.Select().Length > 0);

            return hasRented;
        }

        public static void incrementTimesRented(string upc)
        {
            adapter = getNewAdapter();
            adapter.IncrementTimesRented(upc);
            adapter.Dispose();
        }

        public static string getMovieName(string upc)
        {
            string movieName = null;

            adapter = getNewAdapter();
            DataTable table = adapter.GetMovieByUPC(upc);
            adapter.Dispose();

            if (table.Select().Length > 0)
            {
                movieName = (string) table.Select()[0].ItemArray[1];
            }

            return movieName;
        }
    }
}
