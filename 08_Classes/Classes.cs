using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_Classes
{
    public class Car
    {
        // Make Properties for CAR
        // Full Constructor 
        // Empty Constructor

        public string CarMake { get; set; }
        public string CarModel { get; set; }

        public int CarYear { get; set; }

        public Car(string carMake, string carModel, int carYear)
        {
            CarMake = carMake;
            CarModel = carModel;
            CarYear = carYear;
            
        }

        public Car() {}
    }




    public class Movie
    {
        // Class OBJECT

        public string Title { get; set; } //PROPERTY 
        public string DirectorName { get; set; }     
        public int Stars { get; set; } 
        public rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }
          
        //   FULL CONSTRUCTOR 
        public Movie(string Title, string DirectorName, int Stars, Rating MovieRating, Genre MovieGenre)
        {
            Title = title;
            DirectorName = directorName;
            Stars = stars;
            MovieRating = movieRating;
            MovieGenre = movieGenre;
        }
    }
        //EMPTY CONSTRUCTOR 
        public Movie() {}
   
   
   
    public enum Rating {G, PG, PG_13, R, MA}
    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
}