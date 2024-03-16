namespace Hotel
{
    partial class CustomersForm
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
            this.Customerlabel = new System.Windows.Forms.Label();
            this.CustomerNamelabel = new System.Windows.Forms.Label();
            this.CustomerNametextBox = new System.Windows.Forms.TextBox();
            this.CustomerGenderlabel = new System.Windows.Forms.Label();
            this.CustomerGendercomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerSSNlabel = new System.Windows.Forms.Label();
            this.CustomerPhonelabel = new System.Windows.Forms.Label();
            this.CustomerAdresslabel = new System.Windows.Forms.Label();
            this.CustomerAdresstextBox = new System.Windows.Forms.TextBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.CustomerSSNmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CustomerPhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CustomerdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Customerlabel
            // 
            this.Customerlabel.AutoSize = true;
            this.Customerlabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerlabel.Location = new System.Drawing.Point(329, 9);
            this.Customerlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Customerlabel.Name = "Customerlabel";
            this.Customerlabel.Size = new System.Drawing.Size(255, 35);
            this.Customerlabel.TabIndex = 2;
            this.Customerlabel.Text = "Manage Customers";
            // 
            // CustomerNamelabel
            // 
            this.CustomerNamelabel.AutoSize = true;
            this.CustomerNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNamelabel.Location = new System.Drawing.Point(15, 72);
            this.CustomerNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerNamelabel.Name = "CustomerNamelabel";
            this.CustomerNamelabel.Size = new System.Drawing.Size(69, 25);
            this.CustomerNamelabel.TabIndex = 9;
            this.CustomerNamelabel.Text = "Name ";
            // 
            // CustomerNametextBox
            // 
            this.CustomerNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNametextBox.Location = new System.Drawing.Point(81, 69);
            this.CustomerNametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerNametextBox.Name = "CustomerNametextBox";
            this.CustomerNametextBox.Size = new System.Drawing.Size(189, 30);
            this.CustomerNametextBox.TabIndex = 8;
            this.CustomerNametextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.CustomerNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNametextBox_KeyPress);
            // 
            // CustomerGenderlabel
            // 
            this.CustomerGenderlabel.AutoSize = true;
            this.CustomerGenderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGenderlabel.Location = new System.Drawing.Point(282, 130);
            this.CustomerGenderlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerGenderlabel.Name = "CustomerGenderlabel";
            this.CustomerGenderlabel.Size = new System.Drawing.Size(77, 25);
            this.CustomerGenderlabel.TabIndex = 10;
            this.CustomerGenderlabel.Text = "Gender";
            // 
            // CustomerGendercomboBox
            // 
            this.CustomerGendercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGendercomboBox.FormattingEnabled = true;
            this.CustomerGendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CustomerGendercomboBox.Location = new System.Drawing.Point(363, 126);
            this.CustomerGendercomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerGendercomboBox.Name = "CustomerGendercomboBox";
            this.CustomerGendercomboBox.Size = new System.Drawing.Size(171, 33);
            this.CustomerGendercomboBox.TabIndex = 11;
            this.CustomerGendercomboBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // CustomerSSNlabel
            // 
            this.CustomerSSNlabel.AutoSize = true;
            this.CustomerSSNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSSNlabel.Location = new System.Drawing.Point(15, 130);
            this.CustomerSSNlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerSSNlabel.Name = "CustomerSSNlabel";
            this.CustomerSSNlabel.Size = new System.Drawing.Size(54, 25);
            this.CustomerSSNlabel.TabIndex = 12;
            this.CustomerSSNlabel.Text = "SSN";
            // 
            // CustomerPhonelabel
            // 
            this.CustomerPhonelabel.AutoSize = true;
            this.CustomerPhonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhonelabel.Location = new System.Drawing.Point(548, 72);
            this.CustomerPhonelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerPhonelabel.Name = "CustomerPhonelabel";
            this.CustomerPhonelabel.Size = new System.Drawing.Size(69, 25);
            this.CustomerPhonelabel.TabIndex = 16;
            this.CustomerPhonelabel.Text = "Phone";
            // 
            // CustomerAdresslabel
            // 
            this.CustomerAdresslabel.AutoSize = true;
            this.CustomerAdresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAdresslabel.Location = new System.Drawing.Point(282, 72);
            this.CustomerAdresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerAdresslabel.Name = "CustomerAdresslabel";
            this.CustomerAdresslabel.Size = new System.Drawing.Size(74, 25);
            this.CustomerAdresslabel.TabIndex = 17;
            this.CustomerAdresslabel.Text = "Adress";
            // 
            // CustomerAdresstextBox
            // 
            this.CustomerAdresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAdresstextBox.Location = new System.Drawing.Point(365, 69);
            this.CustomerAdresstextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerAdresstextBox.Name = "CustomerAdresstextBox";
            this.CustomerAdresstextBox.Size = new System.Drawing.Size(169, 30);
            this.CustomerAdresstextBox.TabIndex = 18;
            this.CustomerAdresstextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Editbutton.Location = new System.Drawing.Point(117, 178);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(156, 46);
            this.Editbutton.TabIndex = 19;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Savebutton.Location = new System.Drawing.Point(365, 178);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(156, 46);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Deletebutton.Location = new System.Drawing.Point(613, 178);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(156, 46);
            this.Deletebutton.TabIndex = 21;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // CustomerSSNmaskedTextBox
            // 
            this.CustomerSSNmaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSSNmaskedTextBox.Location = new System.Drawing.Point(81, 127);
            this.CustomerSSNmaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerSSNmaskedTextBox.Mask = "00-000-000-000-000";
            this.CustomerSSNmaskedTextBox.Name = "CustomerSSNmaskedTextBox";
            this.CustomerSSNmaskedTextBox.Size = new System.Drawing.Size(189, 30);
            this.CustomerSSNmaskedTextBox.TabIndex = 22;
            this.CustomerSSNmaskedTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.CustomerSSNmaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerSSNmaskedTextBox_Validating);
            // 
            // CustomerPhonemaskedTextBox
            // 
            this.CustomerPhonemaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhonemaskedTextBox.Location = new System.Drawing.Point(621, 69);
            this.CustomerPhonemaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerPhonemaskedTextBox.Mask = "(+00)-0000000000";
            this.CustomerPhonemaskedTextBox.Name = "CustomerPhonemaskedTextBox";
            this.CustomerPhonemaskedTextBox.Size = new System.Drawing.Size(180, 30);
            this.CustomerPhonemaskedTextBox.TabIndex = 23;
            this.CustomerPhonemaskedTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.CustomerPhonemaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerPhoneMaskedTextBox_Validating);
            // 
            // CustomerdataGridView
            // 
            this.CustomerdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerdataGridView.Location = new System.Drawing.Point(30, 254);
            this.CustomerdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerdataGridView.Name = "CustomerdataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerdataGridView.RowHeadersWidth = 102;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerdataGridView.RowTemplate.Height = 40;
            this.CustomerdataGridView.Size = new System.Drawing.Size(779, 170);
            this.CustomerdataGridView.TabIndex = 24;
            this.CustomerdataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerdataGridView_CellMouseDoubleClick);
            this.CustomerdataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellMouseEnter);
            this.CustomerdataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellMouseLeave);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(941, 513);
            this.Controls.Add(this.CustomerdataGridView);
            this.Controls.Add(this.CustomerPhonemaskedTextBox);
            this.Controls.Add(this.CustomerSSNmaskedTextBox);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.CustomerAdresstextBox);
            this.Controls.Add(this.CustomerAdresslabel);
            this.Controls.Add(this.CustomerPhonelabel);
            this.Controls.Add(this.CustomerSSNlabel);
            this.Controls.Add(this.CustomerGendercomboBox);
            this.Controls.Add(this.CustomerGenderlabel);
            this.Controls.Add(this.CustomerNamelabel);
            this.Controls.Add(this.CustomerNametextBox);
            this.Controls.Add(this.Customerlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customerlabel;
        private System.Windows.Forms.Label CustomerNamelabel;
        private System.Windows.Forms.TextBox CustomerNametextBox;
        private System.Windows.Forms.Label CustomerGenderlabel;
        private System.Windows.Forms.ComboBox CustomerGendercomboBox;
        private System.Windows.Forms.Label CustomerSSNlabel;
        private System.Windows.Forms.Label CustomerPhonelabel;
        private System.Windows.Forms.Label CustomerAdresslabel;
        private System.Windows.Forms.TextBox CustomerAdresstextBox;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.MaskedTextBox CustomerSSNmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CustomerPhonemaskedTextBox;
        private System.Windows.Forms.DataGridView CustomerdataGridView;
    }
}