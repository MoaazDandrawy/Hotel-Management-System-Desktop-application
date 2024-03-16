using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class User_Form : Form
    {
        HotelDBContext context = new HotelDBContext();
        int? UserID;
        bool flag = true;
        public User_Form()
        {
            InitializeComponent();
            DGV_User.DataSource = context.Users.ToList();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (UserID == null)
            {
                MessageBox.Show("Invaild ID User");
                return;
            }
            var user = context.Users.Find(UserID);
            if (user == null)
            {
                MessageBox.Show("Cant Find  User");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                context.Users.Remove(user);
                try
                {
                    context.SaveChanges();
                    DGV_User.DataSource = context.Users.ToList();
                    MessageBox.Show("User deleted successfully");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + exp.Message);
                }
            }

           
        }

        private void DGV_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_User.Rows[DGV_User.SelectedCells[0].RowIndex];
                textBox_Name.Text = row.Cells["Name"].Value.ToString();
                textBox_Email.Text = row.Cells["Email"].Value.ToString();
                textBox_Password.Text = row.Cells["Password"].Value.ToString();
                comboBox_Gender.SelectedItem = row.Cells["Gender"].Value.ToString();
                UserID = int.Parse(row.Cells["UserID"].Value.ToString());
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("InValid Data Please Enter Vaild Data");
                return;
            }
            if (UserID == null)
            {
                MessageBox.Show("Invaild ID User");
                return;
            }
            var user = context.Users.Find(UserID);
            if (user == null)
            {
                MessageBox.Show("Cant Find  User");
                return;
            }
            if (DGV_User.SelectedCells.Count > 0)
            {
                user.Name = textBox_Name.Text;
                user.Email = textBox_Email.Text;
                user.Password = textBox_Password.Text;
                user.Gender = comboBox_Gender.Text;
                try
                {
                    context.SaveChanges();
                    DGV_User.Refresh();
                    //DGV_User.DataSource = context.Users.ToList();
                    MessageBox.Show("User Updated successfully");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + exp.Message);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                MessageBox.Show("InValid Data , Please Enter Vaild Data");
                return;
            }
            User existingUser = context.Users.FirstOrDefault(u => u.Email == textBox_Email.Text && u.Password == textBox_Password.Text);
            if (existingUser != null)
            {
                MessageBox.Show("Duplicate User");
                return;
            }
            User user = new User()
            {
                Name = textBox_Name.Text,
                Email = textBox_Email.Text,
                Password = textBox_Password.Text,
                Gender = comboBox_Gender.Text,
                UserRole = "User"
               
            };
            context.Users.Add(user);
            try
            {
                context.SaveChanges();
                DGV_User.DataSource = context.Users.ToList();
                MessageBox.Show("User Add successfully");
            }
            catch (Exception exp)
            {
                MessageBox.Show("An error occurred while deleting the user: " + exp.Message);
            }

        }

      
        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.Clear();
            T.ForeColor = Color.Black;
        }
        private void IsValidName(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            string namePattern = @"^[a-zA-Z\- ]{2,}$";
            if( Regex.IsMatch(T.Text, namePattern))
            {
                flag = true;
                Namelbl.Text = "Vaild";
                Namelbl.ForeColor = Color.Green;
            }
            else
            {
                flag = false;
                Namelbl.Text = "Invaild Name";
                Namelbl.ForeColor = Color.Red;
            }
        }

        private void IsValidEmail(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(T.Text, emailPattern))
            {
                flag = true;
                Email_lbl.Text = "Vaild";
                Email_lbl.ForeColor = Color.Green;
            }
            else
            {
                flag = false;
                Email_lbl.Text = "Invaild Email";
                Email_lbl.ForeColor = Color.Red;
            }
        }

        private void IsValidPassword(object sender, EventArgs e)
        {

            TextBox T = (TextBox)sender;
            string passwordPattern = @".{8,}";
            if (Regex.IsMatch(T.Text, passwordPattern))
            {
                flag = true;
                Pass_lbl.Text = "Vaild";
                Pass_lbl.ForeColor = Color.Green;
            }
            else
            {
                flag = false;
                Pass_lbl.Text = "Invaild Password";
                Pass_lbl.ForeColor = Color.Red;
            }
        }

        private void DGV_User_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DGV_User.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void DGV_User_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DGV_User.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 64, 64);
            }
        }
    }
}
