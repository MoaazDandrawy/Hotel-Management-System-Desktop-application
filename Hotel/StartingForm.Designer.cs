using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
    partial class StartingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.panel_progress_Start = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close_Login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_progress_Start
            // 
            this.panel_progress_Start.BackColor = System.Drawing.Color.White;
            this.panel_progress_Start.Location = new System.Drawing.Point(1, 327);
            this.panel_progress_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_progress_Start.Name = "panel_progress_Start";
            this.panel_progress_Start.Size = new System.Drawing.Size(68, 32);
            this.panel_progress_Start.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITI Hotel ";
            // 
            // btn_Close_Login
            // 
            this.btn_Close_Login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close_Login.FlatAppearance.BorderSize = 0;
            this.btn_Close_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Close_Login.Location = new System.Drawing.Point(765, 1);
            this.btn_Close_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Login.Name = "btn_Close_Login";
            this.btn_Close_Login.Size = new System.Drawing.Size(33, 26);
            this.btn_Close_Login.TabIndex = 3;
            this.btn_Close_Login.Text = "X";
            this.btn_Close_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close_Login.UseVisualStyleBackColor = false;
            this.btn_Close_Login.Click += new System.EventHandler(this.btn_Close_Login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.hotel_3584086_640___Copy___Copy;
            this.pictureBox2.Location = new System.Drawing.Point(341, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 310);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(585, -6);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 42);
            this.button13.TabIndex = 27;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_Close_Login_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(626, 359);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Close_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_progress_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_progress_Start;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button btn_Close_Login;
        private PictureBox pictureBox2;
        private Button button13;
    }
}