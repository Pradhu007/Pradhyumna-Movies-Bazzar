using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    public class  FoodDB
    {
        public string id { get; set; }
        public string itemname { get; set; }

        public string quantity { get; set; }

        public string description { get; set; }

        // General variables that are going to store the arguments passed by the user in the contructor




        public FoodDB(string id,string itemname,string quantity,string description)
        {
            this.id = id; 
            this.itemname = itemname;
            this.quantity = quantity;
            this.description = description;
            // Stores the argument passed by the user into these properties so that they could accessed later.

        }





    }
}
