using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

 

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (TypeNametextBox.Text == "" || TypeDailyCosttextBox.Text == "" || GuestsNumbertextBox.Text=="")
            {
             MessageBox.Show("Missing Information ! ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        
            else
            {
                try
                {


                    using (var db = new HotelDBContext())
                    {
                        
                        var type = new Type
                        {
                            Name = TypeNametextBox.Text,
                            DailyCost = Convert.ToDouble(TypeDailyCosttextBox.Text),
                            GuestCount = Convert.ToInt32(GuestsNumbertextBox.Text)
                        };
                        db.Types.Add(type);
                        db.SaveChanges();
                        MessageBox.Show("Type Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        TypeNametextBox.Text = "";
                        TypeDailyCosttextBox.Text = "";
                        GuestsNumbertextBox.Text = "";
                        TypedataGridView.RowHeadersVisible = false;

                        var types = db.Types.ToList();
                            TypedataGridView.DataSource = types;
                        Deletebutton.Enabled = true;


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message ,"Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
            
           



        }

        private void GuestsNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TypeDailyCosttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // select all types from the database and display them in the data grid view
            TypedataGridView.RowHeadersVisible = false;

            using (var db = new HotelDBContext())
            {
                var types = db.Types.ToList();
                TypedataGridView.DataSource = types;
            }
        }

        private void TypedataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                TypedataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void TypedataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Revert the background color of the entire row
                TypedataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 64, 64);
            }
        }

        

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (TypeNametextBox.Text == "" || TypeDailyCosttextBox.Text == "" || GuestsNumbertextBox.Text == "")
            {
                MessageBox.Show("Missing Information ! ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            } 
            else {
                try
                { 
                    

                    using (var db = new HotelDBContext())
                    {
                        var type = db.Types.Find(TypedataGridView.CurrentRow.Cells[0].Value);
                        type.Name = TypeNametextBox.Text;
                        type.DailyCost = Convert.ToDouble(TypeDailyCosttextBox.Text);
                        type.GuestCount = Convert.ToInt32(GuestsNumbertextBox.Text);
                        db.SaveChanges();
                        MessageBox.Show("Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        TypeNametextBox.Text = "";
                        TypeDailyCosttextBox.Text = "";
                        GuestsNumbertextBox.Text = "";
                        TypedataGridView.RowHeadersVisible = false;

                        var types = db.Types.ToList();
                        TypedataGridView.DataSource = types;
                         Savebutton.Enabled = true;
                        Deletebutton.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
    
            }


        private void TypedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TypedataGridView.Rows[e.RowIndex];
                TypeNametextBox.Text = row.Cells[1].Value.ToString();
                TypeDailyCosttextBox.Text = row.Cells[2].Value.ToString();
                GuestsNumbertextBox.Text = row.Cells[3].Value.ToString();
                Savebutton.Enabled = false;
                Deletebutton.Enabled = true;
            }



        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            if (TypeNametextBox.Text == "" || TypeDailyCosttextBox.Text == "" || GuestsNumbertextBox.Text == "")
            {
                MessageBox.Show("Missing Information ! ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this type ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    using (var db = new HotelDBContext())
                    {
                        var type = db.Types.Find(TypedataGridView.CurrentRow.Cells[0].Value);
                        db.Types.Remove(type);
                        db.SaveChanges();
                        MessageBox.Show("Type Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        TypeNametextBox.Text = "";
                        TypeDailyCosttextBox.Text = "";
                        GuestsNumbertextBox.Text = "";
                        TypedataGridView.RowHeadersVisible = false;

                        var types = db.Types.ToList();
                        TypedataGridView.DataSource = types;
                        Savebutton.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Deletebutton.Enabled = false;

        }  
















    }
}

