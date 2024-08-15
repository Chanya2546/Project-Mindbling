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
    public partial class Form19 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form19()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            daysell.Hide();
            monthsell.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Daysell_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Daysell_Click(sender, e);
            monthsell_Click(sender, e);
            daysell.Show();
            monthsell.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
