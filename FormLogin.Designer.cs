
namespace TungMovie
{
	partial class FormLogin
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
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.CheckbcShowpas = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelCreateNewAccount.Location = new System.Drawing.Point(162, 383);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(147, 16);
            this.labelCreateNewAccount.TabIndex = 23;
            this.labelCreateNewAccount.Text = "Create New Account";
            this.labelCreateNewAccount.Click += new System.EventHandler(this.labelCreateNewAccount_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(245, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(78, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 35);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // CheckbcShowpas
            // 
            this.CheckbcShowpas.AutoSize = true;
            this.CheckbcShowpas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbcShowpas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbcShowpas.ForeColor = System.Drawing.Color.Black;
            this.CheckbcShowpas.Location = new System.Drawing.Point(253, 232);
            this.CheckbcShowpas.Name = "CheckbcShowpas";
            this.CheckbcShowpas.Size = new System.Drawing.Size(132, 20);
            this.CheckbcShowpas.TabIndex = 19;
            this.CheckbcShowpas.Text = "Show password";
            this.CheckbcShowpas.UseVisualStyleBackColor = true;
            this.CheckbcShowpas.CheckedChanged += new System.EventHandler(this.CheckbcShowpas_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(82, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(303, 22);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txtUsename
            // 
            this.txtUsename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUsename.Location = new System.Drawing.Point(82, 128);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.ShortcutsEnabled = false;
            this.txtUsename.Size = new System.Drawing.Size(303, 22);
            this.txtUsename.TabIndex = 14;
            this.txtUsename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsename_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(126, 36);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(150, 31);
            this.labelRegister.TabIndex = 24;
            this.labelRegister.Text = "Welcome !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TungMovie.Properties.Resources.film_reel;
            this.pictureBox1.Location = new System.Drawing.Point(282, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 408);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.CheckbcShowpas);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCreateNewAccount;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox CheckbcShowpas;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsename;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelRegister;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}