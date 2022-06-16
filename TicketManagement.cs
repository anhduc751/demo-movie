using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class TicketManagement : Form
    {
        Ticket ti = new Ticket();

        public TicketManagement()
        {
            InitializeComponent();
        }

        public void ticket_id_box_Load()
        {
            boxTicketId.DataSource = ti.getTicketList();
            boxTicketId.ValueMember = "ticketid";
            boxTicketId.DisplayMember = "ticketid";
            boxTicketId.SelectedIndex = -1;
        }

        public void username_box_Load()
        {
            boxUsername.DataSource = ti.getUsernameList();
            boxUsername.ValueMember = "username";
            boxUsername.DisplayMember = "username";
            boxUsername.SelectedIndex = -1;
        }

        public void schedule_id_box_Load()
        {
            boxIdSchedule.DataSource = ti.getScheduleList();
            boxIdSchedule.ValueMember = "scheduleid";
            boxIdSchedule.DisplayMember = "scheduleid";
            boxIdSchedule.SelectedIndex = -1;
        }

        public void seat_id_box_Load()
        {
            boxIdSeat.DataSource = ti.getSeatList();
            boxIdSeat.ValueMember = "seatid";
            boxIdSeat.DisplayMember = "seatid";
            boxIdSeat.SelectedIndex = -1;
        }

        public void LoadTicketGrid()
        {
            this.Size = new Size(405, 445);
            gridTicketManagement.RowTemplate.Height = 30;
            gridTicketManagement.Visible = false;
            gridTicketManagement.DataSource = ti.getTicketList();
            gridTicketManagement.Columns[2].Width = 110;
        }

        private void TicketManagement_Load(object sender, EventArgs e)
        {
            LoadTicketGrid();
            ticket_id_box_Load();
            username_box_Load();
            seat_id_box_Load();
            schedule_id_box_Load();
        }

        private void boxTicketId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string datetime;
                int tid = Convert.ToInt32(boxTicketId.SelectedValue);
                DataTable dt = new DataTable();
                dt = ti.getTicketById(tid);
                txtPrice.Text = dt.Rows[0][0].ToString();
                if(dt.Rows[0][1].ToString().Equals(""))
                {
                    datetime = ("01-01-2022 00:00:00");

                }
                else
                {
                    datetime = dt.Rows[0][1].ToString();
                }
                dateBookingDate.Value = DateTime.Parse(datetime);
                timeBookingDate.Value = DateTime.Parse(datetime);
                boxIdSchedule.Text = dt.Rows[0][2].ToString();
                boxUsername.Text = dt.Rows[0][3].ToString();
                boxIdSeat.Text = dt.Rows[0][4].ToString();
                txtIdRoom.Text = dt.Rows[0][5].ToString();
            }
            catch
            {
                txtPrice.Text = "";
                dateBookingDate.Value = DateTime.Now;
                boxIdSchedule.SelectedIndex = -1;
                boxUsername.SelectedIndex = -1;
                boxIdSeat.SelectedIndex = -1;
                txtIdRoom.Text = "";
            }
        }

        private void refresh()
        {
            gridTicketManagement.DataSource = ti.getTicketList();
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
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

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(txtPrice.Text);
            if (txtPrice.Text.Trim() != null)
            {
                boxTicketId.SelectedIndex = -1;
                dateBookingDate.Value = DateTime.Now;
                boxIdSchedule.SelectedIndex = -1;
                boxUsername.SelectedIndex = -1;
                boxIdSeat.SelectedIndex = -1;
                txtIdRoom.Text = "";
                if (ti.addTicket(price))
                {
                    MessageBox.Show("Add Ticket Successful", "Ticket", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Ticket", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please add ticket's price", "Ticket", MessageBoxButtons.OK);
            }
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if(verif())
            {
                int id = Int32.Parse(boxTicketId.SelectedValue.ToString());
                int price = Int32.Parse(txtPrice.Text.ToString());
                DateTime bookingdate = dateBookingDate.Value.Date;
                int scheduleid = Int32.Parse(boxIdSchedule.SelectedValue.ToString());
                string username = boxUsername.SelectedValue.ToString();
                int seatid = Int32.Parse(boxIdSeat.SelectedValue.ToString());
                int roomid = Int32.Parse(txtIdRoom.Text.ToString());
                if (ti.updateTicket(id,price,bookingdate,scheduleid,username,seatid, roomid))
                {
                    MessageBox.Show("UPdate Ticket Successful", "Ticket", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Ticket", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Blank is not allowed", "Ticket", MessageBoxButtons.OK);
            }
        }

        bool verif()
        {
            if ((txtPrice.Text.Trim() == "")
                || (boxIdSeat.SelectedIndex == -1)
                || (boxIdSchedule.SelectedIndex == -1)
                || (boxUsername.SelectedIndex == -1)
                || (txtIdRoom.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
