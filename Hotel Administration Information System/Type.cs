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
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
            showCategories();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void showCategories()
        {
            Db.Open();
            string showQuery = "select * from Type";
            SqlDataAdapter sda = new SqlDataAdapter(showQuery, Db);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            Categories.DataSource = dataset.Tables[0];
            Db.Close();
        }
        private void InsertCategories()
        {
            if (Room_category.Text == "" || Room_cost.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("insert into Type(room_category, room_cost) values(@roomCategory, @roomCost)", Db);
                    cmd.Parameters.AddWithValue("@roomCategory", Room_category.Text);
                    cmd.Parameters.AddWithValue("@roomCost", Room_cost.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category was added successfully!");
                    Db.Close();
                    showCategories();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditCategory()
        {
            if (Room_category.Text == "" || Room_cost.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("update Type set room_category = @roomCategory, room_cost = @roomCost where Id = @categoryId", Db);
                    cmd.Parameters.AddWithValue("@roomCategory", Room_category.Text);
                    cmd.Parameters.AddWithValue("@roomCost", Room_cost.Text);
                    cmd.Parameters.AddWithValue("@categoryId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category was updated successfully!");
                    Db.Close();
                    showCategories();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteCategory()
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a category to delete.");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("delete from Type where Id = @category_id", Db);
                    cmd.Parameters.AddWithValue("@category_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category was deleted successfully!");
                    Db.Close();
                    showCategories();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            InsertCategories();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            /*Rooms RoomObject = new Rooms();
            RoomObject.Show();
            this.Hide();*/
        }
        int Key = 0;
        private void Categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_category.Text = Categories.SelectedRows[0].Cells[1].Value.ToString();
            Room_cost.Text = Categories.SelectedRows[0].Cells[2].Value.ToString();

            if (Room_category.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Categories.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            EditCategory();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Rooms ObjRoom = new Rooms();
            ObjRoom.Show();
            this.Hide();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Users ObjUsers = new Users();
            ObjUsers.Show();
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Customers ObjCustomers = new Customers();
            ObjCustomers.Show();
            this.Hide();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            Bookings ObjBookings = new Bookings();
            ObjBookings.Show();
            this.Hide();
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }
    }
}
