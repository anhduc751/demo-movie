
namespace TungMovie
{
    partial class SeatManagement
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
            this.btnUpdateSeat = new System.Windows.Forms.Button();
            this.btnViewSeat = new System.Windows.Forms.Button();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSeatId = new System.Windows.Forms.ComboBox();
            this.labelIdSeat = new System.Windows.Forms.Label();
            this.labelSeatManagement = new System.Windows.Forms.Label();
            this.gridSeatManagement = new System.Windows.Forms.DataGridView();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeatManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateSeat
            // 
            this.btnUpdateSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSeat.FlatAppearance.BorderSize = 0;
            this.btnUpdateSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSeat.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSeat.Location = new System.Drawing.Point(18, 298);
            this.btnUpdateSeat.Name = "btnUpdateSeat";
            this.btnUpdateSeat.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateSeat.TabIndex = 135;
            this.btnUpdateSeat.Text = "UPDATE SEAT";
            this.btnUpdateSeat.UseVisualStyleBackColor = false;
            this.btnUpdateSeat.Click += new System.EventHandler(this.btnUpdateSeat_Click);
            // 
            // btnViewSeat
            // 
            this.btnViewSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSeat.FlatAppearance.BorderSize = 0;
            this.btnViewSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSeat.ForeColor = System.Drawing.Color.White;
            this.btnViewSeat.Location = new System.Drawing.Point(156, 298);
            this.btnViewSeat.Name = "btnViewSeat";
            this.btnViewSeat.Size = new System.Drawing.Size(100, 40);
            this.btnViewSeat.TabIndex = 134;
            this.btnViewSeat.Text = "VIEW SEAT";
            this.btnViewSeat.UseVisualStyleBackColor = false;
            this.btnViewSeat.Click += new System.EventHandler(this.btnViewSeat_Click);
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIdRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtIdRoom.Location = new System.Drawing.Point(156, 241);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(70, 15);
            this.txtIdRoom.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 131;
            this.label7.Text = "ID Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 127;
            this.label3.Text = "Kind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 125;
            this.label2.Text = "Code";
            // 
            // boxSeatId
            // 
            this.boxSeatId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxSeatId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxSeatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxSeatId.FormattingEnabled = true;
            this.boxSeatId.ItemHeight = 16;
            this.boxSeatId.Location = new System.Drawing.Point(156, 81);
            this.boxSeatId.Name = "boxSeatId";
            this.boxSeatId.Size = new System.Drawing.Size(70, 24);
            this.boxSeatId.TabIndex = 124;
            this.boxSeatId.SelectedIndexChanged += new System.EventHandler(this.boxSeatId_SelectedIndexChanged);
            // 
            // labelIdSeat
            // 
            this.labelIdSeat.AutoSize = true;
            this.labelIdSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdSeat.Location = new System.Drawing.Point(15, 81);
            this.labelIdSeat.Name = "labelIdSeat";
            this.labelIdSeat.Size = new System.Drawing.Size(52, 16);
            this.labelIdSeat.TabIndex = 123;
            this.labelIdSeat.Text = "ID Seat";
            // 
            // labelSeatManagement
            // 
            this.labelSeatManagement.AutoSize = true;
            this.labelSeatManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSeatManagement.Location = new System.Drawing.Point(12, 23);
            this.labelSeatManagement.Name = "labelSeatManagement";
            this.labelSeatManagement.Size = new System.Drawing.Size(249, 31);
            this.labelSeatManagement.TabIndex = 122;
            this.labelSeatManagement.Text = "Seat Management";
            // 
            // gridSeatManagement
            // 
            this.gridSeatManagement.AllowUserToAddRows = false;
            this.gridSeatManagement.AllowUserToDeleteRows = false;
            this.gridSeatManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSeatManagement.BackgroundColor = System.Drawing.Color.White;
            this.gridSeatManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSeatManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeatManagement.Location = new System.Drawing.Point(288, 23);
            this.gridSeatManagement.Name = "gridSeatManagement";
            this.gridSeatManagement.ReadOnly = true;
            this.gridSeatManagement.RowHeadersVisible = false;
            this.gridSeatManagement.Size = new System.Drawing.Size(433, 315);
            this.gridSeatManagement.TabIndex = 121;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtCode.Location = new System.Drawing.Point(156, 125);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 15);
            this.txtCode.TabIndex = 138;
            // 
            // txtKind
            // 
            this.txtKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtKind.Location = new System.Drawing.Point(156, 163);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(100, 15);
            this.txtKind.TabIndex = 139;
            // 
            // boxStatus
            // 
            this.boxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.ItemHeight = 16;
            this.boxStatus.Location = new System.Drawing.Point(156, 198);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(70, 24);
            this.boxStatus.TabIndex = 140;
            // 
            // SeatManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 356);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.txtKind);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnUpdateSeat);
            this.Controls.Add(this.btnViewSeat);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSeatId);
            this.Controls.Add(this.labelIdSeat);
            this.Controls.Add(this.labelSeatManagement);
            this.Controls.Add(this.gridSeatManagement);
            this.Name = "SeatManagement";
            this.Text = "SeatManagement";
            this.Load += new System.EventHandler(this.SeatManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeatManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateSeat;
        private System.Windows.Forms.Button btnViewSeat;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxSeatId;
        private System.Windows.Forms.Label labelIdSeat;
        private System.Windows.Forms.Label labelSeatManagement;
        private System.Windows.Forms.DataGridView gridSeatManagement;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.ComboBox boxStatus;
    }
}