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
    public partial class Form13 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form13()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Loadphoto();
        }

        public void SetData(string username)
        {
            Username.Text = username;

        }
        public void Loadphoto()
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT id_Product, Name, price_Product, Photo FROM listproduct WHERE id_Product LIKE 'S%'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idProduct = reader.GetString("id_Product");
                        string name = reader.GetString("Name");
                        string price = reader.GetString("price_Product");
                        byte[] photoBytes = (byte[])reader["Photo"];

                        // สร้าง Panel เพื่อเก็บข้อมูลทั้งหมด
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.FlowDirection = FlowDirection.TopDown;
                        panel.AutoSize = true;
                        panel.Margin = new Padding(30); // กำหนด Margin เพื่อเขยิบ Panel เข้ามากึ่งกลาง

                        // สร้าง PictureBox เพื่อแสดงรูปภาพ
                        PictureBox pictureBox = new PictureBox();
                        Image photo = Image.FromStream(new System.IO.MemoryStream(photoBytes));
                        pictureBox.Image = photo;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 440;
                        pictureBox.Height = 380;

                        // สร้าง Label สำหรับ Name
                        Label nameLabel = new Label();
                        nameLabel.Text = name;
                        nameLabel.AutoSize = true;
                        nameLabel.Font = new Font("Angsana New", 30, FontStyle.Regular); // กำหนดรูปแบบ font และขนาดของ Label
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter; // จัดตำแหน่งให้อยู่ตรงกลางของ PictureBox
                        nameLabel.Dock = DockStyle.Top; // ให้ Label อยู่ที่ด้านบนของ PictureBox

                        // สร้าง Label สำหรับ Price
                        Label priceLabel = new Label();
                        priceLabel.Text = "฿" + price.ToString();
                        priceLabel.AutoSize = true;
                        priceLabel.Font = new Font("Angsana New", 25, FontStyle.Regular); // กำหนดรูปแบบ font และขนาดของ Label
                        priceLabel.TextAlign = ContentAlignment.MiddleCenter; // จัดตำแหน่งให้อยู่ตรงกลางของ PictureBox
                        priceLabel.Dock = DockStyle.Bottom; // ให้ Label อยู่ที่ด้านล่างของ PictureBox

                        pictureBox.Click += (s, e) => PictureBox_Click(s, e, idProduct);

                        // เพิ่ม PictureBox, Name Label, และ Price Label เข้าไปใน Panel
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(priceLabel);

                        // เพิ่ม Panel ลงใน FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void PictureBox_Click(object sender, EventArgs e, string idProduct)
        {
            string username = Username.Text;
            Form9 form9 = new Form9();
            form9.SetData(idProduct, username);
            form9.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form2.SetData(username);
            form2.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}
