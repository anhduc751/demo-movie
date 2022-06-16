using System.Data.SqlClient;

namespace TungMovie
{
    class DB
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3NHLU4HH\DUCNGUYEN;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
