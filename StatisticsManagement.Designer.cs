
namespace TungMovie
{
    partial class StatisticsManagement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.statisticschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new TungMovie.RButton();
            this.btnCancel = new TungMovie.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.statisticschart)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticschart
            // 
            this.statisticschart.BackColor = System.Drawing.SystemColors.Control;
            this.statisticschart.BorderlineColor = System.Drawing.SystemColors.Control;
            this.statisticschart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.statisticschart.BorderSkin.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "Revenue";
            this.statisticschart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.DockedToChartArea = "Revenue";
            legend1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.HeaderSeparatorColor = System.Drawing.Color.DarkRed;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.statisticschart.Legends.Add(legend1);
            this.statisticschart.Location = new System.Drawing.Point(12, 12);
            this.statisticschart.Name = "statisticschart";
            this.statisticschart.Size = new System.Drawing.Size(874, 391);
            this.statisticschart.TabIndex = 0;
            this.statisticschart.Text = "chart1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(312, 432);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(499, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // StatisticsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statisticschart);
            this.Name = "StatisticsManagement";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticschart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statisticschart;
        private RButton btnRefresh;
        private RButton btnCancel;
    }
}