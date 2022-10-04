using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pradhyumna_Movies_Bazzar
{
    public  class MovieBazzar
    {

        List<MovieDB> movieDB = new List<MovieDB>();
        List<User> userDB = new List<User>();
        List<FoodDB> foodDB = new List<FoodDB>();
        // Three list used as  databases to store different info  and for other purposes




      public void AddFood(FoodDB food)
        {
            foodDB.Add(food);
            // This function creates the ability for the staff to add food into the food database 

        }


      public void RemoveFood(FoodDB food)
        {
            foodDB.Remove(food);
            // This function creates the ability for the staff to remove  food from  the food database 
        }



        public FoodDB SearchFood(string foodid)
        {
            for(int i = 0; i < foodDB.Count; i++)
            {
                FoodDB foodDBItem = foodDB[i];

                if(foodDBItem.id == foodid)
                {
                    return foodDBItem;
                    // Returns the object which relates to the food id 
                }
            }
            return null;
            // Returns nothing if the food id is not found in the food database 



        }
       public void AddMovie(MovieDB movie)
        {
            movieDB.Add(movie);
            // Adds a movie into a list of movies 
           

        }

        public void RemoveMovie(MovieDB movie)
        {
            movieDB.Remove(movie);
            // Removes  a movie from  a list of movies 
        }


        public MovieDB SearchMovie(string movieid)
        {
            for(int i = 0; i < movieDB.Count; i++)
            {
                MovieDB movieDBItem = movieDB[i];
                
                if(movieDBItem.movieid == movieid){
                    return movieDBItem;
                    // Gets the movie object searched by the movie id 
                }
            }
            return null;


        }


        public void AddCustomer(User user)
        {
            userDB.Add(user);
            // Adds a user  into the user's database 

        }

        public void RemoveCustomer(User user)
        {
            userDB.Remove(user);
            // Removes a user  from the user's database 
        }



        


        
      

    }
}
