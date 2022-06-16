using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TungMovie
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str2 = @"Data Source=Fox/Fox;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void btnClear_Click(object sender, EventArgs e)
        {
            table.Clear();

            dataGridView1.DataSource = table;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtAddress.Text = "";
            txtBalance.Text = "";
            txtEmail.Text = "";
            txtModifiedbu.Text = "";
            txtphone.Text = "";
            txtRolecode.Text = "";
            txtBirthday.Text = "";
            txtUsername.Focus();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str2);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from [User]";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(str2);
            connection.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [User] values (@username,@pass,@fullname,@add,@phone,@dbo,@email,@balance,@rolecode)";

            SqlParameter parName = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.VarChar);
            SqlParameter parFullname = new SqlParameter("@fullname", SqlDbType.VarChar);
            SqlParameter parAdd = new SqlParameter("@add", SqlDbType.VarChar);
            SqlParameter parPhone = new SqlParameter("@phone", SqlDbType.VarChar);
            SqlParameter parDbo = new SqlParameter("@dbo", SqlDbType.Date);
            SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
            SqlParameter parBalance = new SqlParameter("@balance", SqlDbType.Float);
            SqlParameter parRole_code = new SqlParameter("@rolecode", SqlDbType.VarChar);

            parName.Value = txtUsername.Text.Trim();
            parPass.Value = txtPassword.Text.Trim();
            parFullname.Value = txtFullname.Text.Trim();
            parAdd.Value = txtAddress.Text.Trim();
            parPhone.Value = txtphone.Text.Trim();
            parDbo.Value = Convert.ToDateTime(txtBirthday.Text.Trim());
            parEmail.Value = txtEmail.Text.Trim();
            parBalance.Value = float.Parse(txtBalance.Text.Trim());
            parRole_code.Value =/*float.Parse(*/txtRolecode.Text.Trim()/*)*/;

            sqlCmd.Parameters.Add(parName);
            sqlCmd.Parameters.Add(parPass);
            sqlCmd.Parameters.Add(parFullname);
            sqlCmd.Parameters.Add(parAdd);
            sqlCmd.Parameters.Add(parPhone);
            sqlCmd.Parameters.Add(parDbo);
            sqlCmd.Parameters.Add(parEmail);
            sqlCmd.Parameters.Add(parBalance);
            sqlCmd.Parameters.Add(parRole_code);

            sqlCmd.Connection=  connection;
            int kp = sqlCmd.ExecuteNonQuery();
            if(kp >0)
            {
                MessageBox.Show("Da them thong tin thanh cong !!!", "Thong bao");
                btnShow_Click(sender,e);
                //MessageBox.Show("Da them thong tin thanh cong !!!", "Thong bao");
            }
            //else
            //{

            //}

        }

        public void LoadAccount(int vt)
        {
            txtUsername.Text = dataGridView1.Rows[vt].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[vt].Cells[1].Value.ToString();
            txtFullname.Text = dataGridView1.Rows[vt].Cells[2].Value.ToString();
            txtAddress.Text= dataGridView1.Rows[vt].Cells[3].Value.ToString();
            txtphone.Text= dataGridView1.Rows[vt].Cells[4].Value.ToString();
            txtBirthday.Text= /*DateTime.Parse*/(dataGridView1.Rows[vt].Cells[5].Value.ToString());
            txtEmail.Text= dataGridView1.Rows[vt].Cells[6].Value.ToString();
            txtBalance.Text= dataGridView1.Rows[vt].Cells[7].Value.ToString();
            txtRolecode.Text= dataGridView1.Rows[vt].Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str2);
            connection.Open();
            //command = connection.CreateCommand();
            //command.CommandText = "proc_Delete_account";
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("username", txtUsername.Text);
            //command.ExecuteNonQuery(); ;
            //command = connection.CreateCommand();
            //command.CommandText = "select * from [User]";
            //adapter.SelectCommand = command;
            //table.Clear();
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from [User] where [username] = @username";

            SqlParameter parName = new SqlParameter("@username", SqlDbType.VarChar);
            //SqlParameter parPass = new SqlParameter("@pass", SqlDbType.VarChar);
            //SqlParameter parFullname = new SqlParameter("@fullname", SqlDbType.VarChar);
            //SqlParameter parAdd = new SqlParameter("@add", SqlDbType.VarChar);
            //SqlParameter parPhone = new SqlParameter("@phone", SqlDbType.VarChar);
            //SqlParameter parDbo = new SqlParameter("@dbo", SqlDbType.Date);
            //SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
            //SqlParameter parBalance = new SqlParameter("@balance", SqlDbType.Float);
            //SqlParameter parRole_code = new SqlParameter("@rolecode", SqlDbType.VarChar);

            parName.Value = txtUsername.Text.Trim();
            //parPass.Value = txtPassword.Text.Trim();
            //parFullname.Value = txtFullname.Text.Trim();
            //parAdd.Value = txtAddress.Text.Trim();
            //parPhone.Value = txtphone.Text.Trim();
            //parDbo.Value = Convert.ToDateTime(txtBirthday.Text.Trim());
            //parEmail.Value = txtEmail.Text.Trim();
            //parBalance.Value = float.Parse(txtBalance.Text.Trim());
            //parRole_code.Value =/*float.Parse(*/txtRolecode.Text.Trim()/*)*/;

            sqlCmd.Parameters.Add(parName);
            //sqlCmd.Parameters.Add(parPass);
            //sqlCmd.Parameters.Add(parFullname);
            //sqlCmd.Parameters.Add(parAdd);
            //sqlCmd.Parameters.Add(parPhone);
            //sqlCmd.Parameters.Add(parDbo);
            //sqlCmd.Parameters.Add(parEmail);
            //sqlCmd.Parameters.Add(parBalance);
            //sqlCmd.Parameters.Add(parRole_code);

            sqlCmd.Connection = connection;
            int kp = sqlCmd.ExecuteNonQuery();
            if (kp > 0)
            {
                MessageBox.Show("Da xoa thong tin thanh cong !!!", "Thong bao");
                btnShow_Click(sender, e);
                txtUsername.Clear();
                txtPassword.Clear();
                txtFullname.Clear();
                txtAddress.Clear();
                txtphone.Clear();
                txtBirthday.Clear();
                txtEmail.Clear();
                txtBalance.Clear();
                txtRolecode.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str2);
            connection.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update [User] set [password]=@pass,[fullname]=@fullname,[address]=@add,[phone]=@phone,[birthday]=@dbo,[email]=@email,[balance]=@balance,[role_code]=@rolecode where [username] = @username";

            SqlParameter parName = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.VarChar);
            SqlParameter parFullname = new SqlParameter("@fullname", SqlDbType.VarChar);
            SqlParameter parAdd = new SqlParameter("@add", SqlDbType.VarChar);
            SqlParameter parPhone = new SqlParameter("@phone", SqlDbType.VarChar);
            SqlParameter parDbo = new SqlParameter("@dbo", SqlDbType.Date);
            SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
            SqlParameter parBalance = new SqlParameter("@balance", SqlDbType.Float);
            SqlParameter parRole_code = new SqlParameter("@rolecode", SqlDbType.VarChar);

            parName.Value = txtUsername.Text.Trim();
            parPass.Value = txtPassword.Text.Trim();
            parFullname.Value = txtFullname.Text.Trim();
            parAdd.Value = txtAddress.Text.Trim();
            parPhone.Value = txtphone.Text.Trim();
            parDbo.Value = Convert.ToDateTime(txtBirthday.Text.Trim());
            parEmail.Value = txtEmail.Text.Trim();
            parBalance.Value = float.Parse(txtBalance.Text.Trim());
            parRole_code.Value =/*float.Parse(*/txtRolecode.Text.Trim()/*)*/;

            sqlCmd.Parameters.Add(parName);
            sqlCmd.Parameters.Add(parPass);
            sqlCmd.Parameters.Add(parFullname);
            sqlCmd.Parameters.Add(parAdd);
            sqlCmd.Parameters.Add(parPhone);
            sqlCmd.Parameters.Add(parDbo);
            sqlCmd.Parameters.Add(parEmail);
            sqlCmd.Parameters.Add(parBalance);
            sqlCmd.Parameters.Add(parRole_code);

            sqlCmd.Connection = connection;
            int kp = sqlCmd.ExecuteNonQuery();
            if (kp > 0)
            {
                MessageBox.Show("Da sua thong tin thanh cong !!!", "Thong bao");
                btnShow_Click(sender, e);
                //MessageBox.Show("Da them thong tin thanh cong !!!", "Thong bao");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Selected = true;
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
            txtFullname.Text = dataGridView1.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
            txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            txtBirthday.Text = dataGridView1.Rows[e.RowIndex].Cells["birthday"].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtBalance.Text = dataGridView1.Rows[e.RowIndex].Cells["balance"].Value.ToString();
            txtRolecode.Text = dataGridView1.Rows[e.RowIndex].Cells["role_code"].Value.ToString();
            //txtModifiedbu.Text = dataGridView1.Rows[e.RowIndex].Cells["modified_by"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManagement a = new AdminManagement();
            a.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ////int vt = dataGridView1.CurrentCell.RowIndex;
            //txtUsername.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //txtPassword.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //txtFullname.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //txtAddress.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //txtphone.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //txtBirthday.Text = /*DateTime.Parse*/(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString());
            //txtEmail.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            //txtBalance.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            //txtRolecode.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtFullname.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtphone.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtBirthday.Text = /*DateTime.Parse*/(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString());
            txtEmail.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtBalance.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtRolecode.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
