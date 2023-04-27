namespace Hotel_Administration_Information_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            User_name = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            User_password = new RichTextBox();
            Login_button = new Button();
            label4 = new Label();
            Close_button = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Close_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 32);
            label1.Name = "label1";
            label1.Size = new Size(708, 48);
            label1.TabIndex = 0;
            label1.Text = "Hotel Administration Information System";
            // 
            // User_name
            // 
            User_name.BackColor = Color.FromArgb(224, 224, 224);
            User_name.BorderStyle = BorderStyle.FixedSingle;
            User_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            User_name.Location = new Point(399, 188);
            User_name.Name = "User_name";
            User_name.Size = new Size(287, 40);
            User_name.TabIndex = 5;
            User_name.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 188);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 250);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // User_password
            // 
            User_password.BackColor = Color.FromArgb(224, 224, 224);
            User_password.BorderStyle = BorderStyle.FixedSingle;
            User_password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            User_password.Location = new Point(399, 250);
            User_password.Name = "User_password";
            User_password.Size = new Size(287, 42);
            User_password.TabIndex = 7;
            User_password.Text = "";
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.SteelBlue;
            Login_button.Cursor = Cursors.Hand;
            Login_button.FlatStyle = FlatStyle.Flat;
            Login_button.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Login_button.ForeColor = Color.White;
            Login_button.Location = new Point(412, 324);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(165, 45);
            Login_button.TabIndex = 10;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(400, 90);
            label4.Name = "label4";
            label4.Size = new Size(159, 39);
            label4.TabIndex = 11;
            label4.Text = "Login Page";
            label4.Click += label4_Click;
            // 
            // Close_button
            // 
            Close_button.Cursor = Cursors.Hand;
            Close_button.Image = (Image)resources.GetObject("Close_button.Image");
            Close_button.Location = new Point(910, 12);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(50, 50);
            Close_button.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_button.TabIndex = 12;
            Close_button.TabStop = false;
            Close_button.Click += Close_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(218, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(218, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(345, 394);
            label5.Name = "label5";
            label5.Size = new Size(300, 25);
            label5.TabIndex = 15;
            label5.Text = "Developed By Ahmad Ramiz Qeyam";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Close_button);
            Controls.Add(label4);
            Controls.Add(Login_button);
            Controls.Add(label3);
            Controls.Add(User_password);
            Controls.Add(label2);
            Controls.Add(User_name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Close_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox User_name;
        private Label label2;
        private Label label3;
        private RichTextBox User_password;
        private Button Login_button;
        private Label label4;
        private PictureBox Close_button;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
    }
}