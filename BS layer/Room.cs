using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
    internal class Room
    {
        DB db = new DB();
        public DataTable getroomlist()
        {
            SqlCommand command = new SqlCommand("select roomid 'ID',name 'Name', num_of_seats 'Seats Amount' from [Room]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public bool AddRoom(string name, int seat)
        {
            SqlCommand command = new SqlCommand("insert into Room values(@name, @seat)", db.GetConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@seat", SqlDbType.Int).Value = seat;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
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
        public bool DeleteRoom(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Room where roomid = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool UpdateRoom(int roomid, string name, int seat)
        {
            SqlCommand command = new SqlCommand("update Room set name = @name, num_of_seats = @seat where roomid = @roomid", db.GetConnection);
            command.Parameters.Add("@roomid", SqlDbType.Int).Value = roomid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@seat", SqlDbType.Int).Value = seat;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
