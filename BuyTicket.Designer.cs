
namespace TungMovie
{
    partial class BuyTicket
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
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdMovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeatKind = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxIdSeat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdTicket = new System.Windows.Forms.TextBox();
            this.boxPaymentType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_receiver = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateStartTime
            // 
            this.dateStartTime.CustomFormat = "dd/MM/yyyy";
            this.dateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartTime.Location = new System.Drawing.Point(155, 167);
            this.dateStartTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(102, 22);
            this.dateStartTime.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Start Time";
            // 
            // boxScheduleId
            // 
            this.boxScheduleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxScheduleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxScheduleId.FormattingEnabled = true;
            this.boxScheduleId.ItemHeight = 16;
            this.boxScheduleId.Location = new System.Drawing.Point(155, 121);
            this.boxScheduleId.Name = "boxScheduleId";
            this.boxScheduleId.Size = new System.Drawing.Size(102, 24);
            this.boxScheduleId.TabIndex = 106;
            this.boxScheduleId.SelectedIndexChanged += new System.EventHandler(this.boxScheduleId_SelectedIndexChanged);
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(33, 124);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(81, 16);
            this.labelIdFilm.TabIndex = 105;
            this.labelIdFilm.Text = "ID Schedule";
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSched.Location = new System.Drawing.Point(329, 24);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(94, 31);
            this.labelSched.TabIndex = 102;
            this.labelSched.Text = "Ticket";
            // 
            // dateEndTime
            // 
            this.dateEndTime.CustomFormat = "dd/MM/yyyy";
            this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndTime.Location = new System.Drawing.Point(155, 210);
            this.dateEndTime.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(102, 22);
            this.dateEndTime.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "End Time";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdRoom.Location = new System.Drawing.Point(155, 324);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.ReadOnly = true;
            this.txtIdRoom.Size = new System.Drawing.Size(102, 15);
            this.txtIdRoom.TabIndex = 115;
            this.txtIdRoom.TextChanged += new System.EventHandler(this.txtIdRoom_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 114;
            this.label7.Text = "ID Room";
            // 
            // txtIdMovie
            // 
            this.txtIdMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdMovie.Location = new System.Drawing.Point(155, 252);
            this.txtIdMovie.Name = "txtIdMovie";
            this.txtIdMovie.Size = new System.Drawing.Size(102, 15);
            this.txtIdMovie.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "ID Movie";
            // 
            // timeStart
            // 
            this.timeStart.CustomFormat = "HH:mm:ss";
            this.timeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(263, 167);
            this.timeStart.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(87, 22);
            this.timeStart.TabIndex = 116;
            // 
            // timeEnd
            // 
            this.timeEnd.CustomFormat = "HH:mm:ss";
            this.timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(263, 210);
            this.timeEnd.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(87, 22);
            this.timeEnd.TabIndex = 117;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBookTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTicket.FlatAppearance.BorderSize = 0;
            this.btnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTicket.ForeColor = System.Drawing.Color.White;
            this.btnBookTicket.Location = new System.Drawing.Point(250, 418);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(100, 40);
            this.btnBookTicket.TabIndex = 118;
            this.btnBookTicket.Text = "BOOK TICKET";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(432, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtMovieName.Location = new System.Drawing.Point(155, 288);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(195, 15);
            this.txtMovieName.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Movie Name";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(570, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 15);
            this.txtPrice.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 130;
            this.label5.Text = "ID Seat";
            // 
            // txtSeatKind
            // 
            this.txtSeatKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSeatKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeatKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtSeatKind.Location = new System.Drawing.Point(570, 172);
            this.txtSeatKind.Name = "txtSeatKind";
            this.txtSeatKind.Size = new System.Drawing.Size(102, 15);
            this.txtSeatKind.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 121;
            this.label10.Text = "Price";
            // 
            // boxIdSeat
            // 
            this.boxIdSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxIdSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxIdSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxIdSeat.FormattingEnabled = true;
            this.boxIdSeat.ItemHeight = 16;
            this.boxIdSeat.Location = new System.Drawing.Point(570, 126);
            this.boxIdSeat.Name = "boxIdSeat";
            this.boxIdSeat.Size = new System.Drawing.Size(102, 24);
            this.boxIdSeat.TabIndex = 135;
            this.boxIdSeat.SelectedIndexChanged += new System.EventHandler(this.boxIdSeat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 136;
            this.label6.Text = "Seat Kind";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 137;
            this.label8.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(570, 252);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(102, 15);
            this.txtUsername.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 140;
            this.label9.Text = "ID Ticket";
            // 
            // txtIdTicket
            // 
            this.txtIdTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdTicket.Location = new System.Drawing.Point(155, 362);
            this.txtIdTicket.Name = "txtIdTicket";
            this.txtIdTicket.Size = new System.Drawing.Size(55, 15);
            this.txtIdTicket.TabIndex = 139;
            // 
            // boxPaymentType
            // 
            this.boxPaymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "MoMo",
            "ZaloPay",
            "ViettelPay"});
            this.boxPaymentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxPaymentType.FormattingEnabled = true;
            this.boxPaymentType.ItemHeight = 16;
            this.boxPaymentType.Items.AddRange(new object[] {
            "MoMo",
            "ZaloPay",
            "ViettelPay"});
            this.boxPaymentType.Location = new System.Drawing.Point(570, 283);
            this.boxPaymentType.Name = "boxPaymentType";
            this.boxPaymentType.Size = new System.Drawing.Size(102, 24);
            this.boxPaymentType.TabIndex = 142;
            this.boxPaymentType.SelectedIndexChanged += new System.EventHandler(this.boxPaymentType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 141;
            this.label11.Text = "Payment type";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(570, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 15);
            this.textBox1.TabIndex = 143;
            this.textBox1.Text = "0921886123";
            // 
            // lb_receiver
            // 
            this.lb_receiver.AutoSize = true;
            this.lb_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_receiver.Location = new System.Drawing.Point(429, 325);
            this.lb_receiver.Name = "lb_receiver";
            this.lb_receiver.Size = new System.Drawing.Size(114, 16);
            this.lb_receiver.TabIndex = 144;
            this.lb_receiver.Text = "Receiver\'s Momo";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtUserNumber.Location = new System.Drawing.Point(570, 363);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(102, 15);
            this.txtUserNumber.TabIndex = 145;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(429, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "User\'s number";
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lb_receiver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boxPaymentType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdTicket);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxIdSeat);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSeatKind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
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
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxScheduleId;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeatKind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox boxIdSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdTicket;
        private System.Windows.Forms.ComboBox boxPaymentType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_receiver;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label label13;
    }
}