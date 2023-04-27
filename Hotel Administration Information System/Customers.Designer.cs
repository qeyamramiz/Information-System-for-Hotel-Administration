namespace Hotel_Administration_Information_System
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Delete_button = new Button();
            button1 = new Button();
            Customer_gender = new ComboBox();
            richTextBox11 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Customer_name = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label2 = new Label();
            Edit_button = new Button();
            panel2 = new Panel();
            label11 = new Label();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Customer_contact = new RichTextBox();
            CustomersLists = new DataGridView();
            label8 = new Label();
            label7 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)CustomersLists).BeginInit();
            SuspendLayout();
            // 
            // Delete_button
            // 
            Delete_button.BackColor = Color.Crimson;
            Delete_button.Cursor = Cursors.Hand;
            Delete_button.FlatStyle = FlatStyle.Flat;
            Delete_button.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_button.ForeColor = Color.White;
            Delete_button.Location = new Point(1189, 344);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(165, 45);
            Delete_button.TabIndex = 23;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            Delete_button.Click += Delete_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(754, 344);
            button1.Name = "button1";
            button1.Size = new Size(165, 45);
            button1.TabIndex = 21;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Customer_gender
            // 
            Customer_gender.BackColor = SystemColors.Control;
            Customer_gender.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Customer_gender.FormattingEnabled = true;
            Customer_gender.Items.AddRange(new object[] { "Male", "Female" });
            Customer_gender.Location = new Point(930, 245);
            Customer_gender.Name = "Customer_gender";
            Customer_gender.Size = new Size(151, 37);
            Customer_gender.TabIndex = 19;
            Customer_gender.Text = "Gender";
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = SystemColors.Control;
            richTextBox11.BorderStyle = BorderStyle.None;
            richTextBox11.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox11.Location = new Point(848, 148);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.ReadOnly = true;
            richTextBox11.Size = new Size(396, 58);
            richTextBox11.TabIndex = 18;
            richTextBox11.Text = "Customer Management";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Customer_name
            // 
            Customer_name.BackColor = Color.FromArgb(224, 224, 224);
            Customer_name.BorderStyle = BorderStyle.FixedSingle;
            Customer_name.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Customer_name.Location = new Point(612, 243);
            Customer_name.Name = "Customer_name";
            Customer_name.Size = new Size(257, 41);
            Customer_name.TabIndex = 16;
            Customer_name.Text = "";
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
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(-1, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 72);
            panel4.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(120, 10);
            label3.Name = "label3";
            label3.Size = new Size(101, 39);
            label3.TabIndex = 14;
            label3.Text = "Rooms";
            label3.MouseClick += label3_MouseClick;
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
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(416, 72);
            panel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(120, 15);
            label2.Name = "label2";
            label2.Size = new Size(160, 39);
            label2.TabIndex = 13;
            label2.Text = "Categories";
            label2.MouseClick += label2_MouseClick;
            // 
            // Edit_button
            // 
            Edit_button.BackColor = Color.SteelBlue;
            Edit_button.Cursor = Cursors.Hand;
            Edit_button.FlatStyle = FlatStyle.Flat;
            Edit_button.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Edit_button.ForeColor = Color.White;
            Edit_button.Location = new Point(970, 344);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(165, 45);
            Edit_button.TabIndex = 22;
            Edit_button.Text = "Edit";
            Edit_button.UseVisualStyleBackColor = false;
            Edit_button.Click += Edit_button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(-1, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2466, 115);
            panel2.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(1422, 32);
            label11.Name = "label11";
            label11.Size = new Size(105, 39);
            label11.TabIndex = 9;
            label11.Text = "Logout";
            label11.MouseClick += label11_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(80, 32);
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
            panel1.Location = new Point(505, 188);
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
            panel3.Location = new Point(-1, 116);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 785);
            panel3.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkGray;
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label6);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(120, 15);
            label6.Name = "label6";
            label6.Size = new Size(132, 39);
            label6.TabIndex = 17;
            label6.Text = "Bookings";
            label6.MouseClick += label6_MouseClick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label5);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(120, 16);
            label5.Name = "label5";
            label5.Size = new Size(156, 39);
            label5.TabIndex = 16;
            label5.Text = "Customers";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(120, 15);
            label4.Name = "label4";
            label4.Size = new Size(95, 39);
            label4.TabIndex = 15;
            label4.Text = "Users";
            label4.Click += label4_Click;
            label4.MouseClick += label4_MouseClick;
            // 
            // Customer_contact
            // 
            Customer_contact.BackColor = Color.FromArgb(224, 224, 224);
            Customer_contact.BorderStyle = BorderStyle.FixedSingle;
            Customer_contact.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Customer_contact.Location = new Point(1235, 243);
            Customer_contact.Name = "Customer_contact";
            Customer_contact.Size = new Size(261, 41);
            Customer_contact.TabIndex = 24;
            Customer_contact.Text = "";
            // 
            // CustomersLists
            // 
            CustomersLists.AllowUserToAddRows = false;
            CustomersLists.AllowUserToDeleteRows = false;
            CustomersLists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CustomersLists.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersLists.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomersLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CustomersLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersLists.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomersLists.DefaultCellStyle = dataGridViewCellStyle2;
            CustomersLists.Location = new Point(421, 467);
            CustomersLists.Name = "CustomersLists";
            CustomersLists.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CustomersLists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CustomersLists.RowHeadersWidth = 60;
            CustomersLists.RowTemplate.Height = 29;
            CustomersLists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersLists.Size = new Size(1180, 434);
            CustomersLists.TabIndex = 41;
            CustomersLists.CellContentClick += CustomersLists_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(514, 247);
            label8.Name = "label8";
            label8.Size = new Size(77, 32);
            label8.TabIndex = 44;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(1123, 247);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 45;
            label7.Text = "Contact";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(CustomersLists);
            Controls.Add(Customer_contact);
            Controls.Add(Delete_button);
            Controls.Add(button1);
            Controls.Add(Customer_gender);
            Controls.Add(richTextBox11);
            Controls.Add(Customer_name);
            Controls.Add(panel4);
            Controls.Add(Edit_button);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
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
            ((System.ComponentModel.ISupportInitialize)CustomersLists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete_button;
        private Button button1;
        private ComboBox Customer_gender;
        private RichTextBox richTextBox11;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox Customer_name;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button Edit_button;
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
        private RichTextBox Customer_contact;
        private DataGridView CustomersLists;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label11;
    }
}