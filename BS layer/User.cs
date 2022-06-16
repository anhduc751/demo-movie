using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TungMovie
{
	class User
	{
        DB db = new DB();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public bool login(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT username, password FROM [User] WHERE username = @username and password = @password", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
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
        public void auth_register(string username, string password, string fullname,string address, DateTime year,string phonenumber,string email )
        {
               using (SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
              using (var cmd = new SqlCommand("dbo.proc_Add_account", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phonenumber;
                cmd.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = year;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@balance", SqlDbType.Float).Value = 0;
                cmd.Parameters.Add("@roleCode", SqlDbType.NVarChar).Value = "USER";
                cmd.Parameters.Add("@createdBy", SqlDbType.NVarChar).Value = "";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public string getrole(string username)
        {
            string rolename = "";
            SqlCommand command = new SqlCommand("SELECT role_code FROM [User] WHERE username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataReader sda = command.ExecuteReader();
            while (sda.Read())
            {
                rolename = sda.GetString(0);
            }
            return rolename;
        }

        public bool updateUserInfo(string username, string password, string fullname, string address, int phone, DateTime birthday, string email)
        {
            SqlCommand command = new SqlCommand("update [User] set password = @password, fullname = @fullname, address = @address" +
                " , phone = @phone, birthday = @birthday, email = @email where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
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

        public DataTable getUserInfoByName(string username)
        {
            SqlCommand command = new SqlCommand("select password, fullname, address, phone, birthday, email from [User] where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
