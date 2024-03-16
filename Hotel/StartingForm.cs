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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_progress_Start.Width += 6;
            if (panel_progress_Start.Width >= 799)
            {
                timer1.Stop();
                Form_Login loginForm = new Form_Login();
                loginForm.Show();
                
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void btn_Close_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
