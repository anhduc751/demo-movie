using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TungMovie
{
    internal class ListMovie
    {
        DB db = new DB();

        public DataTable getMovieIdAndNameById(int movieid)
        {
            SqlCommand command = new SqlCommand("select movieid, name from [Movie] where movieid = @movieid", db.GetConnection);
            command.Parameters.AddWithValue("@movieid", movieid);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable gettotalmovieamount()
        {
            SqlCommand command = new SqlCommand("select count(movieid) from Movie", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getmovielist()
        {
            SqlCommand command = new SqlCommand("select movieid  'ID',name 'Movie',thumbnail 'Thumbnail', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration' from [Movie]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetMovieById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Thumbnail', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration' FROM Movie WHERE movieid LIKE '%" + id + "%' ", db.GetConnection);
            cmd.Parameters.AddWithValue("@movieid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetMovieByName(string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Thumbnail', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration' FROM Movie WHERE name LIKE '%" + name + "%' ", db.GetConnection);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
