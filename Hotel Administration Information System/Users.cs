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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            ShowUsers();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ShowUsers()
        {
            Db.Open();
            string showQuery = "select * from Users";
            SqlDataAdapter sda = new SqlDataAdapter(showQuery, Db);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            UsersLists.DataSource = dataset.Tables[0];
            Db.Close();
        }

        private void EditUser()
        {
            if (Username.Text == "" || User_contact.Text == "" || User_gender.SelectedIndex == -1 || User_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("update Users set user_name = @User_name, user_contact = @UserContact, user_gender = @UserGender, user_password = @UserPassword where user_id = @user_id", Db);
                    cmd.Parameters.AddWithValue("@User_name", Username.Text);
                    cmd.Parameters.AddWithValue("@UserContact", User_contact.Text);
                    cmd.Parameters.AddWithValue("@UserGender", User_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UserPassword", User_password.Text);
                    cmd.Parameters.AddWithValue("@user_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User was updated successfully!");
                    Db.Close();
                    ShowUsers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteUser()
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a user to delete.");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("delete from Users where user_id = @user_id", Db);
                    cmd.Parameters.AddWithValue("@user_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User was deleted successfully!");
                    Db.Close();
                    ShowUsers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void InsertUsers()
        {
            if (Username.Text == "" || User_contact.Text == "" || User_gender.SelectedIndex == -1 || User_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("insert into Users(user_name, user_contact, user_gender, user_password) values(@User_name, @UserContact, @UserGender, @UserPassword)", Db);
                    cmd.Parameters.AddWithValue("@User_name", Username.Text);
                    cmd.Parameters.AddWithValue("@UserContact", User_contact.Text);
                    cmd.Parameters.AddWithValue("@UserGender", User_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UserPassword", User_password.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User was added successfully!");
                    Db.Close();
                    ShowUsers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            InsertUsers();
        }

        int Key = 0;
        private void UsersLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Username.Text = UsersLists.SelectedRows[0].Cells[1].Value.ToString();
            User_contact.Text = UsersLists.SelectedRows[0].Cells[2].Value.ToString();
            User_gender.Text = UsersLists.SelectedRows[0].Cells[3].Value.ToString();
            User_password.Text = UsersLists.SelectedRows[0].Cells[4].Value.ToString();

            if (Username.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UsersLists.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Rooms ObjRooms = new Rooms();
            ObjRooms.Show();
            this.Hide();
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            Type ObjType = new Type();
            ObjType.Show();
            this.Hide();
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Customers ObjCustomer = new Customers();
            ObjCustomer.Show();
            this.Hide();
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            Bookings ObjBookings = new Bookings();
            ObjBookings.Show();
            this.Hide();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }
    }
}
