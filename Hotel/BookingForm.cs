using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Hotel.DataBase;

namespace Hotel
{
    public partial class BookingForm : Form
    {


        HotelDBContext context = new HotelDBContext();

        public int BookingID = 0;

        public int CheckInCencel = 0;
        public int CheckOutCencel = 0;

        public int UserID { get; set; }
        public BookingForm()
        {
            InitializeComponent();



        }

        private void BookingForm_Load(object sender, EventArgs e)
        {


            GetCustomerID();

            CheckOutdateTime.Value = DateTime.Today.AddDays(1);

            GetBooking();

            CheckTime();

            
            CheckIndateTime.MaxDate = DateTime.Now.AddYears(5);
            CheckIndateTime.MinDate = DateTime.Now;


            CheckOutdateTime.MaxDate = DateTime.Now.AddYears(5);
            CheckOutdateTime.MinDate = DateTime.Now;


        }


        private void CheckIndateTime_ValueChanged(object sender, EventArgs e)
        {
            if (CheckInCencel == 0)
            {
                CheckTime();
            }
            else if (CheckInCencel == 1)
            {
                CheckInCencel = 2;
            }
            else if (CheckInCencel == 2)
            {

                CheckInCencel = 0;
                CheckTime();
                BookingID = 0;

                GetCustomerID();

            }



        }


        private void CheckOutdateTime_ValueChanged(object sender, EventArgs e)
        {
            if (CheckOutCencel == 0)
            {
                CheckTime();
            }
            else if (CheckOutCencel == 1)
            {
                CheckOutCencel = 2;
            }
            else if (CheckOutCencel == 2)
            {

                CheckOutCencel = 0;
                CheckTime();
                BookingID = 0;

                GetCustomerID();

            }
        }



