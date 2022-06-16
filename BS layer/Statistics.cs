using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungMovie
{

    class Statistics
    {
        DB db = new DB();

        public DataTable getStatisticsList()
        {
            SqlCommand command = new SqlCommand("Select * from [Statistics]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getStatisticsTotalId()
        {
            SqlCommand command = new SqlCommand("select count(statisticsid) from [Statistics]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getTotalRevenueByMovieId(int movie_id)
        {
            SqlCommand command = new SqlCommand("select sum(price) from Ticket where movie_id = @movie_id", db.GetConnection);
            command.Parameters.Add("@movie_id", SqlDbType.Int).Value = movie_id;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool updateTotalRevenueByMovieId(int statisticsid, int revenue)
        {
            SqlCommand command = new SqlCommand("update [Statistics] set revenue = @revenue where statisticsid = @statisticsid", db.GetConnection);
            command.Parameters.Add("@statisticsid", SqlDbType.Int).Value = statisticsid;
            command.Parameters.Add("@revenue", SqlDbType.Int).Value = revenue;
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
