using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight2
{
    class DalManager
    {
        public static string ConString { get; } = "Server=localhost;Database=movienight;Trusted_Connection=True;";

        public static Actor InsertActor(Actor actor)
        {
            string query = "INSERT INTO actor (id, fname, lastname) OUTPUT INSERTED.ID VALUES (@id, @fn, @ln)";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fn", actor.Name);
                cmd.Parameters.AddWithValue("@ln", actor.LastName);
                cmd.Parameters.AddWithValue("@id", actor.Id);
                cmd.ExecuteNonQuery();
            }
            return actor;
        }

        public static Movie InsertMovie(Movie movie)
        {
            string query = "INSERT INTO movie (title, description, year, genre) VALUES (@title, @desc, @year, @genre)";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@desc", movie.Description);
                cmd.Parameters.AddWithValue("@year", movie.Year);
                cmd.Parameters.AddWithValue("@genre", movie.Genre);
                cmd.ExecuteNonQuery();
            }
            return movie;
        }

        public static Movie UpdateMovie(Movie movie)
        {
            string query = "UPDATE movie SET title = @tile, description = @desc, year = @year, genre = @genre";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@desc", movie.Description);
                cmd.Parameters.AddWithValue("@year", movie.Year);
                cmd.Parameters.AddWithValue("@genre", movie.Genre);
                cmd.ExecuteNonQuery();
            }
            return movie;
        }

        public static Actor UpdateActor(Actor actor)
        {
            string query = "UPDATE actor id = @id, fname = @fname, lastname = @lastname";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fn", actor.Name);
                cmd.Parameters.AddWithValue("@ln", actor.LastName);
                cmd.Parameters.AddWithValue("@id", actor.Id);
                cmd.ExecuteNonQuery();
            }
            return actor;
        }

        public static void DeleteMovie()
        {
            string query = "DELETE FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.ExecuteNonQuery();
            };
        }

        public static void DeleteActor()
        {
            string query = "DELETE FROM actor";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
