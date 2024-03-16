namespace Hotel
{
    partial class ManageRooms
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
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.RoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editRoomsButton = new System.Windows.Forms.Button();
            this.saveRoomsButton = new System.Windows.Forms.Button();
            this.deleteRoomsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberTextBox.Location = new System.Drawing.Point(30, 67);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(197, 33);
            this.roomNumberTextBox.TabIndex = 0;
            this.roomNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomNumberTextBox_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(227, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(301, 60);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Manage Rooms";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Location = new System.Drawing.Point(299, 66);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(197, 35);
            this.roomTypeComboBox.TabIndex = 2;
            this.roomTypeComboBox.Text = "Room Type";
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Booked",
            "Available"});
            this.statusComboBox.Location = new System.Drawing.Point(568, 66);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(197, 35);
            this.statusComboBox.TabIndex = 3;
            this.statusComboBox.Text = "Status";
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToResizeColumns = false;
            this.roomsDataGridView.AllowUserToResizeRows = false;
            this.roomsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNum,
            this.Type,
            this.Satus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomsDataGridView.Location = new System.Drawing.Point(29, 177);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomsDataGridView.RowHeadersWidth = 51;
            this.roomsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.roomsDataGridView.RowTemplate.Height = 24;
            this.roomsDataGridView.Size = new System.Drawing.Size(737, 270);
            this.roomsDataGridView.TabIndex = 4;
            this.roomsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGridView_CellClick);
            this.roomsDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGridView_CellMouseEnter);
            this.roomsDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGridView_CellMouseLeave);
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNum.HeaderText = "Room Number";
            this.RoomNum.MinimumWidth = 6;
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type Name";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Satus
            // 
            this.Satus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Satus.HeaderText = "Status";
            this.Satus.MinimumWidth = 6;
            this.Satus.Name = "Satus";
            this.Satus.ReadOnly = true;
            // 
            // editRoomsButton
            // 
            this.editRoomsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editRoomsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.editRoomsButton.FlatAppearance.BorderSize = 0;
            this.editRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoomsButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editRoomsButton.Location = new System.Drawing.Point(63, 124);
            this.editRoomsButton.Name = "editRoomsButton";
            this.editRoomsButton.Size = new System.Drawing.Size(164, 34);
            this.editRoomsButton.TabIndex = 5;
            this.editRoomsButton.Text = "Update";
            this.editRoomsButton.UseVisualStyleBackColor = false;
            this.editRoomsButton.Click += new System.EventHandler(this.editRoomsButton_Click);
            // 
            // saveRoomsButton
            // 
            this.saveRoomsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveRoomsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.saveRoomsButton.FlatAppearance.BorderSize = 0;
            this.saveRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRoomsButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRoomsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveRoomsButton.Location = new System.Drawing.Point(281, 124);
            this.saveRoomsButton.Name = "saveRoomsButton";
            this.saveRoomsButton.Size = new System.Drawing.Size(164, 34);
            this.saveRoomsButton.TabIndex = 6;
            this.saveRoomsButton.Text = "Insert";
            this.saveRoomsButton.UseVisualStyleBackColor = false;
            this.saveRoomsButton.Click += new System.EventHandler(this.saveRoomsButton_Click);
            // 
            // deleteRoomsButton
            // 
            this.deleteRoomsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteRoomsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.deleteRoomsButton.FlatAppearance.BorderSize = 0;
            this.deleteRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoomsButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoomsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRoomsButton.Location = new System.Drawing.Point(527, 124);
            this.deleteRoomsButton.Name = "deleteRoomsButton";
            this.deleteRoomsButton.Size = new System.Drawing.Size(164, 34);
            this.deleteRoomsButton.TabIndex = 7;
            this.deleteRoomsButton.Text = "Delete";
            this.deleteRoomsButton.UseVisualStyleBackColor = false;
            this.deleteRoomsButton.Click += new System.EventHandler(this.deleteRoomsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Number:";
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 520);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteRoomsButton);
            this.Controls.Add(this.saveRoomsButton);
            this.Controls.Add(this.editRoomsButton);
            this.Controls.Add(this.roomsDataGridView);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.roomNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(944, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(944, 520);
            this.Name = "ManageRooms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.Button editRoomsButton;
        private System.Windows.Forms.Button saveRoomsButton;
        private System.Windows.Forms.Button deleteRoomsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satus;
        private System.Windows.Forms.Label label1;
    }
}