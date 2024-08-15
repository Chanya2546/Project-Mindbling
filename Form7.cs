using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;



namespace EditMindTwinkle
{
    public partial class Form7 : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) //ปุ่มเพิ่มสินค้า
        {
            MySqlConnection conn = databaseConnection();

            // ตรวจสอบว่ามีข้อมูลในคอลัมน์ id_Product ตรงกับค่าที่รับเข้ามาหรือไม่
            string checkExistingQuery = "SELECT COUNT(*) FROM listproduct WHERE id_Product = @idProduct";
            MySqlCommand checkExistingCmd = new MySqlCommand(checkExistingQuery, conn);
            checkExistingCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);

            conn.Open();
            int existingCount = Convert.ToInt32(checkExistingCmd.ExecuteScalar());
            conn.Close();
            //มี id ในลิสแล้ว
            if (existingCount > 0)
            {   //ไม่ว่าง เป็นตัวเลข เลขนั้นมากกว่า0
                if (!string.IsNullOrEmpty(Num.Text) && Num.Text.All(char.IsDigit) && int.Parse(Num.Text) > 0)
                {
                    
                    // มีข้อมูลอยู่แล้ว ให้ทำการอัปเดตจำนวน Quantity
                    string updateQuery = "UPDATE listproduct SET Quantity = Quantity + @quantity WHERE id_Product = @idProduct";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@quantity", Num.Text);
                    updateCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);

                    conn.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("เพิ่มสินค้าสำเร็จ");
                        showStock();
                        idproduct.Text = string.Empty;
                        NameProduct.Text = string.Empty;
                        detail.Text = string.Empty;
                        price.Text = string.Empty;
                        Num.Text = string.Empty;
                        show.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("มีข้อผิดพลาดในการอัปเดตจำนวนสินค้า");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอก Quantity เป็นตัวเลขเต็มบวกเท่านั้น");
                }
                    
            }
            //ยังไม่มี id
            else
            {
                if (!string.IsNullOrWhiteSpace(idproduct.Text) && !string.IsNullOrWhiteSpace(NameProduct.Text) && !string.IsNullOrWhiteSpace(detail.Text) && !string.IsNullOrWhiteSpace(Num.Text) && !string.IsNullOrWhiteSpace(price.Text) && show.Image != null)
                {
                    // ไม่มีข้อมูล ให้ทำการเพิ่มข้อมูลใหม่
                    string insertQuery = "INSERT INTO listproduct (id_Product, Name, Detail, Quantity, price_Product, Photo) VALUES (@idProduct, @name, @detail, @quantity, @price, @photo)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                    insertCmd.Parameters.AddWithValue("@name", NameProduct.Text);
                    insertCmd.Parameters.AddWithValue("@detail", detail.Text);
                    insertCmd.Parameters.AddWithValue("@quantity", Num.Text);
                    insertCmd.Parameters.AddWithValue("@price", price.Text);

                    // เพิ่มรูปภาพจาก PictureBox ลงในตาราง
                    byte[] photoBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        show.Image.Save(ms, ImageFormat.Jpeg);
                        photoBytes = ms.ToArray();
                    }
                    insertCmd.Parameters.AddWithValue("@photo", photoBytes);

                    conn.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("เพิ่มสินค้าใหม่เรียบร้อยแล้ว");
                        showStock();
                        idproduct.Text = string.Empty;
                        NameProduct.Text = string.Empty;
                        detail.Text = string.Empty;
                        price.Text = string.Empty;
                        Num.Text = string.Empty;
                        show.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("มีข้อผิดพลาดในการเพิ่มสินค้าใหม่");
                    }
                }
                else
                {
                    MessageBox.Show("มีค่าว่างหรือมีข้อผิดพลาดในข้อมูลที่นับมา");
                }
         
            }
        }




        private void label_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form3.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }




        private void select_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // ตั้งค่าสำหรับ OpenFileDialog
            openFileDialog1.Title = "Select Image";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // เมื่อเลือกไฟล์ภาพแล้ว
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // แสดงภาพที่เลือกใน PictureBox
                    show.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open file. Original error: " + ex.Message);
                }
            }
        }

        private void showStock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd ;

            cmd=conn.CreateCommand();
            cmd.CommandText="SELECT * FROM listproduct";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            Stock.DataSource= ds.Tables[0].DefaultView;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            showStock();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int quantityToDecrease = Convert.ToInt32(Num.Text); // จำนวนที่ต้องการลด

            // ตรวจสอบว่ามีข้อมูลในคอลัมน์ id_Product ตรงกับค่าที่รับเข้ามาหรือไม่
            MySqlConnection conn = databaseConnection();
            string checkExistingQuery = "SELECT COUNT(*) FROM listproduct WHERE id_Product = @idProduct";
            MySqlCommand checkExistingCmd = new MySqlCommand(checkExistingQuery, conn);
            checkExistingCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);

            conn.Open();
            int existingCount = Convert.ToInt32(checkExistingCmd.ExecuteScalar());
            conn.Close();

            if (existingCount > 0)
            {
                // ดึงจำนวนที่อยู่ในคอลัมน์ Quantity
                conn.Open();
                string getCurrentQuantityQuery = "SELECT Quantity FROM listproduct WHERE id_Product = @idProduct";
                MySqlCommand getCurrentQuantityCmd = new MySqlCommand(getCurrentQuantityQuery, conn);
                getCurrentQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                int currentQuantity = Convert.ToInt32(getCurrentQuantityCmd.ExecuteScalar());
                conn.Close();

                if (currentQuantity > quantityToDecrease)
                {
                    // ทำการลดจำนวน Quantity
                    string updateQuery = "UPDATE listproduct SET Quantity = Quantity - @quantity WHERE id_Product = @idProduct";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@quantity", quantityToDecrease);
                    updateCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);

                    conn.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        
                        MessageBox.Show("ลดจำนวนสต็อกสำเร็จ");
                        showStock();
                        idproduct.Text = string.Empty;
                        NameProduct.Text = string.Empty;
                        detail.Text = string.Empty;
                        price.Text = string.Empty;
                        Num.Text = string.Empty;
                        show.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("มีข้อผิดพลาดในการลดสินค้า");
                    }
                }
                else
                {
                    string updateQuery = "DELETE FROM listproduct WHERE id_Product = @idProduct";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                    showStock();

                }
            }
            else
            {
                MessageBox.Show("ไม่มีรหัสสินค้านี้ใน Stock");
            }
        }

        private void Stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Stock.CurrentRow.Selected = true;

            // ดึงรูปภาพจากคอลัมน์ "Photo" ในแถวที่เลือก
            byte[] imgData = (byte[])Stock.Rows[e.RowIndex].Cells["Photo"].Value;

            // แปลงข้อมูลรูปภาพจาก byte array เป็น MemoryStream
            MemoryStream ms = new MemoryStream(imgData);

            // แสดงรูปภาพใน PictureBox
            show.Image = Image.FromStream(ms);

            idproduct.Text = Stock.Rows[e.RowIndex].Cells["id_Product"].FormattedValue.ToString();
            NameProduct.Text = Stock.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            detail.Text = Stock.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();
            Num.Text = Stock.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
            price.Text = Stock.Rows[e.RowIndex].Cells["price_Product"].FormattedValue.ToString();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าทุกช่องใน TextBox มีข้อมูลไม่เป็นช่องว่างหรือไม่
            if (!string.IsNullOrWhiteSpace(idproduct.Text) && !string.IsNullOrWhiteSpace(NameProduct.Text) && !string.IsNullOrWhiteSpace(detail.Text) && !string.IsNullOrWhiteSpace(Num.Text) && !string.IsNullOrWhiteSpace(price.Text) && show.Image != null && Num.Text.All(char.IsDigit) && int.Parse(Num.Text) > 0)
            {
                MySqlConnection conn = databaseConnection();

                // กรณีไม่มีช่องว่างให้ทำ
                string insertQuery = "UPDATE  listproduct SET Name=@name, Detail=@detail, Quantity=@quantity, price_Product=@price, Photo=@photo WHERE id_Product =@idproduct";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                insertCmd.Parameters.AddWithValue("@name", NameProduct.Text);
                insertCmd.Parameters.AddWithValue("@detail", detail.Text);
                insertCmd.Parameters.AddWithValue("@quantity", Num.Text);
                insertCmd.Parameters.AddWithValue("@price", price.Text);

                // เพิ่มรูปภาพจาก PictureBox ลงในตาราง
                byte[] photoBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    show.Image.Save(ms, ImageFormat.Jpeg);
                    photoBytes = ms.ToArray();
                }
                insertCmd.Parameters.AddWithValue("@photo", photoBytes);

                conn.Open();
                int rowsAffected = insertCmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    showStock();
                    idproduct.Text = string.Empty;
                    NameProduct.Text = string.Empty;
                    detail.Text = string.Empty;
                    price.Text = string.Empty;
                    Num.Text = string.Empty;
                    show.Image = null;
                }
                else
                {
                    MessageBox.Show("มีข้อผิดพลาดในการลดสินค้า");
                }

            }
            else
            {
                MessageBox.Show(",มีค่าว่างหรือมีความผิดพลาดจากข้อมูลที่รับมา", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
