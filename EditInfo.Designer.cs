
namespace TungMovie
{
    partial class EditInfo
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
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.btn_UpdateAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Fullname = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateBirthday
            // 
            this.dateBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthday.Location = new System.Drawing.Point(202, 278);
            this.dateBirthday.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateBirthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(100, 22);
            this.dateBirthday.TabIndex = 190;
            this.dateBirthday.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtFullname.Location = new System.Drawing.Point(202, 176);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(188, 16);
            this.txtFullname.TabIndex = 189;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(202, 105);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(100, 16);
            this.txtUsername.TabIndex = 188;
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Birthday.Location = new System.Drawing.Point(69, 278);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(59, 16);
            this.lb_Birthday.TabIndex = 187;
            this.lb_Birthday.Text = "BirthDay";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(202, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 15);
            this.txtEmail.TabIndex = 186;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(69, 312);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(42, 16);
            this.lb_Email.TabIndex = 185;
            this.lb_Email.Text = "Email";
            // 
            // btn_UpdateAccount
            // 
            this.btn_UpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_UpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateAccount.FlatAppearance.BorderSize = 0;
            this.btn_UpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateAccount.Location = new System.Drawing.Point(72, 370);
            this.btn_UpdateAccount.Name = "btn_UpdateAccount";
            this.btn_UpdateAccount.Size = new System.Drawing.Size(136, 40);
            this.btn_UpdateAccount.TabIndex = 184;
            this.btn_UpdateAccount.Text = "UPDATE ACCOUNT";
            this.btn_UpdateAccount.UseVisualStyleBackColor = false;
            this.btn_UpdateAccount.Click += new System.EventHandler(this.btn_UpdateAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(256, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 183;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.Location = new System.Drawing.Point(69, 176);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(63, 16);
            this.lb_Fullname.TabIndex = 182;
            this.lb_Fullname.Text = "Fullname";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(202, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 15);
            this.txtPhone.TabIndex = 181;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(69, 245);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(47, 16);
            this.lb_Phone.TabIndex = 180;
            this.lb_Phone.Text = "Phone";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(69, 213);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(59, 16);
            this.lb_Address.TabIndex = 179;
            this.lb_Address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(202, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 15);
            this.txtAddress.TabIndex = 178;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(69, 105);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(71, 16);
            this.lb_Username.TabIndex = 177;
            this.lb_Username.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(202, 143);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 16);
            this.txtPassword.TabIndex = 176;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(69, 143);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(68, 16);
            this.lb_Password.TabIndex = 175;
            this.lb_Password.Text = "Password";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbInfo.Location = new System.Drawing.Point(161, 27);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(134, 31);
            this.lbInfo.TabIndex = 174;
            this.lbInfo.Text = "User Info";
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 446);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lb_Birthday);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.btn_UpdateAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditInfo";
            this.Text = "EditInfo";
            this.Load += new System.EventHandler(this.EditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button btn_UpdateAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Fullname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lbInfo;
    }
}