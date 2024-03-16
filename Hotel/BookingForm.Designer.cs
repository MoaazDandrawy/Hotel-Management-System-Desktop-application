namespace Hotel
{
    partial class BookingForm
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
            this.BookingNamelabel = new System.Windows.Forms.Label();
            this.NumberRoomcomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDcomboBox = new System.Windows.Forms.ComboBox();
            this.CheckOutdateTime = new System.Windows.Forms.DateTimePicker();
            this.CheckIndateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bookbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.BookingdataGridView = new System.Windows.Forms.DataGridView();
            this.BookNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysNumberlabel = new System.Windows.Forms.Label();
            this.TotalCostlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookingdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingNamelabel
            // 
            this.BookingNamelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingNamelabel.Location = new System.Drawing.Point(-2, -3);
            this.BookingNamelabel.Name = "BookingNamelabel";
            this.BookingNamelabel.Size = new System.Drawing.Size(945, 45);
            this.BookingNamelabel.TabIndex = 0;
            this.BookingNamelabel.Text = "Rooms Booking";
            this.BookingNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberRoomcomboBox
            // 
            this.NumberRoomcomboBox.BackColor = System.Drawing.Color.White;
            this.NumberRoomcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberRoomcomboBox.FormattingEnabled = true;
            this.NumberRoomcomboBox.Location = new System.Drawing.Point(467, 67);
            this.NumberRoomcomboBox.Name = "NumberRoomcomboBox";
            this.NumberRoomcomboBox.Size = new System.Drawing.Size(162, 38);
            this.NumberRoomcomboBox.TabIndex = 1;
            this.NumberRoomcomboBox.SelectedIndexChanged += new System.EventHandler(this.NumberRoomcomboBox_SelectedIndexChanged);
            // 
            // CustomerIDcomboBox
            // 
            this.CustomerIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerIDcomboBox.FormattingEnabled = true;
            this.CustomerIDcomboBox.Location = new System.Drawing.Point(467, 124);
            this.CustomerIDcomboBox.Name = "CustomerIDcomboBox";
            this.CustomerIDcomboBox.Size = new System.Drawing.Size(162, 38);
            this.CustomerIDcomboBox.TabIndex = 2;
            // 
            // CheckOutdateTime
            // 
            this.CheckOutdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckOutdateTime.Location = new System.Drawing.Point(111, 124);
            this.CheckOutdateTime.Name = "CheckOutdateTime";
            this.CheckOutdateTime.Size = new System.Drawing.Size(200, 39);
            this.CheckOutdateTime.TabIndex = 3;
            this.CheckOutdateTime.Value = new System.DateTime(2024, 2, 23, 0, 0, 0, 0);
            this.CheckOutdateTime.ValueChanged += new System.EventHandler(this.CheckOutdateTime_ValueChanged);
            // 
            // CheckIndateTime
            // 
            this.CheckIndateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckIndateTime.Location = new System.Drawing.Point(111, 64);
            this.CheckIndateTime.MinDate = new System.DateTime(2024, 2, 25, 0, 0, 0, 0);
            this.CheckIndateTime.Name = "CheckIndateTime";
            this.CheckIndateTime.Size = new System.Drawing.Size(200, 39);
            this.CheckIndateTime.TabIndex = 4;
            this.CheckIndateTime.ValueChanged += new System.EventHandler(this.CheckIndateTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Check In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check Out:";
            // 
            // Bookbutton
            // 
            this.Bookbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookbutton.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookbutton.ForeColor = System.Drawing.Color.White;
            this.Bookbutton.Location = new System.Drawing.Point(238, 188);
            this.Bookbutton.Name = "Bookbutton";
            this.Bookbutton.Size = new System.Drawing.Size(166, 46);
            this.Bookbutton.TabIndex = 11;
            this.Bookbutton.Text = "Book";
            this.Bookbutton.UseVisualStyleBackColor = false;
            this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.ForeColor = System.Drawing.Color.White;
            this.Cancelbutton.Location = new System.Drawing.Point(520, 188);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(166, 46);
            this.Cancelbutton.TabIndex = 13;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // BookingdataGridView
            // 
            this.BookingdataGridView.AllowUserToAddRows = false;
            this.BookingdataGridView.AllowUserToDeleteRows = false;
            this.BookingdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookingdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookingdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BookingdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookNum,
            this.Room,
            this.Customer,
            this.BookDate,
            this.CheckIn,
            this.CheckOut,
            this.Duration,
            this.Amount});
            this.BookingdataGridView.GridColor = System.Drawing.Color.White;
            this.BookingdataGridView.Location = new System.Drawing.Point(64, 247);
            this.BookingdataGridView.MultiSelect = false;
            this.BookingdataGridView.Name = "BookingdataGridView";
            this.BookingdataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookingdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.BookingdataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookingdataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingdataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookingdataGridView.RowTemplate.Height = 24;
            this.BookingdataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookingdataGridView.Size = new System.Drawing.Size(819, 234);
            this.BookingdataGridView.TabIndex = 14;
            this.BookingdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingdataGridView_CellClick);
            this.BookingdataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingdataGridView_CellMouseEnter);
            this.BookingdataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingdataGridView_CellMouseLeave);
            // 
            // BookNum
            // 
            this.BookNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BookNum.HeaderText = "Book Number";
            this.BookNum.MinimumWidth = 6;
            this.BookNum.Name = "BookNum";
            this.BookNum.ReadOnly = true;
            this.BookNum.Width = 148;
            // 
            // Room
            // 
            this.Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Room.HeaderText = "Room Number";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Room.Width = 132;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer.HeaderText = "Customer ID";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Customer.Width = 115;
            // 
            // BookDate
            // 
            this.BookDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BookDate.HeaderText = "Book Date";
            this.BookDate.MinimumWidth = 6;
            this.BookDate.Name = "BookDate";
            this.BookDate.ReadOnly = true;
            this.BookDate.Width = 121;
            // 
            // CheckIn
            // 
            this.CheckIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckIn.HeaderText = "Check  In";
            this.CheckIn.MinimumWidth = 6;
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Width = 113;
            // 
            // CheckOut
            // 
            this.CheckOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckOut.HeaderText = "Check Out";
            this.CheckOut.MinimumWidth = 6;
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            this.CheckOut.Width = 122;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Duration.Width = 86;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 81;
            // 
            // DaysNumberlabel
            // 
            this.DaysNumberlabel.AutoSize = true;
            this.DaysNumberlabel.Location = new System.Drawing.Point(686, 70);
            this.DaysNumberlabel.Name = "DaysNumberlabel";
            this.DaysNumberlabel.Size = new System.Drawing.Size(0, 30);
            this.DaysNumberlabel.TabIndex = 15;
            // 
            // TotalCostlabel
            // 
            this.TotalCostlabel.AutoSize = true;
            this.TotalCostlabel.Location = new System.Drawing.Point(686, 127);
            this.TotalCostlabel.Name = "TotalCostlabel";
            this.TotalCostlabel.Size = new System.Drawing.Size(0, 30);
            this.TotalCostlabel.TabIndex = 16;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 513);
            this.Controls.Add(this.TotalCostlabel);
            this.Controls.Add(this.DaysNumberlabel);
            this.Controls.Add(this.BookingdataGridView);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Bookbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckIndateTime);
            this.Controls.Add(this.CheckOutdateTime);
            this.Controls.Add(this.CustomerIDcomboBox);
            this.Controls.Add(this.NumberRoomcomboBox);
            this.Controls.Add(this.BookingNamelabel);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookingdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookingNamelabel;
        private System.Windows.Forms.ComboBox NumberRoomcomboBox;
        private System.Windows.Forms.ComboBox CustomerIDcomboBox;
        private System.Windows.Forms.DateTimePicker CheckOutdateTime;
        private System.Windows.Forms.DateTimePicker CheckIndateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bookbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DataGridView BookingdataGridView;
        private System.Windows.Forms.Label DaysNumberlabel;
        private System.Windows.Forms.Label TotalCostlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}