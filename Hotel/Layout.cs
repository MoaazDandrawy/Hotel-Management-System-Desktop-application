using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Layout : Form
    {

        HotelDBContext db = new HotelDBContext();

        public int UserID { get; set; }


        public Layout()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            Inputpanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            Inputpanel.Controls.Add(f);
            f.Show();

        }


        


        private void Layout_Load(object sender, EventArgs e)
        {

            List<Room> Rooms = db.Rooms.Where(r => r.Status == "Booked").ToList();

            foreach (var R in Rooms)
            {
                R.Status = "Available";
            }

            List<Room> bookedRooms = db.Bookings
                .Where(b =>
                    (b.CheckInDate <= DateTime.Now && b.CheckOutDate >= DateTime.Now))
                .Select(b => b.Room)
                .ToList();




            foreach (var R in bookedRooms)
            {
                R.Status = "Booked";
            }

            db.SaveChanges();


            ChangeBackgroud(Roomsbutton);
            ManageRooms manageRooms = new ManageRooms();
            AddControls(manageRooms);

        }

        private void ChangeBackgroud(Button button)
        {
            Usersbutton.BackColor = Color.White;
            Roomsbutton.BackColor = Color.White;
            Categoriesbutton.BackColor = Color.White;
            Customersbutton.BackColor = Color.White;
            Bookingsbutton.BackColor = Color.White;
            Usersbutton.ForeColor = Color.Black;
            Roomsbutton.ForeColor = Color.Black;
            Categoriesbutton.ForeColor = Color.Black;
            Customersbutton.ForeColor = Color.Black;
            Bookingsbutton.ForeColor = Color.Black;

            button.BackColor = Color.FromArgb(0, 64, 64);
            button.ForeColor = Color.White;

        }

        private void Usersbutton_Click(object sender, EventArgs e)
        {

            ChangeBackgroud(Usersbutton);

            User_Form userForm = new User_Form();
            AddControls(userForm);
        }

        private void Roomsbutton_Click(object sender, EventArgs e)
        {
            ChangeBackgroud(Roomsbutton);
            ManageRooms manageRooms = new ManageRooms();
            AddControls(manageRooms);
        }

        private void Categoriesbutton_Click(object sender, EventArgs e)
        {
            ChangeBackgroud(Categoriesbutton);
            CategoriesForm categoriesForm = new CategoriesForm();
            AddControls(categoriesForm);
        }

        private void Customersbutton_Click(object sender, EventArgs e)
        {
            ChangeBackgroud(Customersbutton);
            CustomersForm customersForm = new CustomersForm();
            AddControls(customersForm);
        }

        private void Bookingsbutton_Click(object sender, EventArgs e)
        {
            ChangeBackgroud(Bookingsbutton);

            BookingForm bookingForm = new BookingForm();
            bookingForm.UserID = UserID;
            AddControls(bookingForm);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }
    }
}
