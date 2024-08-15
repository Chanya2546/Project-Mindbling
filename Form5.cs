using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EditMindTwinkle
{
    public partial class Form5 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public void SetData(string username)
        {
            Username.Text = username;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void SAVE_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าข้อมูลถูกกรอกครบหรือไม่
            if (!string.IsNullOrWhiteSpace(NameText.Text) &&
                !string.IsNullOrWhiteSpace(TelText.Text) &&
                !string.IsNullOrWhiteSpace(Username.Text) &&
                !string.IsNullOrWhiteSpace(Password.Text) &&
                !string.IsNullOrWhiteSpace(AddText.Text) &&
                !string.IsNullOrWhiteSpace(EmailText.Text))
            {
                // ตรวจสอบว่าเบอร์มี 10 ตัวและไม่มีตัวหนังสือ
                if (TelText.Text.Length == 10 && TelText.Text.All(char.IsDigit))
                {
                    MySqlConnection conn = databaseConnection();

                    // ตรวจสอบว่าเบอร์โทรศัพท์ถูกเปลี่ยนแปลงหรือไม่
                    string originalTel = GetOriginalTel(); // ฟังก์ชันนี้ควรจะคืนค่าเบอร์โทรศัพท์ที่เป็นเดิม
                    if (TelText.Text != originalTel)
                    {
                        // ตรวจสอบว่าเบอร์โทรศัพท์ซ้ำหรือไม่
                        if (IsTelExist(TelText.Text))
                        {
                            MessageBox.Show("เบอร์โทรศัพท์นี้ถูกใช้งานแล้ว", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ตรวจสอบความปลอดภัยของรหัสผ่าน
                    if (Password.Text.Length >= 8 && !Password.Text.All(char.IsDigit) && Regex.IsMatch(Password.Text, @"^[a-zA-Z0-9]+$"))
                    {
                        // ทำการอัพเดทข้อมูล
                        String sql = "UPDATE member SET Tel = @tel,Name = @name, Address = @address, Username = @username, Password = @password, Email = @email WHERE id_Member = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@tel", TelText.Text);
                        cmd.Parameters.AddWithValue("@name", NameText.Text);
                        cmd.Parameters.AddWithValue("@address", AddText.Text);
                        cmd.Parameters.AddWithValue("@username", Username.Text);
                        cmd.Parameters.AddWithValue("@password", Password.Text);
                        cmd.Parameters.AddWithValue("@email", EmailText.Text);
                        cmd.Parameters.AddWithValue("@id", id_member.Text);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            string username = Username.Text;
                            MessageBox.Show("แก้ไขข้อมูลแล้ว");

                            Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
                            form2.SetData(username);
                            form2.Show(); // เปิดหน้าฟอร์ม
                            this.Hide();
                        }
                    }
                    else
                    {
                        // เตือนเมื่อรหัสผ่านไม่ปลอดภัย
                        MessageBox.Show("โปรดใส่รหัสผ่านที่ปลอดภัยมากกว่า 8 ตัวและมีตัวอักษรภาษาอังกฤษผสม", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // เตือนเมื่อเบอร์โทรศัพท์ไม่ถูกต้อง
                    MessageBox.Show("โปรดกรอกเบอร์โทรศัพท์ที่ถูกต้อง (ต้องมี 10 ตัวและไม่มีตัวอักษร)", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // เตือนเมื่อข้อมูลไม่ครบ
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ฟังก์ชันสำหรับเช็คว่ามีเบอร์โทรศัพท์นี้ในฐานข้อมูลหรือไม่
        private bool IsTelExist(string tel)
        {
            MySqlConnection conn = databaseConnection();
            String checkTelQuery = "SELECT COUNT(*) FROM member WHERE Tel = @tel";
            MySqlCommand checkTelCmd = new MySqlCommand(checkTelQuery, conn);
            checkTelCmd.Parameters.AddWithValue("@tel", tel);
            conn.Open();
            int existingTelCount = Convert.ToInt32(checkTelCmd.ExecuteScalar());
            conn.Close();

            return existingTelCount > 0;
        }

        // ฟังก์ชันสำหรับดึงเบอร์โทรศัพท์เดิมจากฐานข้อมูล
        private string GetOriginalTel()
        {
            MySqlConnection conn = databaseConnection();
            string originalTel = "";

            // ตัวอย่างเท่านั้น คุณต้องแก้ไขตามโครงสร้างของฐานข้อมูลของคุณ
            String selectOriginalTelQuery = "SELECT Tel FROM member WHERE id_Member = @id";
            MySqlCommand selectOriginalTelCmd = new MySqlCommand(selectOriginalTelQuery, conn);
            selectOriginalTelCmd.Parameters.AddWithValue("@id", id_member.Text);
            conn.Open();
            MySqlDataReader reader = selectOriginalTelCmd.ExecuteReader();
            if (reader.Read())
            {
                originalTel = reader["Tel"].ToString();
            }
            conn.Close();

            return originalTel;
        }


        private void ShowMember()
        {
            string user = Username.Text;// รับข้อมูลที่ป้อน

            // สร้าง DataTable เพื่อทำการค้นหา
            DataTable dataTable = new DataTable();

            // สร้าง DataColumn เพื่อทำการค้นหา
            DataColumn UserColumn = new DataColumn("Username");
            dataTable.Columns.Add(UserColumn);

            // เพิ่มข้อมูลจากฐานข้อมูลลงใน DataTable ด้วยการ query ฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM member", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            DataRow[] foundRows = dataTable.Select("Username = '" + user + "'"); // ค้นหาข้อมูลในคอลัมนี้

            // ตรวจสอบว่าพบข้อมูลหรือไม่
            if (foundRows.Length > 0)
            {
                // ถ้าพบข้อมูล ให้นำข้อมูลในแถวนั้นไปแสดงใน textbox อื่น ๆ
                id_member.Text = foundRows[0]["id_Member"].ToString();
                NameText.Text = foundRows[0]["Name"].ToString();
                Username.Text = foundRows[0]["Username"].ToString();
                Password.Text = foundRows[0]["Password"].ToString();
                TelText.Text = foundRows[0]["Tel"].ToString();
                EmailText.Text = foundRows[0]["Email"].ToString();
                AddText.Text = foundRows[0]["Address"].ToString();
             
            }

        }


        private void TelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ShowMember();

        }
    }
}
