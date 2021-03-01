using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight2
{
    static class MovieManager
    {

        public static Actor InsertActor(Actor actor)
        {
            return DalManager.InsertActor(actor);
        }

        public static Movie InsertMovie(Movie movie)
        {
            return DalManager.InsertMovie(movie);
        }

        public static Actor UpdateActor(Actor actor)
        {
            return DalManager.UpdateActor(actor);
        }

        public static Movie UpdateMovie(Movie movie)
        {
            return DalManager.UpdateMovie(movie);
        }

        public static void DeleteActor()
        {
            DalManager.DeleteActor();
        }

        public static void DeleteMovie()
        {
            DalManager.DeleteMovie();
        }
    }
}
