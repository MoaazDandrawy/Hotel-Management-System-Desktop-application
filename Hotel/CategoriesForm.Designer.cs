namespace Hotel
{
    partial class CategoriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TypeNametextBox = new System.Windows.Forms.TextBox();
            this.TypeDailyCosttextBox = new System.Windows.Forms.TextBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.TypeNamelabel = new System.Windows.Forms.Label();
            this.TypeDailyCostlabel = new System.Windows.Forms.Label();
            this.GuestsNumberlabel = new System.Windows.Forms.Label();
            this.TypedataGridView = new System.Windows.Forms.DataGridView();
            this.GuestsNumbertextBox = new System.Windows.Forms.TextBox();
            this.BookingNamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TypedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeNametextBox
            // 
            this.TypeNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNametextBox.Location = new System.Drawing.Point(83, 64);
            this.TypeNametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeNametextBox.Name = "TypeNametextBox";
            this.TypeNametextBox.Size = new System.Drawing.Size(203, 30);
            this.TypeNametextBox.TabIndex = 0;
            this.TypeNametextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // TypeDailyCosttextBox
            // 
            this.TypeDailyCosttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeDailyCosttextBox.Location = new System.Drawing.Point(345, 64);
            this.TypeDailyCosttextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeDailyCosttextBox.Name = "TypeDailyCosttextBox";
            this.TypeDailyCosttextBox.Size = new System.Drawing.Size(203, 30);
            this.TypeDailyCosttextBox.TabIndex = 3;
            this.TypeDailyCosttextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.TypeDailyCosttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeDailyCosttextBox_KeyPress);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Editbutton.Location = new System.Drawing.Point(45, 119);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(204, 36);
            this.Editbutton.TabIndex = 4;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Savebutton.Location = new System.Drawing.Point(296, 119);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(204, 36);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Deletebutton.Location = new System.Drawing.Point(547, 119);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(204, 36);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // TypeNamelabel
            // 
            this.TypeNamelabel.AutoSize = true;
            this.TypeNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNamelabel.Location = new System.Drawing.Point(5, 59);
            this.TypeNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeNamelabel.Name = "TypeNamelabel";
            this.TypeNamelabel.Size = new System.Drawing.Size(72, 40);
            this.TypeNamelabel.TabIndex = 7;
            this.TypeNamelabel.Text = "Ctegory \r\nName ";
            // 
            // TypeDailyCostlabel
            // 
            this.TypeDailyCostlabel.AutoSize = true;
            this.TypeDailyCostlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeDailyCostlabel.Location = new System.Drawing.Point(292, 59);
            this.TypeDailyCostlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeDailyCostlabel.Name = "TypeDailyCostlabel";
            this.TypeDailyCostlabel.Size = new System.Drawing.Size(47, 40);
            this.TypeDailyCostlabel.TabIndex = 8;
            this.TypeDailyCostlabel.Text = "Daily\r\nCost";
            // 
            // GuestsNumberlabel
            // 
            this.GuestsNumberlabel.AutoSize = true;
            this.GuestsNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestsNumberlabel.Location = new System.Drawing.Point(554, 59);
            this.GuestsNumberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GuestsNumberlabel.Name = "GuestsNumberlabel";
            this.GuestsNumberlabel.Size = new System.Drawing.Size(68, 40);
            this.GuestsNumberlabel.TabIndex = 10;
            this.GuestsNumberlabel.Text = "Guests\r\nNumber\r\n";
            // 
            // TypedataGridView
            // 
            this.TypedataGridView.AllowUserToResizeColumns = false;
            this.TypedataGridView.AllowUserToResizeRows = false;
            this.TypedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TypedataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypedataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TypedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TypedataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypedataGridView.Location = new System.Drawing.Point(39, 181);
            this.TypedataGridView.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.TypedataGridView.Name = "TypedataGridView";
            this.TypedataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypedataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TypedataGridView.RowHeadersWidth = 102;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypedataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TypedataGridView.RowTemplate.Height = 40;
            this.TypedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypedataGridView.Size = new System.Drawing.Size(763, 272);
            this.TypedataGridView.TabIndex = 12;
            this.TypedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypedataGridView_CellDoubleClick);
            this.TypedataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypedataGridView_CellMouseEnter);
            this.TypedataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypedataGridView_CellMouseLeave);
            // 
            // GuestsNumbertextBox
            // 
            this.GuestsNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestsNumbertextBox.Location = new System.Drawing.Point(628, 64);
            this.GuestsNumbertextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GuestsNumbertextBox.Name = "GuestsNumbertextBox";
            this.GuestsNumbertextBox.Size = new System.Drawing.Size(203, 30);
            this.GuestsNumbertextBox.TabIndex = 13;
            this.GuestsNumbertextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.GuestsNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuestsNumbertextBox_KeyPress);
            // 
            // BookingNamelabel
            // 
            this.BookingNamelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingNamelabel.Location = new System.Drawing.Point(-16, -6);
            this.BookingNamelabel.Name = "BookingNamelabel";
            this.BookingNamelabel.Size = new System.Drawing.Size(945, 45);
            this.BookingNamelabel.TabIndex = 14;
            this.BookingNamelabel.Text = "Rooms Categories";
            this.BookingNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(941, 513);
            this.Controls.Add(this.BookingNamelabel);
            this.Controls.Add(this.GuestsNumbertextBox);
            this.Controls.Add(this.TypedataGridView);
            this.Controls.Add(this.GuestsNumberlabel);
            this.Controls.Add(this.TypeDailyCostlabel);
            this.Controls.Add(this.TypeNamelabel);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.TypeDailyCosttextBox);
            this.Controls.Add(this.TypeNametextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(941, 513);
            this.MinimumSize = new System.Drawing.Size(941, 513);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeNametextBox;
        private System.Windows.Forms.TextBox TypeDailyCosttextBox;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label TypeNamelabel;
        private System.Windows.Forms.Label TypeDailyCostlabel;
        private System.Windows.Forms.Label GuestsNumberlabel;
        private System.Windows.Forms.DataGridView TypedataGridView;
        private System.Windows.Forms.TextBox GuestsNumbertextBox;
        private System.Windows.Forms.Label BookingNamelabel;
    }
}