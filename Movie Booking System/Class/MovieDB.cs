using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    public class MovieDB
    {
        public string movieid { get; set; }
        public string moviename;
        public string category { get; set; }
        public string location;
        public string description { get; set; }

        // General variables that are used to store the details related to a movie





        public MovieDB(string moviename, string category, string location, string description, string movieid)
        {
            this.moviename = moviename;
            this.category = category;
            this.location = location;
            this.description = description;
            this.movieid = movieid;

            // Stores the argument passed by the user into these properties so that they could accessed later.
        }
    }
}
