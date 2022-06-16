using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
    internal class Schedule
    {
        DB db = new DB();
        public DataSet getTicketInfo()
        {
            SqlCommand command = new SqlCommand("select scheduleid  'ID',start_time 'Start',end_time 'End', movie_id 'Movie ID', room_id 'Room' from [Schedule]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getScheduleList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Schedule", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getMovieList()
        {
            SqlCommand cmd = new SqlCommand("Select movieid from Movie", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getRoomList()
        {
            SqlCommand cmd = new SqlCommand("Select roomid from Room", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getScheduleById(int id)
        {
            SqlCommand cmd = new SqlCommand("Select start_time, end_time, movie_id, room_id from Schedule where scheduleid = @id", db.GetConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public bool addSchedule(int scheduleid, DateTime start, DateTime end, int movieId, int roomId)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Schedule (scheduleid, start_time, end_time, movie_id, room_id) VALUES (@scheduleid, @start, @end, @movieId, @roomId)", db.GetConnection);
            command.Parameters.Add("@scheduleid", SqlDbType.Int).Value = scheduleid;
            command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            command.Parameters.Add("@movieId", SqlDbType.Int).Value = movieId;
            command.Parameters.Add("@roomId", SqlDbType.Int).Value = roomId;


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
        public bool updateSchedule(int scheduleid, DateTime start, DateTime end, int movieId, int roomId)
        {
            SqlCommand command = new SqlCommand("UPDATE Schedule SET start_time = @start, end_time = @end, movie_id = @movieId " +
                ", room_id = @roomId WHERE scheduleid = @scheduleid", db.GetConnection);
            command.Parameters.Add("@scheduleid", SqlDbType.Int).Value = scheduleid;
            command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            command.Parameters.Add("@movieId", SqlDbType.Int).Value = movieId;
            command.Parameters.Add("@roomId", SqlDbType.Int).Value = roomId;

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
        public bool deleteSchedule(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Schedule WHERE scheduleid = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public DataTable getScheduleListByMovieId(int movie_id)
        {
            SqlCommand cmd = new SqlCommand("select scheduleid, start_time, end_time, room_id from Schedule where movie_id = @movie_id", db.GetConnection);
            cmd.Parameters.Add("@movie_id", SqlDbType.Int).Value = movie_id;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