        private void Bookbutton_Click(object sender, EventArgs e)
        {


            if (CheckIndateTime.Value < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be before the current date.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckOutdateTime.Value <= CheckIndateTime.Value)
            {
                MessageBox.Show("Check-out date cannot be before the Ckeck-in date.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumberRoomcomboBox.SelectedItem == null)
            {
                MessageBox.Show("you must select number of room ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CustomerIDcomboBox.SelectedItem == null)
            {
                MessageBox.Show("you must select Customer ID ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkRoomAvailable())
            {
                MessageBox.Show("you must Update Data Input", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CheckTime();
            }
            else
            {
                Booking booking = new Booking()
                {
                    BookingID = 1,
                    CustomerSSN = CustomerIDcomboBox.SelectedItem.ToString(),
                    RoomID = int.Parse(NumberRoomcomboBox.SelectedItem.ToString()),
                    UserID = UserID,
                    BookingDate = DateTime.Today,
                    CheckInDate = CheckIndateTime.Value,
                    CheckOutDate = CheckOutdateTime.Value,
                    Duration = int.Parse(DaysNumberlabel.Text.Split(' ')[0]),
                    BookingCost = int.Parse(TotalCostlabel.Text.Split(' ')[1])
                };

                context.Bookings.Add(booking);
                context.SaveChanges();


                Report report = new Report(booking.CustomerSSN);
                report.ShowDialog();

                

                GetBooking();
                CheckTime();
                GetCustomerID();

            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if (BookingID != 0)
            {
                Booking booking = context.Bookings.Find(BookingID);
                if (booking == null)
                {
                    MessageBox.Show("you must select booking to cancel it", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    context.Bookings.Remove(booking);
                    context.SaveChanges();

                    GetBooking();

                    CheckTime();

                    GetCustomerID();

                }

            }
            else
            {
                MessageBox.Show("you must select booking to cancel it", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            BookingID = 0;

        }

        private void NumberRoomcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Duration = (CheckOutdateTime.Value.Date - CheckIndateTime.Value.Date).Days;
            DaysNumberlabel.Text = $"{Duration} Days";
            int RoomNum;
            if (int.TryParse(NumberRoomcomboBox.SelectedItem.ToString(), out RoomNum))
            {
                int TypeId = context.Rooms.Find(RoomNum).TypeID;
                double DailyCost = context.Types.Find(TypeId).DailyCost;

                double Amount = Duration * DailyCost;
                TotalCostlabel.Text = $"EGP {Amount}";
            }

        }



        private void BookingdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = BookingdataGridView.Rows[BookingdataGridView.SelectedCells[0].RowIndex];

                BookingID = int.Parse(row.Cells["BookNum"].Value.ToString());

                if (CheckIndateTime.Value == DateTime.Parse(row.Cells["CheckIn"].Value.ToString()))
                {
                    CheckInCencel = 2;
                }
                else
                {
                    CheckInCencel = 1;
                }

                if (CheckOutdateTime.Value == DateTime.Parse(row.Cells["CheckOut"].Value.ToString()))
                {
                    CheckOutCencel = 2;
                }
                else
                {
                    CheckOutCencel = 1;
                }

                CheckIndateTime.Value = DateTime.Parse(row.Cells["CheckIn"].Value.ToString());
                CheckOutdateTime.Value = DateTime.Parse(row.Cells["CheckOut"].Value.ToString());

                NumberRoomcomboBox.Items.Clear();
                NumberRoomcomboBox.Items.Add(row.Cells["Room"].Value.ToString());
                NumberRoomcomboBox.SelectedIndex = 0;

                CustomerIDcomboBox.Items.Clear();
                CustomerIDcomboBox.Items.Add(row.Cells["Customer"].Value.ToString());
                CustomerIDcomboBox.SelectedIndex = 0;

                DaysNumberlabel.Text = $"{row.Cells["Duration"].Value.ToString()} Days";
                TotalCostlabel.Text = $"EGP {row.Cells["Amount"].Value.ToString()}";


            }
        }


        private void BookingdataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BookingdataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void BookingdataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Revert the background color of the entire row
                BookingdataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 64, 64);
            }
        }



        public void GetCustomerID()
        {
            List<string> CustomersID = context.Customers.Select(c => c.SSN).ToList();
            CustomerIDcomboBox.Items.Clear();
            CustomerIDcomboBox.Items.AddRange(CustomersID.ToArray());
        }

        public void GetBooking()
        {

            BookingdataGridView.RowHeadersVisible = false;

            BookingdataGridView.Rows.Clear();

            var bookings = context.Bookings.Select(
                b => new
                {
                    b.BookingID,
                    b.RoomID,
                    b.CustomerSSN,
                    b.BookingDate,
                    b.CheckInDate,
                    b.CheckOutDate,
                    b.Duration,
                    b.BookingCost
                }).ToList();

            foreach (var b in bookings)
            {

                BookingdataGridView.Rows.Add(b.BookingID,
                b.RoomID,
                b.CustomerSSN,
                b.BookingDate.ToShortDateString(),
                b.CheckInDate.ToShortDateString(),
                b.CheckOutDate.ToShortDateString(),
                b.Duration,
                b.BookingCost);

            }
        }



        public List<string> GetAvailableRooms(DateTime InputCheckInDate, DateTime InputCheckOutDate)
        {
            var bookedRoomIds = context.Bookings
                .Where(b =>
                    (b.CheckInDate <= InputCheckOutDate && b.CheckOutDate >= InputCheckInDate) ||
                    (b.CheckOutDate >= InputCheckInDate && b.CheckInDate <= InputCheckOutDate))
                .Select(b => b.RoomID)
            .ToList();


            var availableRooms = context.Rooms
                .Where(r => !bookedRoomIds.Contains(r.RoomNum))
                .Select(r => r.RoomNum.ToString())
                .ToList();


            return availableRooms;

        }


        public void CheckTime()
        {
            if (CheckIndateTime.Value < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be before the current date.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumberRoomcomboBox.Items.Clear();
                DaysNumberlabel.Text = "";
                TotalCostlabel.Text = "";


            }
            else if (CheckOutdateTime.Value <= CheckIndateTime.Value)
            {
                MessageBox.Show("Check-out date cannot be before the Ckeck-in date.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumberRoomcomboBox.Items.Clear();
                DaysNumberlabel.Text = "";
                TotalCostlabel.Text = "";


            }
            else
            {
                NumberRoomcomboBox.Items.Clear();
                NumberRoomcomboBox.Items.AddRange(GetAvailableRooms(CheckIndateTime.Value, CheckOutdateTime.Value).ToArray());
                DaysNumberlabel.Text = "";
                TotalCostlabel.Text = "";

            }
        }


        public bool checkRoomAvailable()
        {
            if (GetAvailableRooms(CheckIndateTime.Value, CheckOutdateTime.Value)
                .Contains(NumberRoomcomboBox.SelectedItem.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
