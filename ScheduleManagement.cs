using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class ScheduleManagement : Form
    {
        Schedule sc = new Schedule();
        public ScheduleManagement()
        {
            InitializeComponent();
        }
        public void schedule_id_box_Load()
        {
            boxScheduleId.DataSource = sc.getScheduleList();
            boxScheduleId.ValueMember = "scheduleid";
            boxScheduleId.DisplayMember = "scheduleid";
            boxScheduleId.SelectedIndex = -1;
        }
        public void LoadScheduleGrid()
        {
            this.Size = new Size(405, 445);
            gridTicketManagement.RowTemplate.Height = 30;
            gridTicketManagement.Visible = false;
            gridTicketManagement.DataSource = sc.getScheduleList();
            gridTicketManagement.Columns[2].Width = 110;
        }

        private void ScheduleManagement_Load(object sender, EventArgs e)
        {
            schedule_id_box_Load();
            LoadScheduleGrid();
        }
        private void refresh()
        {
            gridTicketManagement.DataSource = sc.getScheduleList();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(boxScheduleId.SelectedValue.ToString());
            DateTime start = dateStartTime.Value.Date;
            DateTime end = dateEndTime.Value.Date;
            int movieid = Int32.Parse(txtIdMovie.Text.ToString());
            int roomid = Int32.Parse(txtIdRoom.Text.ToString());
            if (sc.addSchedule(id, start, end, movieid, roomid))
            {
                MessageBox.Show("Add Schedule Successful", "Schedule", MessageBoxButtons.OK);
                refresh();
            }
            else
            {
                MessageBox.Show("Error", "Schedule", MessageBoxButtons.OK);
            }

        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            refresh();
            if (!(gridTicketManagement.Visible))
            {
                this.Size = new Size(1070, 445);
                gridTicketManagement.Visible = true;
            }
            else
            {
                this.Size = new Size(405, 445);
                gridTicketManagement.Visible = false;
            }
        }
        bool verif()
        {
            if ((txtIdMovie.Text.Trim() == "")
                || (txtIdRoom.Text.Trim() == "")
                || (boxScheduleId.SelectedIndex == -1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Int32.Parse(boxScheduleId.SelectedValue.ToString());
                DateTime start = dateStartTime.Value.Date;
                DateTime end = dateEndTime.Value.Date;
                int movieid = Int32.Parse(txtIdMovie.Text.ToString());
                int roomid = Int32.Parse(txtIdRoom.Text.ToString());
                if (sc.addSchedule(id, start, end, movieid, roomid))
                {
                    MessageBox.Show("Update Schedule Successful", "Schedule", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Schedule", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Blank is not allowed", "Schedule", MessageBoxButtons.OK);
            }
        }

        private void boxScheduleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string datetime1;
                string datetime2;
                int id = Convert.ToInt32(boxScheduleId.SelectedValue);
                DataTable dt = new DataTable();
                dt = sc.getScheduleById(id);
                if (dt.Rows[0][1].ToString().Equals("") || dt.Rows[0][2].ToString().Equals(""))
                {
                    datetime1 = ("01-01-2022 00:00:00");
                    datetime2 = ("01-01-2022 00:00:00");
                }
                else
                {
                    datetime1 = dt.Rows[0][1].ToString();
                    datetime2 = dt.Rows[0][2].ToString();
                }
                dateStartTime.Value = DateTime.Parse(datetime1);
                dateEndTime.Value = DateTime.Parse(datetime2);
                txtIdMovie.Text = dt.Rows[0][3].ToString();
                txtIdRoom.Text = dt.Rows[0][4].ToString();
            }
            catch
            {
                dateStartTime.Value = DateTime.Now;
                dateEndTime.Value = DateTime.Now;
                txtIdMovie.Text = "";
                txtIdRoom.Text = "";
            }
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(boxScheduleId.SelectedValue);
            if (sc.deleteSchedule(id))
            {
                refresh();
                MessageBox.Show("Delete Schedule Successful", "Schedule", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Schedule", MessageBoxButtons.OK);
            }
            
        }
    }
}
