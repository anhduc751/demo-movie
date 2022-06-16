using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungMovie
{
    class Seat
    {
        DB db = new DB();

        public DataTable getSeatList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Seat", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getSeatById(int seatid)
        {
            SqlCommand cmd = new SqlCommand("Select code, kind, status, room_id from Seat where seatid = @seatid", db.GetConnection);
            cmd.Parameters.Add("@seatid", SqlDbType.Int).Value = seatid;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool updateSeat(int seatid, int code, string kind, string status, int room_id)
        {
            SqlCommand command = new SqlCommand("UPDATE Seat SET code = @code, kind = @kind, status = @status " +
                ", room_id = @room_id WHERE seatid = @seatid", db.GetConnection);
            command.Parameters.Add("@seatid", SqlDbType.Int).Value = seatid;
            command.Parameters.Add("@code", SqlDbType.Int).Value = code;
            command.Parameters.Add("@kind", SqlDbType.VarChar).Value = kind;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;

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

        public DataTable getSeatListByRoomID(int roomid)
        {
            SqlCommand command = new SqlCommand("select seatid, kind from Seat where room_id = @roomid and status = 'False'", db.GetConnection);
            command.Parameters.Add("@roomid", SqlDbType.Int).Value = roomid;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getSeatKind(int seatid)
        {
            SqlCommand command = new SqlCommand("select kind from Seat where seatid = @seatid", db.GetConnection);
            command.Parameters.Add("@seatid", SqlDbType.Int).Value = seatid;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool bookSeat(int seatid)
        {
            SqlCommand command = new SqlCommand("UPDATE Seat SET status = 'True' WHERE seatid = @seatid", db.GetConnection);
            command.Parameters.Add("@seatid", SqlDbType.Int).Value = seatid;
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
