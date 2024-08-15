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
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e) //ปุ่มcustomer
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string sql = @" CREATE TABLE IF NOT EXISTS Bill ( id INTEGER PRIMARY KEY AUTO_INCREMENT, id_Product CHAR(5),NameProduct CHAR(100), Amount CHAR(4), price_one_pc CHAR(10), Allprice CHAR(10),Photo LONGBLOB)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // ประมวลผลคำสั่ง SQL
            cmd.ExecuteNonQuery();

            // ปิดการเชื่อมต่อ
            conn.Close();
            Form21 form21 = new Form21(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form21.Show(); // เปิดหน้าฟอร์ม
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e) //ปุ่มกากบาท
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e) //ปุ่ม Admin
        {

            Form6 form6 = new Form6(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form6.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }
    }
}
