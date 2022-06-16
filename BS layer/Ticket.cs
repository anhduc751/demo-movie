using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
    class Ticket
    {
        DB db = new DB();

        public DataTable getTicketList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Ticket", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getTicketListByUsername(string username)
        {
            SqlCommand cmd = new SqlCommand("Select ticketid, price, booking_date, schedule_id, seat_id, room_id  from Ticket where username = @username", db.GetConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getUsernameList()
        {
            SqlCommand cmd = new SqlCommand("select username from [User]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getSeatList()
        {
            SqlCommand cmd = new SqlCommand("select seatid from Seat", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getScheduleList()
        {
            SqlCommand cmd = new SqlCommand("Select scheduleid from Schedule", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public DataTable getTicketById(int tid)
        {
            SqlCommand cmd = new SqlCommand("Select price, booking_date, schedule_id, username, seat_id, room_id from Ticket where ticketid = @tid", db.GetConnection);
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = tid;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getAvailableTicketIdWithPrice(int price)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from Ticket where username is null and price = @price", db.GetConnection);
            cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public bool addTicket(int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Ticket (price) VALUES (@price)", db.GetConnection);
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;

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

        public bool updateTicket(int ticketid, int price, DateTime booking_date, int schedule_id, string username, int seat_id, int room_id)
        {
            SqlCommand command = new SqlCommand("UPDATE Ticket SET price = @price, booking_date = @booking_date, schedule_id = @schedule_id " +
                ", username = @username, seat_id = @seat_id, room_id = @room_id WHERE ticketid = @ticketid", db.GetConnection);
            command.Parameters.Add("@ticketid", SqlDbType.Int).Value = ticketid;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = price;
            command.Parameters.Add("@booking_date", SqlDbType.Date).Value = booking_date;
            command.Parameters.Add("@schedule_id", SqlDbType.Int).Value = schedule_id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@seat_id", SqlDbType.Int).Value = seat_id;
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

        public bool resetIncrement()
        {
            SqlCommand command = new SqlCommand("DECLARE @number INT; select @number = max(ticketid) from Ticket; DBCC CHECKIDENT ('Ticket', RESEED, @number)", db.GetConnection);
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

        public bool bookTicket(int ticketid, int price, DateTime booking_date, int schedule_id, string username, int seat_id, int room_id, int movie_id)
        {
            SqlCommand command = new SqlCommand("UPDATE Ticket SET booking_date = @booking_date, schedule_id = @schedule_id " +
                ", username = @username, seat_id = @seat_id, room_id = @room_id, movie_id = @movie_id where ticketid = @ticketid and price = @price", db.GetConnection);
            command.Parameters.Add("@ticketid", SqlDbType.VarChar).Value = ticketid;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = price;
            command.Parameters.Add("@booking_date", SqlDbType.DateTime).Value = booking_date;
            command.Parameters.Add("@schedule_id", SqlDbType.Int).Value = schedule_id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@seat_id", SqlDbType.Int).Value = seat_id;
            command.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
            command.Parameters.Add("@movie_id", SqlDbType.Int).Value = movie_id;

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
