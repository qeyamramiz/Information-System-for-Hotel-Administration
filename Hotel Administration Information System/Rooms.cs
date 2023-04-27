using System.CodeDom;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Administration_Information_System
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            ShowRooms();
            GetCategories();
        }

        SqlConnection Db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samim Qeya\Documents\HotelManagementDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ShowRooms()
        {
            Db.Open();
            string showQuery = "select * from Room";
            SqlDataAdapter sda = new SqlDataAdapter(showQuery, Db);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            RoomsList.DataSource = dataset.Tables[0];
            Db.Close();
        }

        private void DeleteRoom()
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a room to delete.");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand("delete from Room where room_id = @room_id", Db);
                    cmd.Parameters.AddWithValue("@room_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room was deleted successfully!");
                    Db.Close();
                    ShowRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditRoom()
        {
            if (room_name.Text == "" || room_type.SelectedIndex == -1 || room_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand(
                        "update Room set room_name = @room_name, room_type = @room_type, room_status = @room_status where room_id = @room_id"
                    , Db);
                    cmd.Parameters.AddWithValue("@room_name", room_name.Text);
                    cmd.Parameters.AddWithValue("@room_type", room_type.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@room_status", room_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@room_id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room was updated successfully!");
                    Db.Close();
                    ShowRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void InsertRooms()
        {
            if (room_name.Text == "" || room_type.SelectedIndex == -1 || room_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Db.Open();
                    SqlCommand cmd = new SqlCommand(
                        "insert into Room(room_name, room_type, room_status) values(@room_name, @room_type, @room_status)"
                    , Db);
                    cmd.Parameters.AddWithValue("@room_name", room_name.Text);
                    cmd.Parameters.AddWithValue("@room_type", room_type.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@room_status", "Available");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room was added successfully!");
                    Db.Close();
                    ShowRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetCategories()
        {
            Db.Open();
            SqlCommand command = new SqlCommand("select * from Type", Db);
            SqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("Id", typeof(int));
            data.Load(reader);
            room_type.ValueMember = "Id";
            room_type.DataSource = data;
            Db.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }

        int Key = 0;
        private void RoomsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_name.Text = RoomsList.SelectedRows[0].Cells[1].Value.ToString();
            room_type.Text = RoomsList.SelectedRows[0].Cells[2].Value.ToString();
            room_status.Text = RoomsList.SelectedRows[0].Cells[3].Value.ToString();

            if (room_name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RoomsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            EditRoom();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            /*Type TypeObject = new Type();
            TypeObject.Show();
            this.Hide();*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            /*Rooms RoomObject = new Rooms();
            RoomObject.Show();
            this.Hide();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Type ObjType = new Type();
            ObjType.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Users ObjUser = new Users();
            ObjUser.Show();
            this.Hide();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Customers ObjCustomer = new Customers();
            ObjCustomer.Show();
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Bookings ObjBookings = new Bookings();
            ObjBookings.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show();
            this.Hide();
        }
    }
}