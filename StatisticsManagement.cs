using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class StatisticsManagement : Form
    {
        Statistics sta = new Statistics();

        public StatisticsManagement()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            RevenueLoad();
            statisticschart.DataBindTable(sta.getStatisticsList().DefaultView, "movie");
            statisticschart.Series["statisticsid"].ChartType = SeriesChartType.Bar;
            statisticschart.Series["statisticsid"].Enabled = false;
            statisticschart.Series["revenue"].ChartType = SeriesChartType.Bar;
            statisticschart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            statisticschart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            statisticschart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            statisticschart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            statisticschart.ChartAreas[0].AxisY.Title = "(VND)";
        }

        private void RevenueLoad()
        {
            int total = Convert.ToInt32(sta.getStatisticsTotalId().Rows[0][0].ToString());

            for (int i = 1; i <= total; i++)
            {
                int totalrevenue;
                if (sta.getTotalRevenueByMovieId(i).Rows[0][0].ToString().Equals(""))
                {
                    totalrevenue = 0;
                }
                else
                {
                    totalrevenue = Convert.ToInt32(sta.getTotalRevenueByMovieId(i).Rows[0][0].ToString());
                }
                sta.updateTotalRevenueByMovieId(i, totalrevenue);
            }
            //
            statisticschart.DataSource = sta.getStatisticsList();
            //
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            statisticschart.DataSource = sta.getStatisticsList();
        }
    }
}
