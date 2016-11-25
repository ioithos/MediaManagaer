using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class DVD
    {
        private string movieName;
        private string upc;

        public DVD(string movieName, string upc)
        {
            this.movieName = movieName;
            this.upc = upc;
        }

        public string getMovieName()
        {
            return movieName;
        }

        public string getUpc()
        {
            return upc;
        }
    }
}
