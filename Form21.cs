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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EditMindTwinkle
{
    public partial class Form21 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form21()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void create_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

      
        private void signin_Click(object sender, EventArgs e) //ปุ่ม signin
        {
            MySqlConnection conn = databaseConnection();
            string username = Username.Text;
            // เช็คว่า user มีอยู่ในตาราง member หรือไม่
            MySqlCommand checkuserCmd = new MySqlCommand("SELECT COUNT(*) FROM member WHERE Username = @username", conn);
            checkuserCmd.Parameters.AddWithValue("@username", Username.Text);
            conn.Open();
            int memberuserCount = Convert.ToInt32(checkuserCmd.ExecuteScalar());
            conn.Close();
            if (memberuserCount > 0)
            {
                //ให้เช็คว่า Pass ที่พิมเข้ามาตรงกับ Username ที่รับเข้ามามั้ย
                MySqlCommand checkPasswordCmd = new MySqlCommand("SELECT Password FROM member WHERE Username = @username", conn);
                checkPasswordCmd.Parameters.AddWithValue("@username", Username.Text);
                conn.Open();
                string storedPassword = checkPasswordCmd.ExecuteScalar() as string;
                conn.Close();

                if (storedPassword != null && storedPassword.Equals(Password.Text))
                {

                    MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                    Form2 form2 = new Form2();
                    form2.SetData(username);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    // รหัสผ่านไม่ถูกต้อง
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
                }

            }
            else
            {
                // user นี้ไม่มีอยู่ในระบบ
                MessageBox.Show(" Username นี้ยังไม่ได้เป็นสมัครสมาชิก");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form21_Load(object sender, EventArgs e)
        {
            see.Hide();
        }

        private void nonsee_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = false; //ให้เห็น
            see.Show();
            nonsee.Hide();
        }

        private void see_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true; //ไม่ให้เห็น
            nonsee.Show();
            see.Hide() ;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
