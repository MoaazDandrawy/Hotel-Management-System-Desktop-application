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
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hotel
{
    public partial class ManageRooms : Form
    {
        HotelDBContext db = new HotelDBContext();

        public ManageRooms()
        {
            InitializeComponent();
            populate();
        }


        private void populate()
        {
            roomsDataGridView.Rows.Clear();
            roomsDataGridView.RowHeadersVisible = false;
            var context = db.Rooms.Select(
            b => new
            {
                b.RoomNum,
                b.Type.Name,
                b.Status
            }).ToList();

            foreach (var b in context)
            {

                roomsDataGridView.Rows.Add(
                    b.RoomNum,
                    b.Name,
                    b.Status);
            }
        }

        private void EditRooms()
        {
            if (roomNumberTextBox.Text == "" || roomTypeComboBox.SelectedIndex == -1 || statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wrong Input!");
            }
            else
            {
                try
                {
                    // Parse room type index to integer
                    if (!int.TryParse(roomTypeComboBox.SelectedIndex.ToString(), out int roomTypeIndex))
                    {
                        MessageBox.Show("Invalid room type index.");
                        return;
                    }

                    int roomNumber = Convert.ToInt32(roomNumberTextBox.Text);
                    var roomToUpdate = db.Rooms.FirstOrDefault(r => r.RoomNum == roomNumber);

                    if (roomToUpdate != null)
                    {
                        // Update the room properties
                        roomToUpdate.RoomNum = roomNumber;
                        roomToUpdate.TypeID = db.Types.Where(s => s.Name == roomTypeComboBox.Text).FirstOrDefault().TypeID;

                        roomToUpdate.Status = statusComboBox.SelectedItem.ToString();

                        db.SaveChanges();

                        MessageBox.Show("Room Edited successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Room with number {roomNumber} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                populate();
            }
        }

        private void DeleteRooms()
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelDBContext())
                    {
                        int roomNumber = Convert.ToInt32(roomNumberTextBox.Text);
                        var roomToDelete = context.Rooms.FirstOrDefault(r => r.RoomNum == roomNumber);

                        if (roomToDelete != null)
                        {
                            context.Rooms.Remove(roomToDelete);
                            context.SaveChanges();
                            MessageBox.Show("Room Deleted!");
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Room not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void InsertRooms()
        {
            if (string.IsNullOrEmpty(roomNumberTextBox.Text) || roomTypeComboBox.SelectedIndex == -1 || statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wrong Input!");
            }
            else
            {
                try
                {
                    // Parse room number and type ID from the text boxes
                    int roomNumber;
                    int roomTypeID;
                    string roomStatus = statusComboBox.SelectedItem.ToString();

                    if (!int.TryParse(roomNumberTextBox.Text, out roomNumber) || !int.TryParse(roomTypeComboBox.SelectedIndex.ToString(), out roomTypeID))
                    {
                        MessageBox.Show("Invalid room number or room type.");
                        return;
                    }

                    Room newRoom = new Room
                    {
                        RoomNum = roomNumber,
                        TypeID = db.Types.Where(s => s.Name == roomTypeComboBox.Text).FirstOrDefault().TypeID,
                        Status = roomStatus
                        //Status = "Available"
                    };

                    db.Rooms.Add(newRoom);
                    db.SaveChanges();

                    MessageBox.Show("Room inserted successfully.");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveRoomsButton_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            roomTypeComboBox.Items.AddRange(db.Types.Select(r => r.Name).ToArray());

            // Set default cell style
            roomsDataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            roomsDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            roomsDataGridView.DefaultCellStyle.Font = new Font("Arial", 10);

            // Set header cell style
            roomsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            roomsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            roomsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Set row header style
            roomsDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            roomsDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            roomsDataGridView.RowHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

        }
        int Key = 0;
        private void roomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = roomsDataGridView.Rows[roomsDataGridView.SelectedCells[0].RowIndex];
                roomNumberTextBox.Text = row.Cells[0].Value.ToString();
                roomTypeComboBox.Text = row.Cells[1].Value.ToString();
                statusComboBox.Text = row.Cells[2].Value.ToString();
            }

        }

        private void editRoomsButton_Click(object sender, EventArgs e)
        {
            EditRooms();
        }

        private void roomNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void deleteRoomsButton_Click(object sender, EventArgs e)
        {
            DeleteRooms();
        }

        private void roomsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                roomsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void roomsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                roomsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 64, 64);
            }
        }

        
    }
}

