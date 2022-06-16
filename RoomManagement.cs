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
    public partial class RoomManagement : Form
    {
        Room room = new Room();
        public RoomManagement()
        {
            InitializeComponent();
            gridRoomManagement.Visible = false;
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            gridRoomManagement.DataSource = room.getroomlist();
        }

        private void gridTicketManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridRoomManagement.CurrentCell.Selected = true;
            boxRoomID.Text = gridRoomManagement.Rows[e.RowIndex].Cells["roomid"].Value.ToString();
            txtName.Text = gridRoomManagement.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtSeatsAmount.Text = gridRoomManagement.Rows[e.RowIndex].Cells["mun_of_seats"].Value.ToString();
        }

        private void btnViewRoomMgt_Click(object sender, EventArgs e)
        {
            gridRoomManagement.Visible = true;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            int seat = Int32.Parse(txtSeatsAmount.Text.ToString());
            
            
            if (room.AddRoom(name, seat))
            {
                gridRoomManagement.DataSource = room.getroomlist();
                MessageBox.Show("Success!", "ADD ROOM");
            }
            else
            {
                MessageBox.Show("Error!", "ADD ROOM");
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int r = gridRoomManagement.CurrentCell.RowIndex;
            int id = Int32.Parse(gridRoomManagement.Rows[r].Cells[0].Value.ToString());
            if (room.DeleteRoom(id))
            {
                gridRoomManagement.DataSource = room.getroomlist();
                MessageBox.Show("Success!", "DELETE ROOM");
            }
            else
            {
                MessageBox.Show("Error!", "DELETE ROOM");
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            
            int roomid = Int32.Parse(boxRoomID.Text.ToString());
            string name = txtName.Text.ToString();
            int seat = Int32.Parse(txtSeatsAmount.Text.ToString());
            

            if (room.UpdateRoom(roomid, name, seat))
            {
                gridRoomManagement.DataSource = room.getroomlist();
                MessageBox.Show("Success!", "UPDATE ROOM");
            }
            else
            {
                MessageBox.Show("Error!", "UPDATE ROOM");
            }
        }

        private void gridRoomManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gridRoomManagement.CurrentCell.RowIndex;
            boxRoomID.Text = gridRoomManagement.Rows[r].Cells[0].Value.ToString();
            txtName.Text = gridRoomManagement.Rows[r].Cells[1].Value.ToString();
            txtSeatsAmount.Text = gridRoomManagement.Rows[r].Cells[2].Value.ToString();
        }
    }
    
}
