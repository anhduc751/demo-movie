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
	public partial class FrmRegister : Form
	{
		User us = new User();
		public FrmRegister()
		{
			InitializeComponent();
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void labelBacktoLogin_Click(object sender, EventArgs e)
		{
			new FormLogin().Show();
			this.Hide();
		}

		private void FrmRegister_Load(object sender, EventArgs e)
		{

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtUsename.Text = "";
			txtPassword.Text = "";
			txtConfirmPassword.Text = "";
			txtFullname.Text = "";
			txtAddress.Text = "";
			txtEmail.Text = "";
			textPhone.Text = "";
			dateTimePicker1.Value = DateTime.Now;
			txtUsename.Focus();

		}

		private void CheckbcShowpas_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckbcShowpas.Checked)
			{
				txtPassword.PasswordChar = '\0';
				txtConfirmPassword.PasswordChar = '\0';
			}
			else
			{
				txtPassword.PasswordChar = '*';
				txtConfirmPassword.PasswordChar = '*';
			}
		}
		bool verif()
		{
			if ((txtFullname.Text.Trim() == "")
			|| (txtAddress.Text.Trim() == "")
			|| (txtEmail.Text.Trim() == "")
			|| (txtUsename.Text.Trim() == "")
			|| (txtPassword.Text.Trim() == "")
			|| (txtConfirmPassword.Text.Trim() == "")
			|| (textPhone.Text.Trim() == ""))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		private void btnRegister_Click(object sender, EventArgs e)
		{
			
			if (verif())
			{
				string username = txtUsename.Text;
				string password = txtPassword.Text;
				string fullname = txtFullname.Text;
				string address = txtAddress.Text;
				string email = txtEmail.Text;
				DateTime year = (dateTimePicker1.Value);
				string phonenumber = textPhone.Text;
				if (txtPassword.Text != txtConfirmPassword.Text)
				{
					MessageBox.Show("Check the Confirm Password.", "Register", MessageBoxButtons.OK);
				}
				else
				{
					us.auth_register(username, password, fullname, address, year, phonenumber, email);
					MessageBox.Show("Register successful", "Register", MessageBoxButtons.OK);

					/*if (us.auth_register(username, password, fullname, address, year, phonenumber, email))
					{
						MessageBox.Show("Register Fail", "Register", MessageBoxButtons.OK);

					}
					else
					{
						MessageBox.Show("Register successful", "Register", MessageBoxButtons.OK);
					}*/
				}
			}
			else
			{
				MessageBox.Show("Check all the information again", "Register", MessageBoxButtons.OK);
			}
		}
	}
}
