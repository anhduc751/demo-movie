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
	public partial class FormLogin : Form
	{
		User us = new User();
		DB db = new DB();

		public FormLogin()
		{
			InitializeComponent();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{

		}

		private void labelCreateNewAccount_Click(object sender, EventArgs e)
		{
			new FrmRegister().Show();
			this.Hide();
		}

		private void CheckbcShowpas_CheckedChanged(object sender, EventArgs e)
		{
			if(CheckbcShowpas.Checked)
			{
				txtPassword.PasswordChar = '\0';
			}
			else
			{
				txtPassword.PasswordChar = '*';
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtUsename.Text = "";
			txtPassword.Text = "";
			txtUsename.Focus();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsename.Text;
			string password = txtPassword.Text;
			string role = null;
			if (us.login(username, password))
			{
				MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK);
				role = us.getrole(username);
				if (role == "USER")
					new FormMenuCustomer().Show();
				else if (role == "ADMIN")
					new AdminManagement().Show();
				else if (role == "MANAGER")
					new ManagerForm().Show();
				UserStore.StoreUsername = username;
				this.Hide();
			}
			else
			{
				MessageBox.Show("Check username or password", "Login", MessageBoxButtons.OK);
			}
		}


        private void txtUsename_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				txtPassword.Focus();
			}
		}

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}
    }
}
