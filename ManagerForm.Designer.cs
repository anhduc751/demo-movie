
namespace TungMovie
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.labelRegister = new System.Windows.Forms.Label();
            this.btnScheduleManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRoomManagement = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnFilmManagement = new System.Windows.Forms.Button();
            this.btnSeatManagement = new System.Windows.Forms.Button();
            this.btnTicketManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(162, 21);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(202, 31);
            this.labelRegister.TabIndex = 31;
            this.labelRegister.Text = "Manager Form";
            // 
            // btnScheduleManagement
            // 
            this.btnScheduleManagement.BackColor = System.Drawing.Color.White;
            this.btnScheduleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleManagement.ForeColor = System.Drawing.Color.White;
            this.btnScheduleManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleManagement.Image")));
            this.btnScheduleManagement.Location = new System.Drawing.Point(122, 158);
            this.btnScheduleManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleManagement.Name = "btnScheduleManagement";
            this.btnScheduleManagement.Size = new System.Drawing.Size(78, 50);
            this.btnScheduleManagement.TabIndex = 32;
            this.btnScheduleManagement.UseVisualStyleBackColor = false;
            this.btnScheduleManagement.Click += new System.EventHandler(this.btnScheduleManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Schedule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Room";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Seat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Movie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ticket";
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.BackColor = System.Drawing.Color.White;
            this.btnRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomManagement.ForeColor = System.Drawing.Color.White;
            this.btnRoomManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomManagement.Image")));
            this.btnRoomManagement.Location = new System.Drawing.Point(122, 228);
            this.btnRoomManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Size = new System.Drawing.Size(78, 50);
            this.btnRoomManagement.TabIndex = 43;
            this.btnRoomManagement.Text = "button3";
            this.btnRoomManagement.UseVisualStyleBackColor = false;
            this.btnRoomManagement.Click += new System.EventHandler(this.btnRoomManagement_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.BackColor = System.Drawing.Color.White;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.ForeColor = System.Drawing.Color.White;
            this.btnAccountManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountManagement.Image")));
            this.btnAccountManagement.Location = new System.Drawing.Point(122, 90);
            this.btnAccountManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(78, 50);
            this.btnAccountManagement.TabIndex = 44;
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnFilmManagement
            // 
            this.btnFilmManagement.BackColor = System.Drawing.Color.White;
            this.btnFilmManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmManagement.ForeColor = System.Drawing.Color.White;
            this.btnFilmManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmManagement.Image")));
            this.btnFilmManagement.Location = new System.Drawing.Point(412, 158);
            this.btnFilmManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilmManagement.Name = "btnFilmManagement";
            this.btnFilmManagement.Size = new System.Drawing.Size(78, 50);
            this.btnFilmManagement.TabIndex = 45;
            this.btnFilmManagement.Text = "button5";
            this.btnFilmManagement.UseVisualStyleBackColor = false;
            this.btnFilmManagement.Click += new System.EventHandler(this.btnFilmManagement_Click);
            // 
            // btnSeatManagement
            // 
            this.btnSeatManagement.BackColor = System.Drawing.Color.White;
            this.btnSeatManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeatManagement.ForeColor = System.Drawing.Color.White;
            this.btnSeatManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnSeatManagement.Image")));
            this.btnSeatManagement.Location = new System.Drawing.Point(412, 229);
            this.btnSeatManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeatManagement.Name = "btnSeatManagement";
            this.btnSeatManagement.Size = new System.Drawing.Size(78, 50);
            this.btnSeatManagement.TabIndex = 46;
            this.btnSeatManagement.UseVisualStyleBackColor = false;
            this.btnSeatManagement.Click += new System.EventHandler(this.btnSeatManagement_Click);
            // 
            // btnTicketManagement
            // 
            this.btnTicketManagement.BackColor = System.Drawing.Color.White;
            this.btnTicketManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketManagement.ForeColor = System.Drawing.Color.White;
            this.btnTicketManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketManagement.Image")));
            this.btnTicketManagement.Location = new System.Drawing.Point(412, 84);
            this.btnTicketManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnTicketManagement.Name = "btnTicketManagement";
            this.btnTicketManagement.Size = new System.Drawing.Size(78, 50);
            this.btnTicketManagement.TabIndex = 50;
            this.btnTicketManagement.UseVisualStyleBackColor = false;
            this.btnTicketManagement.Click += new System.EventHandler(this.btnTicketManagement_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 303);
            this.Controls.Add(this.btnTicketManagement);
            this.Controls.Add(this.btnSeatManagement);
            this.Controls.Add(this.btnFilmManagement);
            this.Controls.Add(this.btnAccountManagement);
            this.Controls.Add(this.btnRoomManagement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScheduleManagement);
            this.Controls.Add(this.labelRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button btnScheduleManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnFilmManagement;
        private System.Windows.Forms.Button btnSeatManagement;
        private System.Windows.Forms.Button btnTicketManagement;
	}
}