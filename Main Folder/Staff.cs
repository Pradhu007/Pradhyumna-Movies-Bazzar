using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    public class Staff:User
    {



       
        public string USMID { get; set; }
        // Used to store the Staff Id 


        public Staff(string firstname, string lastname, string age, string gender, string email,string password):base(firstname,lastname,age,email,password,gender)
        {
            this.USMID = USMID;

            // The base class gets the variables passed in the user class. In this way, this can help to maintain code. 



        }





    }
}
