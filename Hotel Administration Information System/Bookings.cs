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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            ShowBookings();
            GetRooms();
            GetCustomers();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ShowBookings()
        {
            Db.Open();
            string showQuery = "select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(showQuery, Db);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            BookingsList.DataSource = dataset.Tables[0];
            Db.Close();
        }

        private void CancelBooking()
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a Booking to cancel.");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("delete from Booking where booking_id = @booking_id", Db);
                    cmd.Parameters.AddWithValue("@booking_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking was canceled!");
                    Db.Close();
                    ShowBookings();
                    setAvailable();
                    GetRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void InsertBooking()
        {
            if (Room_name.SelectedIndex == -1 || Customer_name.SelectedIndex == -1 || Booking_duration.Text == "" || Booking_amount.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("insert into Booking(room, customer, book_date, duration, cost) values(@room_name, @customer_name, @book_date, @booking_duration, @booking_amount)", Db);
                    cmd.Parameters.AddWithValue("@room_name", Room_name.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@customer_name", Customer_name.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@book_date", Booking_date.Value.Date);
                    cmd.Parameters.AddWithValue("@booking_duration", Booking_duration.Text);
                    cmd.Parameters.AddWithValue("@booking_amount", Booking_amount.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room was booked successfully!");
                    Db.Close();
                    ShowBookings();
                    setBooked();
                    GetRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GetRooms()
        {
            Db.Open();
            SqlCommand command = new SqlCommand("select * from Room where room_status = 'Available'", Db);
            SqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("room_id", typeof(int));
            data.Load(reader);
            Room_name.ValueMember = "room_id";
            Room_name.DataSource = data;
            Db.Close();
        }

        private void GetCustomers()
        {
            Db.Open();
            SqlCommand command = new SqlCommand("select * from Customer", Db);
            SqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("customer_id", typeof(int));
            data.Load(reader);
            Customer_name.ValueMember = "customer_id";
            Customer_name.DataSource = data;
            Db.Close();
        }

        int Price = 1;
        private void fetchCost()
        {
            Db.Open();
            SqlCommand command = new SqlCommand("select room_cost from Type join Room on room_type = Id where room_id=" + Room_name.SelectedValue.ToString() + "", Db);
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                Price = Convert.ToInt32(row["room_cost"].ToString());
            }
            Db.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (Booking_amount.Text == "")
            {
                Booking_amount.Text = "0 ₸";
            }
            else
            {
                try
                {
                    int Total = Price * Convert.ToInt32(Booking_duration.Text);
                    Booking_amount.Text = Total + "";
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            InsertBooking();
        }

        private void Room_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCost();
        }

        int Key = 0;
        private void BookingsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_name.Text = BookingsList.SelectedRows[0].Cells[1].Value.ToString();
            Customer_name.Text = BookingsList.SelectedRows[0].Cells[2].Value.ToString();
            Booking_date.Text = BookingsList.SelectedRows[0].Cells[3].Value.ToString();
            Booking_duration.Text = BookingsList.SelectedRows[0].Cells[4].Value.ToString();
            Booking_amount.Text = BookingsList.SelectedRows[0].Cells[5].Value.ToString();

            if (Room_name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BookingsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            CancelBooking();
        }

        private void setBooked()
        {
            try
            {
                Db.Open();
                SqlCommand cmd = new SqlCommand("update Room set room_status = @room_status where room_id = @room_id", Db);
                cmd.Parameters.AddWithValue("@room_status", "Booked");
                cmd.Parameters.AddWithValue("@room_id", Room_name.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                Db.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void setAvailable()
        {
            try
            {
                Db.Open();
                SqlCommand cmd = new SqlCommand("update Room set room_status = @room_status where room_id = @room_id", Db);
                cmd.Parameters.AddWithValue("@room_status", "Available");
                cmd.Parameters.AddWithValue("@room_id", Room_name.Text);
                cmd.ExecuteNonQuery();
                Db.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            Rooms ObjRoom = new Rooms();
            ObjRoom.Show();
            this.Hide();
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            Type ObjType = new Type();
            ObjType.Show();
            this.Hide();
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            Users ObjUsers = new Users();
            ObjUsers.Show();
            this.Hide();
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Customers ObjCustomers = new Customers();
            ObjCustomers.Show();
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
