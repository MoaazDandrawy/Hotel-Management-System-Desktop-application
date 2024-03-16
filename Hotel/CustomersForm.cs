using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomerNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }



        private void CustomerSSNmaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string ssn = CustomerSSNmaskedTextBox.Text.Replace("-", ""); // Remove hyphens

            if (ssn.Length != 14 || !long.TryParse(ssn, out _))
            {
                // Invalid SSN format

                e.Cancel = true;
                MessageBox.Show("Please enter a valid SSN (##-###-###-###-###).", "Invalid SSN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void CustomerPhoneMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string phone = CustomerPhonemaskedTextBox.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("+", ""); // Remove hyphens, parentheses, and spaces
            if (phone.Length != 12 || !long.TryParse(phone, out _))
            {
                // Invalid phone number format
                e.Cancel = true;
                MessageBox.Show("Please enter a valid phone number (+20)-##########.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    using (var db = new HotelDBContext())
                    {
                        var customer = new Customer
                        {
                            SSN = CustomerSSNmaskedTextBox.Text,
                            Name = CustomerNametextBox.Text,
                            PhoneNumber = CustomerPhonemaskedTextBox.Text,
                            Address = CustomerAdresstextBox.Text,
                            Gender = CustomerGendercomboBox.Text
                        };
                        db.Customers.Add(customer);
                        db.SaveChanges();
                        MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerSSNmaskedTextBox.Clear();
                        CustomerNametextBox.Clear();
                        CustomerPhonemaskedTextBox.Clear();
                        CustomerAdresstextBox.Clear();
                        CustomerGendercomboBox.SelectedIndex = -1;
                        CustomerdataGridView.DataSource = db.Customers.ToList();
                        CustomerdataGridView.RowHeadersVisible = false;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                
            }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new HotelDBContext())
                {
                    var customer = db.Customers.Find(CustomerSSNmaskedTextBox.Text);
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerSSNmaskedTextBox.Clear();
                    CustomerNametextBox.Clear();
                    CustomerPhonemaskedTextBox.Clear();
                    CustomerAdresstextBox.Clear();
                    CustomerGendercomboBox.SelectedIndex = -1;
                    CustomerdataGridView.DataSource = db.Customers.ToList();
                    CustomerdataGridView.RowHeadersVisible = false;
                    Savebutton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void CustomerdataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CustomerdataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }

        }

        private void CustomerdataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Revert the background color of the entire row
                CustomerdataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 64, 64); ;
            }

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            using (var db = new HotelDBContext())
            {
                CustomerdataGridView.DataSource = db.Customers.ToList();
                CustomerdataGridView.RowHeadersVisible = false;
            }
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Deletebutton.Enabled = false;

        }

        private void CustomerdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CustomerSSNmaskedTextBox.Text = CustomerdataGridView.CurrentRow.Cells[0].Value.ToString();
                CustomerNametextBox.Text = CustomerdataGridView.CurrentRow.Cells[1].Value.ToString();
                CustomerPhonemaskedTextBox.Text = CustomerdataGridView.CurrentRow.Cells[2].Value.ToString();
                CustomerAdresstextBox.Text = CustomerdataGridView.CurrentRow.Cells[3].Value.ToString();
                CustomerGendercomboBox.Text = CustomerdataGridView.CurrentRow.Cells[4].Value.ToString();
                Savebutton.Enabled = false;
                Deletebutton.Enabled = true;
            }

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
             
            if (CustomerNametextBox.Text == "" || CustomerPhonemaskedTextBox.Text == "" || CustomerAdresstextBox.Text == "" || CustomerGendercomboBox.Text == "")
            {
                MessageBox.Show("Missing Information ! ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            else
            {
                try
                {
                    using (var db = new HotelDBContext())
                    {
                        var customer = db.Customers.Find(CustomerSSNmaskedTextBox.Text);
                        CustomerSSNmaskedTextBox.Enabled = false;
                        customer.Name = CustomerNametextBox.Text;
                        customer.PhoneNumber = CustomerPhonemaskedTextBox.Text;
                        customer.Address = CustomerAdresstextBox.Text;
                        customer.Gender = CustomerGendercomboBox.Text;
                        db.SaveChanges();
                        MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        CustomerSSNmaskedTextBox.Clear();
                        CustomerNametextBox.Clear();
                        CustomerPhonemaskedTextBox.Clear();
                        CustomerAdresstextBox.Clear();
                        CustomerGendercomboBox.SelectedIndex = -1;
                        CustomerdataGridView.DataSource = db.Customers.ToList();
                        CustomerdataGridView.RowHeadersVisible = false;
                        Savebutton.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}
