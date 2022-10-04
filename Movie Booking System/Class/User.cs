
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    
    public class User
    {

        // The user class is used as a template class for both the customer and the staff so that those classes can inherit the common 
        // properties and attributes from the user class.
        // This is intended to achieve code maintainability


        public string firstname{ get; set; }

        // Just basic customer info 

        public string lastname { get; set; }
        public string  age { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }

        // General variables that are going to store the arguments passed by the user in the contructor







        public User(string firstname,string lastname,string age,string email,string password,string gender)
        {
            this.firstname = firstname; 
            this.lastname = lastname;
            this.age = age;         
            this.email = email;
            this.password = password;
            this.gender = gender;  

            // These statements of code basically store the arguments passed by  the user into these variables.
            
        }
        




    }

}
