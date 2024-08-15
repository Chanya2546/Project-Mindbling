using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EditMindTwinkle
{
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            string user = Username.Text;
            label1.Hide();
            label4.Hide();
            showuser();
        }
        public void SetData(string username)
        {
            Username.Text = username;

        }
        private void showuser()
        {
            string user=Username.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click_1(object sender, EventArgs e) //ไปหน้าสมัครสมาชิก
        {
            Form4 form4 = new Form4(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form4.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) //ไปหน้าดูข้อมูลสมาชิก
        {
            string username = Username.Text;

            Form5 form5 = new Form5(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form5.SetData(username);
            form5.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void N_Click(object sender, EventArgs e) //สร้อยคอ
        {
            string username = Username.Text;
            Form8 form8 = new Form8();
            form8.SetData(username);
            form8.Show();
            this.Hide();
        }

        private void B_Click(object sender, EventArgs e) //สร้อยข้อมือ
        {
            string username = Username.Text;
            Form10 form10 = new Form10();
            form10.SetData(username);
            form10.Show();
            this.Hide();
        }

        private void E_Click(object sender, EventArgs e) //ต่างหู
        {
            string username = Username.Text;
            Form11 form11 = new Form11();
            form11.SetData(username);
            form11.Show();
            this.Hide();
        }

        private void R_Click(object sender, EventArgs e) //แหวน
        {
            string username = Username.Text;
            Form12 form12 = new Form12();
            form12.SetData(username);
            form12.Show();
            this.Hide();
        }

        private void S_Click(object sender, EventArgs e) //เซ็ต
        {
            string username = Username.Text;
            Form13 form13 = new Form13();
            form13.SetData(username);
            form13.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e) 
        {

            MySqlConnection conn = databaseConnection();
            conn.Open();
            string sql = @" CREATE TABLE IF NOT EXISTS Bill ( id INTEGER PRIMARY KEY AUTO_INCREMENT, id_Product CHAR(5),NameProduct CHAR(100), Amount CHAR(4), price_one_pc CHAR(10), Allprice CHAR(10),Photo LONGBLOB)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // ประมวลผลคำสั่ง SQL
            cmd.ExecuteNonQuery();

            // ปิดการเชื่อมต่อ
            conn.Close();
            string user = Username.Text;
        }

        private void label3_Click(object sender, EventArgs e) //ไปหน้าดูคำสั่งซื้อ
        {
            string username = Username.Text;
            Form17 form17 = new Form17();
            form17.SetData(username);
            form17.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e) //ไปหน้ายกเลิกออร์เดอร์
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
            this.Hide();

            MySqlConnection conn = databaseConnection();
            conn.Open();
            string dropTableQuery = "DROP TABLE IF EXISTS Bill;";
            MySqlCommand dropTableCmd = new MySqlCommand(dropTableQuery, conn);
            dropTableCmd.ExecuteNonQuery();
        }
    }
}
