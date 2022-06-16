
namespace TungMovie
{
    partial class Film_management
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
            this.gridFilmManagement = new System.Windows.Forms.DataGridView();
            this.labelFilmManagement = new System.Windows.Forms.Label();
            this.textRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.labelIdFilm = new System.Windows.Forms.Label();
            this.textFilmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFilmId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Schedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.moviepic = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviepic)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFilmManagement
            // 
            this.gridFilmManagement.AllowUserToAddRows = false;
            this.gridFilmManagement.AllowUserToDeleteRows = false;
            this.gridFilmManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFilmManagement.BackgroundColor = System.Drawing.Color.White;
            this.gridFilmManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFilmManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilmManagement.Location = new System.Drawing.Point(375, 24);
            this.gridFilmManagement.Name = "gridFilmManagement";
            this.gridFilmManagement.ReadOnly = true;
            this.gridFilmManagement.RowHeadersVisible = false;
            this.gridFilmManagement.RowHeadersWidth = 51;
            this.gridFilmManagement.Size = new System.Drawing.Size(696, 609);
            this.gridFilmManagement.TabIndex = 1;
            this.gridFilmManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFilmManagement_CellContentClick);
            // 
            // labelFilmManagement
            // 
            this.labelFilmManagement.AutoSize = true;
            this.labelFilmManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelFilmManagement.Location = new System.Drawing.Point(12, 24);
            this.labelFilmManagement.Name = "labelFilmManagement";
            this.labelFilmManagement.Size = new System.Drawing.Size(244, 31);
            this.labelFilmManagement.TabIndex = 20;
            this.labelFilmManagement.Text = "Film Management";
            // 
            // textRating
            // 
            this.textRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textRating.Location = new System.Drawing.Point(121, 158);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(109, 15);
            this.textRating.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rating";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(121, 232);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 60);
            this.txtDescription.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtGenre.Location = new System.Drawing.Point(121, 194);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(109, 15);
            this.txtGenre.TabIndex = 62;
            // 
            // labelIdFilm
            // 
            this.labelIdFilm.AutoSize = true;
            this.labelIdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFilm.Location = new System.Drawing.Point(19, 88);
            this.labelIdFilm.Name = "labelIdFilm";
            this.labelIdFilm.Size = new System.Drawing.Size(49, 16);
            this.labelIdFilm.TabIndex = 61;
            this.labelIdFilm.Text = "ID Film";
            // 
            // textFilmName
            // 
            this.textFilmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textFilmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textFilmName.Location = new System.Drawing.Point(121, 126);
            this.textFilmName.Multiline = true;
            this.textFilmName.Name = "textFilmName";
            this.textFilmName.Size = new System.Drawing.Size(189, 15);
            this.textFilmName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name";
            // 
            // boxFilmId
            // 
            this.boxFilmId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.boxFilmId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxFilmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.boxFilmId.FormattingEnabled = true;
            this.boxFilmId.ItemHeight = 16;
            this.boxFilmId.Items.AddRange(new object[] {
            "find by id",
            "find by name"});
            this.boxFilmId.Location = new System.Drawing.Point(121, 88);
            this.boxFilmId.Name = "boxFilmId";
            this.boxFilmId.Size = new System.Drawing.Size(109, 24);
            this.boxFilmId.TabIndex = 67;
            this.boxFilmId.SelectedIndexChanged += new System.EventHandler(this.boxFilmId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Description";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtDuration.Location = new System.Drawing.Point(121, 312);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(109, 15);
            this.txtDuration.TabIndex = 76;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(18, 540);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 82;
            this.btn_add.Text = "ADD FILM";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(244, 599);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 40);
            this.btn_delete.TabIndex = 83;
            this.btn_delete.Text = "DELETE FILM";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(130, 540);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 84;
            this.btn_update.Text = "UPDATE FILM";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Schedule
            // 
            this.btn_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Schedule.FlatAppearance.BorderSize = 0;
            this.btn_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Schedule.ForeColor = System.Drawing.Color.White;
            this.btn_Schedule.Location = new System.Drawing.Point(18, 599);
            this.btn_Schedule.Name = "btn_Schedule";
            this.btn_Schedule.Size = new System.Drawing.Size(212, 40);
            this.btn_Schedule.TabIndex = 85;
            this.btn_Schedule.Text = "SCHEDULE MANAGEMENT";
            this.btn_Schedule.UseVisualStyleBackColor = false;
            this.btn_Schedule.Click += new System.EventHandler(this.btn_Schedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Image";
            // 
            // moviepic
            // 
            this.moviepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviepic.Location = new System.Drawing.Point(121, 346);
            this.moviepic.Name = "moviepic";
            this.moviepic.Size = new System.Drawing.Size(189, 160);
            this.moviepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviepic.TabIndex = 87;
            this.moviepic.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(235, 507);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 88;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Film_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 651);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.moviepic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Schedule);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxFilmId);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.labelIdFilm);
            this.Controls.Add(this.textFilmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilmManagement);
            this.Controls.Add(this.gridFilmManagement);
            this.Name = "Film_management";
            this.Text = "Film_management";
            this.Load += new System.EventHandler(this.Film_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFilmManagement;
        private System.Windows.Forms.Label labelFilmManagement;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label labelIdFilm;
        private System.Windows.Forms.TextBox textFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxFilmId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Schedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox moviepic;
        private System.Windows.Forms.Button btnUpload;
    }
}