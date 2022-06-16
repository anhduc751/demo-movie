using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TungMovie
{
    public partial class AdminManagement : Form
    {

        public AdminManagement()
        {
            InitializeComponent();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            new EditInfo().Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
        }

        private void btnScheduleManagement_Click(object sender, EventArgs e)
        {
            new ScheduleManagement().Show();
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            new RoomManagement().Show();
        }

        private void btnTicketManagement_Click(object sender, EventArgs e)
        {
            new TicketManagement().Show();
        }

        private void btnFilmManagement_Click(object sender, EventArgs e)
        {
            new Film_management().Show();
        }

        private void btnSeatManagement_Click(object sender, EventArgs e)
        {
            new SeatManagement().Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new StatisticsManagement().Show();
        }
    }
}
