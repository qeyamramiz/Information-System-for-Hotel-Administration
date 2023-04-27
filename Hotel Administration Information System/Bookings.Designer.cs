namespace Hotel_Administration_Information_System
{
    partial class Bookings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Cancel_button = new Button();
            Customer_name = new ComboBox();
            Room_name = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Booking_duration = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            Booking_date = new DateTimePicker();
            Booking_amount = new RichTextBox();
            BookingsList = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Save_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookingsList).BeginInit();
            SuspendLayout();
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.Crimson;
            Cancel_button.Cursor = Cursors.Hand;
            Cancel_button.FlatStyle = FlatStyle.Flat;
            Cancel_button.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_button.ForeColor = Color.White;
            Cancel_button.Location = new Point(1039, 344);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(165, 45);
            Cancel_button.TabIndex = 23;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // Customer_name
            // 
            Customer_name.BackColor = SystemColors.Control;
            Customer_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Customer_name.FormattingEnabled = true;
            Customer_name.Items.AddRange(new object[] { "Booked", "Available" });
            Customer_name.Location = new Point(795, 243);
            Customer_name.Name = "Customer_name";
            Customer_name.Size = new Size(91, 37);
            Customer_name.TabIndex = 20;
            Customer_name.Text = "Customer";
            // 
            // Room_name
            // 
            Room_name.BackColor = SystemColors.Control;
            Room_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Room_name.FormattingEnabled = true;
            Room_name.Location = new Point(544, 243);
            Room_name.Name = "Room_name";
            Room_name.Size = new Size(108, 37);
            Room_name.TabIndex = 19;
            Room_name.Text = "Room";
            Room_name.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            Room_name.SelectionChangeCommitted += Room_name_SelectionChangeCommitted;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Booking_duration
            // 
            Booking_duration.BackColor = Color.FromArgb(224, 224, 224);
            Booking_duration.BorderStyle = BorderStyle.FixedSingle;
            Booking_duration.DetectUrls = false;
            Booking_duration.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Booking_duration.Location = new Point(1203, 239);
            Booking_duration.Name = "Booking_duration";
            Booking_duration.Size = new Size(66, 41);
            Booking_duration.TabIndex = 16;
            Booking_duration.Text = "";
            Booking_duration.TextChanged += richTextBox9_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 72);
            panel4.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(120, 10);
            label8.Name = "label8";
            label8.Size = new Size(101, 39);
            label8.TabIndex = 47;
            label8.Text = "Rooms";
            label8.MouseClick += label8_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGray;
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(0, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(416, 72);
            panel5.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(120, 14);
            label9.Name = "label9";
            label9.Size = new Size(160, 39);
            label9.TabIndex = 46;
            label9.Text = "Categories";
            label9.Click += label9_Click;
            label9.MouseClick += label9_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2466, 115);
            panel2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1422, 34);
            label7.Name = "label7";
            label7.Size = new Size(105, 39);
            label7.TabIndex = 9;
            label7.Text = "Logout";
            label7.TextAlign = ContentAlignment.BottomCenter;
            label7.MouseClick += label7_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(80, 25);
            label1.Name = "label1";
            label1.Size = new Size(708, 48);
            label1.TabIndex = 8;
            label1.Text = "Hotel Administration Information System";
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1533, 32);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.MouseClick += pictureBox7_MouseClick;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(506, 188);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 116);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 785);
            panel3.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SteelBlue;
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(0, 301);
            panel8.Name = "panel8";
            panel8.Size = new Size(416, 72);
            panel8.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(42, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(120, 15);
            label12.Name = "label12";
            label12.Size = new Size(132, 39);
            label12.TabIndex = 50;
            label12.Text = "Bookings";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGray;
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(0, 225);
            panel7.Name = "panel7";
            panel7.Size = new Size(416, 72);
            panel7.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(42, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(120, 15);
            label11.Name = "label11";
            label11.Size = new Size(156, 39);
            label11.TabIndex = 49;
            label11.Text = "Customers";
            label11.MouseClick += label11_MouseClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(0, 150);
            panel6.Name = "panel6";
            panel6.Size = new Size(416, 72);
            panel6.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(42, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(120, 15);
            label10.Name = "label10";
            label10.Size = new Size(95, 39);
            label10.TabIndex = 48;
            label10.Text = "Users";
            label10.MouseClick += label10_MouseClick;
            // 
            // Booking_date
            // 
            Booking_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Booking_date.Format = DateTimePickerFormat.Short;
            Booking_date.Location = new Point(913, 246);
            Booking_date.Name = "Booking_date";
            Booking_date.Size = new Size(152, 34);
            Booking_date.TabIndex = 24;
            // 
            // Booking_amount
            // 
            Booking_amount.BackColor = Color.FromArgb(224, 224, 224);
            Booking_amount.BorderStyle = BorderStyle.FixedSingle;
            Booking_amount.Enabled = false;
            Booking_amount.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Booking_amount.Location = new Point(1405, 239);
            Booking_amount.Name = "Booking_amount";
            Booking_amount.Size = new Size(132, 41);
            Booking_amount.TabIndex = 25;
            Booking_amount.Text = "";
            // 
            // BookingsList
            // 
            BookingsList.AllowUserToAddRows = false;
            BookingsList.AllowUserToDeleteRows = false;
            BookingsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BookingsList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BookingsList.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BookingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BookingsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingsList.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BookingsList.DefaultCellStyle = dataGridViewCellStyle2;
            BookingsList.Location = new Point(414, 466);
            BookingsList.Name = "BookingsList";
            BookingsList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BookingsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BookingsList.RowHeadersWidth = 60;
            BookingsList.RowTemplate.Height = 29;
            BookingsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingsList.Size = new Size(1186, 434);
            BookingsList.TabIndex = 41;
            BookingsList.CellContentClick += BookingsList_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(464, 245);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 9;
            label2.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(679, 245);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 42;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(1090, 245);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 43;
            label4.Text = "Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(1299, 245);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 44;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(902, 140);
            label6.Name = "label6";
            label6.Size = new Size(240, 48);
            label6.TabIndex = 45;
            label6.Text = "Room Booking";
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.SteelBlue;
            Save_button.Cursor = Cursors.Hand;
            Save_button.FlatStyle = FlatStyle.Flat;
            Save_button.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Save_button.ForeColor = Color.White;
            Save_button.Location = new Point(787, 344);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(165, 45);
            Save_button.TabIndex = 21;
            Save_button.Text = "Book";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BookingsList);
            Controls.Add(Booking_amount);
            Controls.Add(Booking_date);
            Controls.Add(Cancel_button);
            Controls.Add(Save_button);
            Controls.Add(Customer_name);
            Controls.Add(Room_name);
            Controls.Add(Booking_duration);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookings";
            Load += Bookings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookingsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel_button;
        private ComboBox Customer_name;
        private ComboBox Room_name;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox Booking_duration;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Panel panel1;
        private Panel panel3;
        private Panel panel8;
        private PictureBox pictureBox5;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Panel panel6;
        private PictureBox pictureBox3;
        private DateTimePicker Booking_date;
        private RichTextBox Booking_amount;
        private DataGridView BookingsList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label6;
        private Button Save_button;
    }
}