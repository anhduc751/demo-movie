using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace TungMovie
{
	class MovieInfo
	{
		DB db = new DB();


        public DataTable getmovielist()
        {
            SqlCommand command = new SqlCommand("select movieid  'ID',name 'Movie',thumbnail 'Thumbnail', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration' from [Movie]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataSet addMovie(string MovieN, string rating, string genre, string description, string duration, MemoryStream thumbnail)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Movie_ticket_management].[dbo].[Movie] (name, rating, genre, short_description , duration, thumbnail )" +
                                                 "VALUES ('" + MovieN + "', '" + rating + "', '" + genre + "', ' " + description + "', '" + duration + "', '" + thumbnail.ToArray() + "');", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet updateMovie(string name, string rating, string genre, string short_description, string duration, string movieid, MemoryStream thumbnail)
        {
            SqlCommand command = new SqlCommand("UPDATE [Movie] SET name = @name, rating = @rating, genre = @genre, short_description = @short_description " +
                ", duration = @duration, thumbnail = @thumbnail WHERE movieid = @movieid", db.GetConnection);
            command.Parameters.Add("@movieid", SqlDbType.Int).Value = movieid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@rating", SqlDbType.Int).Value = rating;
            command.Parameters.Add("@genre", SqlDbType.VarChar).Value = genre;
            command.Parameters.Add("@short_description", SqlDbType.VarChar).Value = short_description;
            command.Parameters.Add("@duration", SqlDbType.Int).Value = duration;
            command.Parameters.Add("@thumbnail", SqlDbType.Image).Value = thumbnail.ToArray();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet DeleteMovie(string movieid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Movie_ticket_management].[dbo].[Movie] WHERE movieid = '" + movieid + "' ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public bool insertMovieStatistics(string movie)
        {
            SqlCommand command = new SqlCommand("UPDATE [Statistics] (movie) Values (@movie)", db.GetConnection);
            command.Parameters.Add("@seatid", SqlDbType.VarChar).Value = movie;
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
