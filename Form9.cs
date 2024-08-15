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
using System.Xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EditMindTwinkle
{
    public partial class Form9 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form9()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        public void SetData(string idProduct,string username)
        {
            idproduct.Text = idProduct;
            Username.Text= username;

            showdata();
        }
        private void showdata()
        {
            string username=Username.Text;
            string id = idproduct.Text; // รับข้อมูลที่ป้อน

            // สร้าง DataTable เพื่อทำการค้นหา
            DataTable dataTable = new DataTable();

            // สร้าง DataColumn เพื่อทำการค้นหา
            DataColumn telColumn = new DataColumn("id_Product");
            dataTable.Columns.Add(telColumn);

            // เพิ่มข้อมูลจากฐานข้อมูลลงใน DataTable ด้วยการ query ฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM listproduct", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            DataRow[] foundRows = dataTable.Select("id_Product = '" + id + "'"); // ค้นหาข้อมูลในคอลัมนี้

            // ตรวจสอบว่าพบข้อมูลหรือไม่
            if (foundRows.Length > 0)
            {
                // ถ้าพบข้อมูล ให้นำข้อมูลในแถวนั้นไปแสดงใน textbox อื่น ๆ
                name.Text = foundRows[0]["Name"].ToString();
                detail.Text = foundRows[0]["Detail"].ToString();
                price.Text = foundRows[0]["price_Product"].ToString() + " บาท";
                quantity.Text = foundRows[0]["Quantity"].ToString() + " ชิ้น";
                Username.Text = username;

                byte[] photoBytes = (byte[])foundRows[0]["Photo"];
                Image photo = Image.FromStream(new System.IO.MemoryStream(photoBytes));
                show.Image = photo;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) //ย้อนกลับ
        {
            string idProduct = idproduct.Text;

            if (idProduct.StartsWith("N"))
            {
                string username =Username.Text;
                Form8 form8 = new Form8();
                form8.SetData(username);
                form8.Show();
            }
            else if (idProduct.StartsWith("B"))
            {
                string username = Username.Text;
                Form10 form10 = new Form10();
                form10.SetData(username);
                form10.Show();
            }
            else if (idProduct.StartsWith("E"))
            {
                string username = Username.Text;
                Form11 form11 = new Form11();
                form11.SetData(username);
                form11.Show();
            }
            else if (idProduct.StartsWith("R"))
            {
                string username = Username.Text;
                Form12 form12 = new Form12();
                form12.SetData(username);
                form12.Show();
            }
            else if (idProduct.StartsWith("S"))
            {
                string username = Username.Text;
                Form13 form13 = new Form13();
                form13.SetData(username);
                form13.Show();
            }

            this.Hide();
        }


        private void idproduct_Click(object sender, EventArgs e)
        {



        }

        private void Form9_Load(object sender, EventArgs e)
        {
            showdata();
            UpdateLabelWithRowCount();
            string user = Username.Text;
            Username.Text = user;

        }

        private void show_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e) //ปุ่มเพิ่ม
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string getCurrentDataQuery = "SELECT Name, Quantity,price_Product, Photo FROM listproduct WHERE id_Product = @idProduct";
            MySqlCommand getCurrentDataCmd = new MySqlCommand(getCurrentDataQuery, conn); 
            getCurrentDataCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
            MySqlDataReader reader = getCurrentDataCmd.ExecuteReader();
            if (reader.Read())
            {
                string productName = reader.GetString(0);
                int Quantity = reader.GetInt32(1);
                string priceProductStr = reader.GetString(2);
                priceProductStr = priceProductStr.Replace(",", ""); // ลบลูกน้ำออก
                double priceproduct = double.Parse(priceProductStr);

                byte[] photoBytes = (byte[])reader["Photo"];

                // สร้างรูปภาพจาก byte array
                Image photo;
                using (MemoryStream ms = new MemoryStream(photoBytes))
                {
                    photo = Image.FromStream(ms);
                }

                //ตัวเลขมากกว่า 0 ช่องต้องไม่ว่าง ต้องน้อยกว่าหรือเท่ากับจำนวนในสต็อก
                if (int.TryParse(Num.Text, out int numValue) && numValue > 0 && !string.IsNullOrWhiteSpace(Num.Text) && numValue <= Quantity)
                {

                    string checkTelQuery = "SELECT COUNT(*) FROM bill WHERE id_Product = @idproduct";
                    MySqlCommand checkTelCmd = new MySqlCommand(checkTelQuery, conn);
                    checkTelCmd.Parameters.AddWithValue("@idproduct", idproduct.Text);
                    reader.Close();
                    int existingCount = Convert.ToInt32(checkTelCmd.ExecuteScalar());

                    if (existingCount > 0) // ถ้ามี id ใน bill
                    {
                        //อัพเดตจำนวน
                        string updateQuery = "UPDATE bill SET Amount = Amount + @Num WHERE id_Product = @idProduct;";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Num", numValue);
                        updateCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                        updateCmd.ExecuteNonQuery();

                        //ดึงจำนวนจากบิลมาเก็บไว้
                        string getCurrentQuantityQuery = "SELECT Amount FROM bill WHERE id_Product = @idProduct;";
                        MySqlCommand getCurrentQuantityCmd = new MySqlCommand(getCurrentQuantityQuery, conn);
                        getCurrentQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                        int currentQuantity = Convert.ToInt32(getCurrentQuantityCmd.ExecuteScalar());

                        double all = currentQuantity * priceproduct;
                        string allprice = all.ToString("#,###");
                        //อัพเเดตราคา
                        string updateprice = "UPDATE bill SET Allprice = @allprice WHERE id_Product = @idProduct;";
                        MySqlCommand updatepriceCmd = new MySqlCommand(updateprice, conn);
                        updatepriceCmd.Parameters.AddWithValue("@allprice", allprice);
                        updatepriceCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                        updatepriceCmd.ExecuteNonQuery();

                        //อัพเดตจำนวนสต็อก
                        string updateQuantity = "UPDATE listproduct SET Quantity = @Quantity - @Num WHERE id_Product = @idProduct;";
                        MySqlCommand updateQuantityCmd = new MySqlCommand(updateQuantity, conn);
                        updateQuantityCmd.Parameters.AddWithValue("@Quantity", Quantity);
                        updateQuantityCmd.Parameters.AddWithValue("@Num", numValue);
                        updateQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                        updateQuantityCmd.ExecuteNonQuery();

                        //ดึงจำนวนจากสต็อกมาเก็บไว้และแสดง
                        showQ();
                        DialogResult result = MessageBox.Show("เพิ่มจำนวนสินค้าเข้าตะกร้าแล้ว\nคุณต้องการซื้อสินค้าอีกหรือไม่ ?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // ไปยังหน้า 2
                            string username = Username.Text;
                            Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
                            form2.SetData(username);
                            form2.Show(); // เปิดหน้าฟอร์ม
                            this.Hide();
                        }
                        else if (result == DialogResult.No)
                        {
                            // ไปยังหน้า 14 หน้าตะกร้า
                            string username = Username.Text;
                            Form14 form14 = new Form14();
                            form14.SetData(username);
                            form14.Show();
                            this.Hide();
                        }

                        conn.Close();

                    }
                    else //ถ้าไม่มี id ใน bill
                    {
                        double all = priceproduct * numValue;
                        string allprice = all.ToString("#,###");
                        string price_one = priceproduct.ToString("#,###");

                        string insertQuery = "INSERT INTO bill (id_Product, NameProduct, Amount, price_one_pc,Allprice,Photo) VALUES (@idProduct, @name, @Num, @price,@allprice,@photo);";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn); 
                        insertCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
                        insertCmd.Parameters.AddWithValue("@name", productName); 
                        insertCmd.Parameters.AddWithValue("@Num", numValue); 
                        insertCmd.Parameters.AddWithValue("@price", price_one);
                        insertCmd.Parameters.AddWithValue("@allprice", allprice);
                        insertCmd.Parameters.AddWithValue("@photo", photoBytes);
                        insertCmd.ExecuteNonQuery();

                        //อัพเดตจำนวนสต็อก
                        string updateQuantity = "UPDATE listproduct SET Quantity = @Quantity - @Num WHERE id_Product = @idProduct;";
                        MySqlCommand updateQuantityCmd = new MySqlCommand(updateQuantity, conn);
                        updateQuantityCmd.Parameters.AddWithValue("@Quantity", Quantity);
                        updateQuantityCmd.Parameters.AddWithValue("@Num", numValue);
                        updateQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                        updateQuantityCmd.ExecuteNonQuery();

                        showQ();
                        UpdateLabelWithRowCount();
                        DialogResult result = MessageBox.Show("หยิบสินค้าเข้าตะกร้าแล้ว\nคุณต้องการซื้อสินค้าอีกหรือไม่ ?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // ไปยังหน้า 2
                            string username = Username.Text;
                            Form2 form2 = new Form2(); // สร้างหน้าฟอร์มที่ต้องการเปิด
                            form2.SetData(username);
                            form2.Show(); // เปิดหน้าฟอร์ม
                            this.Hide();
                        }
                        else if (result == DialogResult.No)
                        {
                            // ไปยังหน้า 14
                            string username = Username.Text;
                            Form14 form14 = new Form14();
                            form14.SetData(username);
                            form14.Show();
                            this.Hide();
                        }

                    }
                }
                else //มีค่าว่าง เลขติดลบ เลขมากกว่าสต็อก
                {
                    MessageBox.Show("จำนวนไม่เพียงพอหรือมีข้อผิดพลาด", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void showQ()//ดึงจำนวนสต็อกมาแสดง
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string getquantitystock = "SELECT Quantity FROM listproduct WHERE id_Product = @idProduct;";
            MySqlCommand getquantitystockCmd = new MySqlCommand(getquantitystock, conn);
            getquantitystockCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            int getQ = Convert.ToInt32(getquantitystockCmd.ExecuteScalar());

            quantity.Text = getQ.ToString()+" ชิ้น";
            conn.Close();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            string username=Username.Text;
            Form14 form14 = new Form14(); // หน้าตะกร้า
            form14.SetData(username);
            form14.Show(); 
            this.Hide();
        }

        private void UpdateLabelWithRowCount() //ดึงจำนวนรายการสินค้าที่มีอยู่ในบิลมาแสดง
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM bill", conn);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            label1.Text = rowCount.ToString();
        }

        private void detail_Click(object sender, EventArgs e)
        {

        }
    }
}
