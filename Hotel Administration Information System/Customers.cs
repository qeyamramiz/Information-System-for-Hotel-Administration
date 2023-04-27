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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomers();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ShowCustomers()
        {
            Db.Open();
            string showQuery = "select * from Customer";
            SqlDataAdapter sda = new SqlDataAdapter(showQuery, Db);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            CustomersLists.DataSource = dataset.Tables[0];
            Db.Close();
        }

        private void EditCustomer()
        {
            if (Customer_name.Text == "" || Customer_gender.SelectedIndex == -1 || Customer_contact.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("update Customer set customer_name = @customer_name, customer_contact = @customer_contact, customer_gender = @customer_gender where customer_id = @customer_id", Db);
                    cmd.Parameters.AddWithValue("@customer_name", Customer_name.Text);
                    cmd.Parameters.AddWithValue("@customer_contact", Customer_contact.Text);
                    cmd.Parameters.AddWithValue("@customer_gender", Customer_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@customer_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer was updated successfully!");
                    Db.Close();
                    ShowCustomers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void InsertCustomer()
        {
            if (Customer_name.Text == "" || Customer_gender.SelectedIndex == -1 || Customer_contact.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customer(customer_name, customer_contact, customer_gender) values(@customer_name, @customer_contact, @customer_gender)", Db);
                    cmd.Parameters.AddWithValue("@customer_name", Customer_name.Text);
                    cmd.Parameters.AddWithValue("@customer_contact", Customer_contact.Text);
                    cmd.Parameters.AddWithValue("@customer_gender", Customer_gender.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer was added successfully!");
                    Db.Close();
                    ShowCustomers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeleteCustomer()
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("delete from Customer where customer_id = @customer_id", Db);
                    cmd.Parameters.AddWithValue("@customer_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer was deleted successfully!");
                    Db.Close();
                    ShowCustomers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertCustomer();
        }

        int Key = 0;
        private void CustomersLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_name.Text = CustomersLists.SelectedRows[0].Cells[1].Value.ToString();
            Customer_contact.Text = CustomersLists.SelectedRows[0].Cells[2].Value.ToString();
            Customer_gender.Text = CustomersLists.SelectedRows[0].Cells[3].Value.ToString();

            if (Customer_name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomersLists.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            Rooms ObjRoom = new Rooms();
            ObjRoom.Show();
            this.Hide();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Type ObjType = new Type();
            ObjType.Show();
            this.Hide();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Users ObjUsers = new Users();
            ObjUsers.Show();
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
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
