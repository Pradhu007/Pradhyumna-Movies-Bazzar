using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    public class Customer:User
    {



        public void BookMovie()
        {
            // Needs work 

        }


        public void ViewMovies()
        {
            // Needs work 

        }



        public string CustomerID { get; set; }
        // General variables that are used to store the details related to a movie

        //Create Movie Booking List<>






        public Customer(string firstname,string lastname,string age,string gender,string email,string username,string password):base(firstname,lastname,age,email,password,gender){
            this.CustomerID = CustomerID;
         





        }



    }
}
