using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EditMindTwinkle
{
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form2.SetData(username);
            form2.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //SAVE
        {
            
            // ตรวจสอบว่าข้อมูลไม่ว่างเปล่าทั้งหมด
            if (!string.IsNullOrEmpty(NameText.Text) && !string.IsNullOrEmpty(TelText.Text) && !string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text) && !string.IsNullOrEmpty(EmailText.Text) && !string.IsNullOrEmpty(textBox.Text)  && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {
                //เบอร์10ตัวและไม่เป็นตัว นส
                if (TelText.Text.Length == 10 && TelText.Text.All(char.IsDigit))
                {
                    MySqlConnection conn = databaseConnection();

                    // เช็คว่าเบอร์โทรศัพท์มีอยู่ในตาราง member หรือไม่
                    MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM member WHERE Tel = @tel", conn);
                    checkCmd.Parameters.AddWithValue("@tel", TelText.Text);
                    conn.Open();
                    int memberCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    conn.Close();

                    if (memberCount > 0)
                    {
                        // เบอร์โทรศัพท์นี้มีอยู่ในระบบแล้ว
                        MessageBox.Show("เบอร์โทรศัพท์นี้มีอยู่ในระบบแล้ว");
                    }
                    else
                    {
                        // เช็คว่า user มีอยู่ในตาราง member หรือไม่
                        MySqlCommand checkuserCmd = new MySqlCommand("SELECT COUNT(*) FROM member WHERE Username = @username", conn);
                        checkuserCmd.Parameters.AddWithValue("@username", Username.Text);
                        conn.Open();
                        int memberuserCount = Convert.ToInt32(checkuserCmd.ExecuteScalar());
                        conn.Close();
                        if (memberuserCount > 0)
                        {
                            // user นี้มีอยู่ในระบบแล้ว
                            MessageBox.Show(" Username นี้ถูกใช้ไปแล้ว\nกรุณาเปลี่ยน username");
                        }
                        else
                        {
                            if (Password.Text.Length >= 8 && !Password.Text.All(char.IsDigit) && Regex.IsMatch(Password.Text, @"^[a-zA-Z0-9]+$"))
                            {
                                string address = string.Concat(textBox.Text, " ", textBox2.Text, " ", textBox3.Text, " ", textBox4.Text, " ", textBox5.Text, " ", textBox6.Text);
                                // เบอร์โทรศัพท์นี้ยังไม่มีในระบบ ทำการเพิ่มข้อมูล
                                string sql = "INSERT INTO member (Username,Password,Name, Tel, Address, Email) VALUES (@user,@pass,@name, @tel, @address, @email)";
                                MySqlCommand cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@user", Username.Text);
                                cmd.Parameters.AddWithValue("@pass", Password.Text);
                                cmd.Parameters.AddWithValue("@name", NameText.Text);
                                cmd.Parameters.AddWithValue("@tel", TelText.Text);
                                cmd.Parameters.AddWithValue("@address", address);
                                cmd.Parameters.AddWithValue("@email", EmailText.Text);


                                conn.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                conn.Close();

                                if (rowsAffected > 0)
                                {
                                    // กรณีที่มีข้อมูลถูกเพิ่มเข้าไปในฐานข้อมูล
                                    MessageBox.Show("สมัครสมาชิกแล้ว");
                                    Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
                                    string username = Username.Text;
                                    form2.SetData(username);
                                    form2.Show(); // เปิดหน้าฟอร์ม
                                    this.Hide();
                                }
                                else
                                {
                                    // กรณีที่ไม่สามารถเพิ่มข้อมูลได้
                                    MessageBox.Show("มีปัญหาในการเพิ่มข้อมูลลองอีกครั้ง");
                                }
                            }
                            else
                            {
                                MessageBox.Show("กรุณากรอกรหัสมากกว่า 8 ตัว และมีตัวอักษรภาษาอังกฤษด้วย");

                            }

                        }
                       
                    }
                }
                else
                {
                    // กรณีที่จำนวนเลขที่รับเข้ามาไม่ครบ 10 ตัวหรือมีตัวอักษร
                    MessageBox.Show("กรุณากรอกเบอร์โทรเป็นตัวเลขจำนวน 10 ตัว เท่านั้น");
                }
            }
            else
            {
                // กรณีที่ข้อมูลไม่ครบถ้วน
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
