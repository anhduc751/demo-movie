
namespace TungMovie
{
	partial class ListMV
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.gridListMV = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListMV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 54);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(392, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "default",
            "find by id",
            "find by name"});
            this.comboBox1.Location = new System.Drawing.Point(410, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(6, 9);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(91, 31);
            this.labelRegister.TabIndex = 25;
            this.labelRegister.Text = "Movie";
            // 
            // gridListMV
            // 
            this.gridListMV.AllowUserToAddRows = false;
            this.gridListMV.AllowUserToDeleteRows = false;
            this.gridListMV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListMV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridListMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListMV.Location = new System.Drawing.Point(12, 97);
            this.gridListMV.Name = "gridListMV";
            this.gridListMV.ReadOnly = true;
            this.gridListMV.RowHeadersVisible = false;
            this.gridListMV.RowHeadersWidth = 51;
            this.gridListMV.Size = new System.Drawing.Size(810, 402);
            this.gridListMV.TabIndex = 0;
            this.gridListMV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListMV_CellContentClick);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(699, 54);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(123, 22);
            this.btnDetail.TabIndex = 137;
            this.btnDetail.Text = "Choose Schedule";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ListMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridListMV);
            this.Name = "ListMV";
            this.Text = "ListMV";
            this.Load += new System.EventHandler(this.ListMV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListMV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.DataGridView gridListMV;
        private System.Windows.Forms.Button btnDetail;
    }
}