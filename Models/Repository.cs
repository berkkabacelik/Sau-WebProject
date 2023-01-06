using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies= null;

         static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {Id=1, Name="Shazam", Description="Shazam", ImageUrl="shazam.jpg"},
                new Movie() {Id=2, Name="Amazing Grace", Description="Amazing Grace", ImageUrl="amazing_grace.jpg"},
                new Movie() {Id=3, Name="High Life", Description="High Life", ImageUrl="high_life.jpg"},
                new Movie() {Id=4, Name="Billboard", Description="Billboard", ImageUrl="billboard.jpg"},
                new Movie() {Id=5, Name="Storm Boy", Description="Storm Boy", ImageUrl="storm_boy.jpg"}


            };

        }

        public static List<Movie> Movies 
        {
            get
            {
                return _movies;

            }

        }
        
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);

        }
 
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id ==id);

        }
        

       
        
    }
}