using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form_Login : Form
    {
        HotelDBContext context = new HotelDBContext();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //using EF because Data Is small;
            var user = context.Users.Where(u => u.Email == TextBox_user.Text).FirstOrDefault();

            if (user != null)
            {
                // The user exists => check the password
               
                if (user.Password == TextBoxPass.Text)
                {
                    Layout F = new Layout();

                    F.UserID = user.UserID;

                    if (user.UserRole == "Admin")
                    {  
                        F.Show();
                        this.Hide();
                    }
                    else if(user.UserRole =="User")
                    {
                        F.Usersbutton.Visible = false;  //user authrizention
                        F.Show();
                        this.Hide();

                    }


                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }
    }
}
