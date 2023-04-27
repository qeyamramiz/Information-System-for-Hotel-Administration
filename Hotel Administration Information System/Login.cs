using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Administration_Information_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (User_name.Text == "" || User_password.Text == "")
            {
                MessageBox.Show("Please fill username and password fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "select count(*) from Users where user_name='" + User_name.Text + "' and user_password='" + User_password.Text + "'"
                    , Db);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    if (data.Rows[0][0].ToString() == "1")
                    {
                        Rooms RoomObj = new Rooms();
                        RoomObj.Show();
                        this.Hide();
                        Db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your password or username is wrong");
                    }
                    Db.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
