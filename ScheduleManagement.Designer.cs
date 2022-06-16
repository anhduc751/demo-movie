
namespace TungMovie
{
    partial class ScheduleManagement
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
            this.dateStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.boxScheduleId = new System.Windows.Forms.ComboBox();
            this.labelIdFilm = new System.Windows.Forms.Label();
            this.labelSched = new System.Windows.Forms.Label();
            this.gridTicketManagement = new System.Windows.Forms.DataGridView();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdMovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnUpdateSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnPrintSchedule = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStartTime
            // 
            this.dateStartTime.CustomFormat = "   dd / MM / yyyy HH:mm:ss";
            this.dateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartTime.Location = new System.Drawing.Point(211, 153);
            this.dateStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateStartTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(253, 26);
            this.dateStartTime.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Start Time";
            // 
            // boxScheduleId
            // 
            this.boxScheduleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxScheduleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxScheduleId.FormattingEnabled = true;
            this.boxScheduleId.ItemHeight = 20;
            this.boxScheduleId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxScheduleId.Location = new System.Drawing.Point(211, 100);
            this.boxScheduleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxScheduleId.Name = "boxScheduleId";
            this.boxScheduleId.Size = new System.Drawing.Size(92, 28);
            this.boxScheduleId.TabIndex = 106;
            this.boxScheduleId.SelectedIndexChanged += new System.EventHandler(this.boxScheduleId_SelectedIndexChanged);
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(23, 100);
            this.labelIdFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(100, 20);
            this.labelIdFilm.TabIndex = 105;
            this.labelIdFilm.Text = "ID Schedule";
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSched.Location = new System.Drawing.Point(19, 28);
            this.labelSched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(386, 39);
            this.labelSched.TabIndex = 102;
            this.labelSched.Text = "Schedule Management";
            // 
            // gridTicketManagement
            // 
            this.gridTicketManagement.AllowUserToAddRows = false;
            this.gridTicketManagement.AllowUserToDeleteRows = false;
            this.gridTicketManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTicketManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTicketManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTicketManagement.Location = new System.Drawing.Point(535, 28);
            this.gridTicketManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTicketManagement.Name = "gridTicketManagement";
            this.gridTicketManagement.ReadOnly = true;
            this.gridTicketManagement.RowHeadersVisible = false;
            this.gridTicketManagement.RowHeadersWidth = 51;
            this.gridTicketManagement.Size = new System.Drawing.Size(631, 457);
            this.gridTicketManagement.TabIndex = 101;
            // 
            // dateEndTime
            // 
            this.dateEndTime.CustomFormat = "   dd / MM / yyyy HH:mm:ss";
            this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndTime.Location = new System.Drawing.Point(211, 207);
            this.dateEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateEndTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(253, 26);
            this.dateEndTime.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "End Time";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdRoom.Location = new System.Drawing.Point(211, 303);
            this.txtIdRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(93, 19);
            this.txtIdRoom.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "ID Room";
            // 
            // txtIdMovie
            // 
            this.txtIdMovie.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtIdMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdMovie.Location = new System.Drawing.Point(211, 258);
            this.txtIdMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdMovie.Name = "txtIdMovie";
            this.txtIdMovie.Size = new System.Drawing.Size(93, 19);
            this.txtIdMovie.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "ID Movie";
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(189, 367);
            this.btnDeleteSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(160, 49);
            this.btnDeleteSchedule.TabIndex = 118;
            this.btnDeleteSchedule.Text = "DELETE SCHEDULE";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSchedule.FlatAppearance.BorderSize = 0;
            this.btnUpdateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSchedule.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSchedule.Location = new System.Drawing.Point(357, 367);
            this.btnUpdateSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(160, 49);
            this.btnUpdateSchedule.TabIndex = 117;
            this.btnUpdateSchedule.Text = "UPDATE SCHEDULE";
            this.btnUpdateSchedule.UseVisualStyleBackColor = false;
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(21, 367);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(160, 49);
            this.btnAddSchedule.TabIndex = 116;
            this.btnAddSchedule.Text = "ADD SCHEDULE";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnPrintSchedule
            // 
            this.btnPrintSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPrintSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSchedule.FlatAppearance.BorderSize = 0;
            this.btnPrintSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSchedule.ForeColor = System.Drawing.Color.White;
            this.btnPrintSchedule.Location = new System.Drawing.Point(281, 434);
            this.btnPrintSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintSchedule.Name = "btnPrintSchedule";
            this.btnPrintSchedule.Size = new System.Drawing.Size(213, 49);
            this.btnPrintSchedule.TabIndex = 120;
            this.btnPrintSchedule.Text = "PRINT SCHEDULE";
            this.btnPrintSchedule.UseVisualStyleBackColor = false;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSchedule.FlatAppearance.BorderSize = 0;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(45, 434);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(213, 49);
            this.btnViewSchedule.TabIndex = 119;
            this.btnViewSchedule.Text = "VIEW SCHEDULE";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // ScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 506);
            this.Controls.Add(this.btnPrintSchedule);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxScheduleId);
            this.Controls.Add(this.labelIdFilm);
            this.Controls.Add(this.labelSched);
            this.Controls.Add(this.gridTicketManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleManagement";
            this.Text = "ScheduleManagement";
            this.Load += new System.EventHandler(this.ScheduleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTicketManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxScheduleId;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.DataGridView gridTicketManagement;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnUpdateSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnPrintSchedule;
        private System.Windows.Forms.Button btnViewSchedule;
    }
}