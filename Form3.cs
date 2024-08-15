using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditMindTwinkle
{
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label8.Show();
            label2.Hide();
            daysell.Hide();
            monthsell.Hide();
            search.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form7.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form1.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e) //โชว์ออร์เดอร์
        {
            search.Hide();
            label8.Hide();
            dateTimePicker1.Show();
            dateTimePicker2.Hide();
            showdata.DataSource = null;
            showorder();
        }
        private void showorder() //โชว์ตารางออรืเดอร์
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM summary";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            showdata.DataSource = ds.Tables[0].DefaultView;
        }

        private void label4_Click(object sender, EventArgs e) //โชว์รายการที่ยกเลิก
        {
            search.Hide();
            label8.Show();
            dateTimePicker1.Hide();
            dateTimePicker2.Show();
            showdata.DataSource = null;
            showcancel();
        }
        private void showcancel()
        {
            MySqlConnection conn = databaseConnection(); //โชว์ตารางยกเลิก
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ordercancel";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            showdata.DataSource = ds.Tables[0].DefaultView;
        }

        private void label5_Click(object sender, EventArgs e) //โชว์ข้อมูลสมาชิก
        {
            label8.Show();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            showdata.DataSource = null;
            showmember();
        }
        private void showmember() //โชว์ตารางข้อมูลสมาชิก
        {
            search.Show();
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM member";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            showdata.DataSource = ds.Tables[0].DefaultView;
        }

        private void label2_Click(object sender, EventArgs e) 
        {
            Form19 form19 = new Form19(); //หน้ายอดขาย
            form19.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20(); //หน้าผู้พัฒนา
            form20.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();

        }

        private void ShowSelectedDateSummary() //ของดูคำสั่งซื้อ
        {
            string selectedDate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string connectionString = "server=localhost;user id=root;password=;database=mindbling;";
            string query = "SELECT * FROM summary WHERE DATE(date) = @selectedDate";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    showdata.DataSource = dataTable;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //ของดูคำสั่งซื้อ
        {
            ShowSelectedDateSummary();
            daysell_Click(sender, e);
            monthsell_Click(sender, e);
            daysell.Show();
            monthsell.Show();
        }

        private void ShowSelectedDateCancel() //ของดูคำสั่งซื้อที่ยกเลิก
        {
            string selectedDate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            string connectionString = "server=localhost;user id=root;password=;database=mindbling;";
            string query = "SELECT * FROM ordercancel WHERE DATE(date) = @selectedDate";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    showdata.DataSource = dataTable;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) //ของดูคำสั่งซื้อที่ยกเลิก
        {
            ShowSelectedDateCancel();

        }

        private void showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void daysell_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=mindbling;";
            string query = "SELECT SUM(REPLACE(AllPrice, ',', '')) FROM summary WHERE DATE(date) = @selectDate";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectDate", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        // แสดงข้อมูลโดยเพิ่มเครื่องหมาย ',' ระหว่างจำนวนทุก 3 ตัว
                        daysell.Text = Convert.ToDecimal(result).ToString("#,###.##") + " Bath";
                    }
                    else
                    {
                        daysell.Text = "0 Bath";
                    }
                }
            }
        }

        private void monthsell_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=mindbling;";
            string query = "SELECT SUM(REPLACE(AllPrice, ',', '')) FROM summary WHERE YEAR(date) = YEAR(@selectDate) AND MONTH(date) = MONTH(@selectDate)";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectDate", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        // แสดงข้อมูลโดยเพิ่มเครื่องหมาย ',' ระหว่างจำนวนทุก 3 ตัว
                        monthsell.Text = Convert.ToDecimal(result).ToString("#,###.##") + " Bath";
                    }
                    else
                    {
                        monthsell.Text = "0 Bath";
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim(); // ข้อความที่ใส่เข้ามาในช่องค้นหา
            if (searchText != "")
            {
                using (MySqlConnection conn = databaseConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM member WHERE Username LIKE @searchText OR Name LIKE @searchText OR Tel LIKE @searchText";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // กำหนดให้ DataGridView แสดงข้อมูลที่ค้นหาได้
                    showdata.DataSource = dataTable;
                }
            }
            else
            {
                // ถ้าไม่มีข้อความในช่องค้นหาให้เรียกใช้ฟังก์ชัน ShowData() อีกครั้ง
                showmember();
            }
        }
    }
}
