
namespace TungMovie
{
	partial class ListSuccessedTicket
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
            this.label11 = new System.Windows.Forms.Label();
            this.gridBookedTicket = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(282, 21);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(200, 31);
            this.labelRegister.TabIndex = 26;
            this.labelRegister.Text = "Booked Ticket";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label11.Location = new System.Drawing.Point(54, -48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 31);
            this.label11.TabIndex = 50;
            this.label11.Text = "Edit Account";
            // 
            // gridBookedTicket
            // 
            this.gridBookedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookedTicket.Location = new System.Drawing.Point(12, 66);
            this.gridBookedTicket.Name = "gridBookedTicket";
            this.gridBookedTicket.Size = new System.Drawing.Size(736, 377);
            this.gridBookedTicket.TabIndex = 49;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(341, 462);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 41);
            this.btnPrint.TabIndex = 134;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // ListSuccessedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 515);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gridBookedTicket);
            this.Controls.Add(this.labelRegister);
            this.Name = "ListSuccessedTicket";
            this.Text = "ListSuccessedTicket.cs";
            this.Load += new System.EventHandler(this.ListSuccessedTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookedTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelRegister;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridView gridBookedTicket;
        private System.Windows.Forms.Button btnPrint;
    }
}