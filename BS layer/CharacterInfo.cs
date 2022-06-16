using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
	class CharacterInfo
	{
        DB db = new DB();
        public DataTable getcharacterlist()
        {
            SqlCommand command = new SqlCommand("select characterid  'ID',fullname 'Character',birthday 'birthday', height 'Height' from [Character]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
