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
    public partial class SeatManagement : Form
    {

        Seat se = new Seat();
        public SeatManagement()
        {
            InitializeComponent();
        }

        public void boxStatus_load()
        {
            boxStatus.Items.Add("True");
            boxStatus.Items.Add("False");
            boxStatus.SelectedIndex = -1;
        }

        public void seat_id_box_Load()
        {
            boxSeatId.DataSource = se.getSeatList();
            boxSeatId.ValueMember = "seatid";
            boxSeatId.DisplayMember = "seatid";
            boxSeatId.SelectedIndex = -1;
        }

        private void SeatManagement_Load(object sender, EventArgs e)
        {
            LoadSeatGrid();
            seat_id_box_Load();
            boxStatus_load();
        }

        private void boxSeatId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sid = Convert.ToInt32(boxSeatId.SelectedValue);
                DataTable dt = new DataTable();
                dt = se.getSeatById(sid);
                txtCode.Text = dt.Rows[0][0].ToString();
                txtKind.Text = dt.Rows[0][1].ToString();
                boxStatus.Text = dt.Rows[0][2].ToString();
                txtIdRoom.Text = dt.Rows[0][3].ToString();
            }
            catch
            {
                txtCode.Text = "";
                txtIdRoom.Text = "";
                boxStatus.SelectedIndex = -1;
                txtIdRoom.Text = "";
            }
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {

        }


        bool verif()
        {
            if ((txtCode.Text.Trim() == "")
                || (txtIdRoom.Text.Trim() == "")
                || (txtKind.Text.Trim() == "")
                || (boxStatus.SelectedIndex == -1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LoadSeatGrid()
        {
            this.Size = new Size(300, 395);
            gridSeatManagement.RowTemplate.Height = 30;
            gridSeatManagement.Visible = false;
            gridSeatManagement.DataSource = se.getSeatList();
        }

        private void refresh()
        {
            gridSeatManagement.DataSource = se.getSeatList();
        }

        private void btnViewSeat_Click(object sender, EventArgs e)
        {
            refresh();
            if (!(gridSeatManagement.Visible))
            {
                this.Size = new Size(760, 395);
                gridSeatManagement.Visible = true;
            }
            else
            {
                this.Size = new Size(300, 395);
                gridSeatManagement.Visible = false;
            }
        }

        private void btnUpdateSeat_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Int32.Parse(boxSeatId.SelectedValue.ToString());
                int code = Int32.Parse(txtCode.Text.ToString());
                string kind = txtKind.Text.ToString();
                string status = boxStatus.SelectedItem.ToString();
                int seat_id = Int32.Parse(boxSeatId.SelectedValue.ToString());
                if (se.updateSeat(id, code, kind, status, seat_id))
                {
                    MessageBox.Show("Update Seat Successful", "Seat", MessageBoxButtons.OK);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error", "Seat", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Blank is not allowed", "Seat", MessageBoxButtons.OK);
            }
        }
    }
}
