using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class EditInfo : Form
    {
        User us = new User();

        public EditInfo()
        {
            InitializeComponent();
        }


        private void btn_UpdateAccount_Click(object sender, EventArgs e)
        {
            if(verif())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string fullname = txtFullname.Text;
                string address = txtAddress.Text;
                int phone = Int32.Parse(txtPhone.Text);
                DateTime birthday = dateBirthday.Value;
                string email = txtEmail.Text;
                if(us.updateUserInfo(username,password,fullname,address,phone,birthday,email))
                {
                    MessageBox.Show("Update successful", "User info", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "User info", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Blank is not allowed", "User info", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool verif()
        {
            if ((txtPassword.Text.Trim() == "")
                || (txtFullname.Text.Trim() == "")
                || (txtAddress.Text.Trim() == "")
                || (txtPhone.Text.Trim() == "")
                || (txtEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            userinfoLoad();
        }

        private void userinfoLoad()
        {
            txtUsername.Text = UserStore.StoreUsername;
            DataTable dt = us.getUserInfoByName(UserStore.StoreUsername);
            try
            {
                txtPassword.Text = dt.Rows[0][0].ToString();
                txtFullname.Text = dt.Rows[0][1].ToString();
                txtAddress.Text = dt.Rows[0][2].ToString();
                txtPhone.Text = dt.Rows[0][3].ToString();
                dateBirthday.Value = DateTime.Parse(dt.Rows[0][4].ToString());
                txtEmail.Text = dt.Rows[0][5].ToString();
            }
            catch
            {

            }
        }
    }
}
