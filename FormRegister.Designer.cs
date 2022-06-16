
namespace TungMovie
{
	partial class FrmRegister
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labelRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckbcShowpas = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBacktoLogin = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(265, 19);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(282, 31);
            this.labelRegister.TabIndex = 0;
            this.labelRegister.Text = "Create New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(470, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsename
            // 
            this.txtUsename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUsename.Location = new System.Drawing.Point(474, 101);
            this.txtUsename.Multiline = true;
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.ShortcutsEnabled = false;
            this.txtUsename.Size = new System.Drawing.Size(303, 28);
            this.txtUsename.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(474, 177);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(303, 28);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(470, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConfirmPassword.Location = new System.Drawing.Point(474, 254);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.ShortcutsEnabled = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(303, 28);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(470, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // CheckbcShowpas
            // 
            this.CheckbcShowpas.AutoSize = true;
            this.CheckbcShowpas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbcShowpas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbcShowpas.ForeColor = System.Drawing.Color.Black;
            this.CheckbcShowpas.Location = new System.Drawing.Point(645, 288);
            this.CheckbcShowpas.Name = "CheckbcShowpas";
            this.CheckbcShowpas.Size = new System.Drawing.Size(132, 20);
            this.CheckbcShowpas.TabIndex = 8;
            this.CheckbcShowpas.Text = "Show password";
            this.CheckbcShowpas.UseVisualStyleBackColor = true;
            this.CheckbcShowpas.CheckedChanged += new System.EventHandler(this.CheckbcShowpas_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(474, 338);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 40);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(645, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Already have An Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBacktoLogin
            // 
            this.labelBacktoLogin.AutoSize = true;
            this.labelBacktoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBacktoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelBacktoLogin.Location = new System.Drawing.Point(572, 422);
            this.labelBacktoLogin.Name = "labelBacktoLogin";
            this.labelBacktoLogin.Size = new System.Drawing.Size(109, 16);
            this.labelBacktoLogin.TabIndex = 12;
            this.labelBacktoLogin.Text = "Back to LOGIN";
            this.labelBacktoLogin.Click += new System.EventHandler(this.labelBacktoLogin_Click);
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textPhone.Location = new System.Drawing.Point(42, 253);
            this.textPhone.Multiline = true;
            this.textPhone.Name = "textPhone";
            this.textPhone.ShortcutsEnabled = false;
            this.textPhone.Size = new System.Drawing.Size(303, 28);
            this.textPhone.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone number";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(42, 176);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ShortcutsEnabled = false;
            this.txtAddress.Size = new System.Drawing.Size(303, 28);
            this.txtAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFullname.Location = new System.Drawing.Point(42, 100);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ShortcutsEnabled = false;
            this.txtFullname.Size = new System.Drawing.Size(303, 28);
            this.txtFullname.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fullname";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(42, 389);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(303, 28);
            this.txtEmail.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(38, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelBacktoLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.CheckbcShowpas);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelRegister;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsename;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox CheckbcShowpas;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelBacktoLogin;
		private System.Windows.Forms.TextBox textPhone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}

