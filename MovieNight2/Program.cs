using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor actor = new Actor(2, "Mark", "Wahlberg");

            Movie movie = new Movie("Harry Potter2", "still lives bellow staircase", 2002, "magic");

            MovieManager.InsertActor(actor);

            MovieManager.InsertMovie(movie);

            MovieManager.UpdateActor(actor);

            MovieManager.DeleteActor();

            MovieManager.DeleteMovie();
        }
    }
}
