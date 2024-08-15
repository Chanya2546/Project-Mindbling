using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EditMindTwinkle
{
    public partial class Form14 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form14()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           

        }

        public void SetData( string username)
        {
            Username.Text = username;

        }
        private void showbill() //แสดงตาราง
        {

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_Product, NameProduct, Amount, price_one_pc,Allprice,Photo FROM bill";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            bill.DataSource = ds.Tables[0].DefaultView;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            showbill();
            Caltatal();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string username=Username.Text; 
            Form2 form2 = new Form2();
            form2.SetData(username);
            form2.Show();
            this.Hide();
        }

        

        private void bill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billcheek(object sender, DataGridViewCellEventArgs e) //กดเลือกแถวแล้วไปแสดงข้อมูล
        {
            bill.CurrentRow.Selected = true;

            // ดึงรูปภาพจากคอลัมน์ "Photo" ในแถวที่เลือก
            byte[] imgData = (byte[])bill.Rows[e.RowIndex].Cells["Photo"].Value;

            // แปลงข้อมูลรูปภาพจาก byte array เป็น MemoryStream
            MemoryStream ms = new MemoryStream(imgData);

            // แสดงรูปภาพใน PictureBox
            show.Image = Image.FromStream(ms);

            idproduct.Text = bill.Rows[e.RowIndex].Cells["id_Product"].FormattedValue.ToString();
            name.Text = bill.Rows[e.RowIndex].Cells["NameProduct"].FormattedValue.ToString();
            Num.Text = bill.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
        }

        private void show_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e) //เพิ่มสินค้า
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string getCurrentDataQuery = "SELECT Name, Quantity, price_Product,Photo FROM listproduct WHERE id_Product = @idProduct";
            MySqlCommand getCurrentDataCmd = new MySqlCommand(getCurrentDataQuery, conn); getCurrentDataCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
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

                        MessageBox.Show("เพิ่มจำนวนสินค้าแล้ว");
                        showbill();
                        Caltatal();
                        show.Image = null; // เซ็ตรูปภาพให้ว่าง
                        idproduct.Text = ""; // เซ็ตข้อความในช่อง idproduct เป็นว่าง
                        name.Text = ""; // เซ็ตข้อความในช่อง name เป็นว่าง
                        Num.Text = ""; // เซ็ตข้อความในช่อง Num เป็นว่าง

                        conn.Close();

                    }
                }  
                //ไม่เป็นตัวนส รับมามากกว่า 0 แต่มากกว่าสต็อก
                else if((int.TryParse(Num.Text, out int numValue2) && numValue2 > 0 && !string.IsNullOrWhiteSpace(Num.Text) && numValue2 > Quantity))
                {
                    MessageBox.Show("จำนวนสินค้าไม่เพียงพอ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
                else 
                {
                    MessageBox.Show("ข้อผิดพลาดจากการรับข้อมูล", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void minus_Click(object sender, EventArgs e) //ลบสินค้า
        {
            MySqlConnection conn = databaseConnection(); 
            conn.Open();

            //มีไอดีใน Bill มั้ย
            string checkidQuery = "SELECT COUNT(*) FROM bill WHERE id_Product = @idProduct"; 
            MySqlCommand checkidCmd = new MySqlCommand(checkidQuery, conn); 
            checkidCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            int existingCount = Convert.ToInt32(checkidCmd.ExecuteScalar());

            if (existingCount > 0)//ถ้ามีไอดีในบิลให้ทำ 
            {
                //ดึง Amount จาก Bill มาเก็บไว้ 
                string getCurrentAmountQuery = "SELECT Amount FROM bill WHERE id_Product = @idProduct"; 
                MySqlCommand getCurrentAmountCmd = new MySqlCommand(getCurrentAmountQuery, conn); 
                getCurrentAmountCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
                int currentAmount = Convert.ToInt32(getCurrentAmountCmd.ExecuteScalar());

                // ดึงข้อมูลที่มีรหัสตรงกับ idproduct มาเก็บไว้ในตัวแปรแต่ละตัว 
                string getCurrentDataQuery = "SELECT Name, Quantity, price_Product,Photo FROM listproduct WHERE id_Product = @idProduct";
                MySqlCommand getCurrentDataCmd = new MySqlCommand(getCurrentDataQuery, conn); getCurrentDataCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
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
                    reader.Close();
                    //Numไม่เป็นตัวนสและเป็นบวก และ Numน้อยกว่า Amount มั้ย
                    if (int.TryParse(Num.Text, out int quantityToDecrease) && quantityToDecrease > 0 && quantityToDecrease < currentAmount)
                    {

                        //Numไม่เป็นตัวนสและเป็นบวก และ Numน้อยกว่า Amount ให้ทำ 
                        //อัพเดตจำนวนใน Bill เมื่อลบ
                        string updateQuery = "UPDATE Bill SET Amount = Amount - @Num WHERE id_Product = @idProduct;";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn); 
                        updateCmd.Parameters.AddWithValue("@Num", quantityToDecrease); 
                        updateCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
                        updateCmd.ExecuteNonQuery();

                        //ดึงจำนวนจากบิลมาเก็บไว้ 
                        string getCurrentQuantityQuery = "SELECT Amount FROM Bill WHERE id_Product = @idProduct;";
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
                        string updateQuantity = "UPDATE listproduct SET Quantity = @Quantity + @Num WHERE id_Product = @idProduct;"; 
                        MySqlCommand updateQuantityCmd = new MySqlCommand(updateQuantity, conn); 
                        updateQuantityCmd.Parameters.AddWithValue("@Quantity", Quantity); 
                        updateQuantityCmd.Parameters.AddWithValue("@Num", quantityToDecrease);
                        updateQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
                        updateQuantityCmd.ExecuteNonQuery();

                        showbill();
                        Caltatal();
                        MessageBox.Show("ลดจำนวนสินค้าแล้ว");
                        show.Image = null; // เซ็ตรูปภาพให้ว่าง
                        idproduct.Text = ""; // เซ็ตข้อความในช่อง idproduct เป็นว่าง
                        name.Text = ""; // เซ็ตข้อความในช่อง name เป็นว่าง
                        Num.Text = ""; // เซ็ตข้อความในช่อง Num เป็นว่าง

                    } 
                    //Numไม่เป็นตัวนสและเป็นบวก และ Num มากกว่าเท่ากับ Amount ให้ทำ 
                    else if (int.TryParse(Num.Text, out int quantityToDecrease2) && quantityToDecrease2 > 0 && quantityToDecrease2 >= currentAmount)
                    {
                        //อัพเดพสต็อก 
                        string updateQuantity = "UPDATE listproduct SET Quantity = @Quantity + @Amount WHERE id_Product = @idProduct;";
                        MySqlCommand updateQuantityCmd = new MySqlCommand(updateQuantity, conn); 
                        updateQuantityCmd.Parameters.AddWithValue("@Quantity", Quantity); 
                        updateQuantityCmd.Parameters.AddWithValue("@Amount", currentAmount); 
                        updateQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
                        updateQuantityCmd.ExecuteNonQuery();

                        //ลบข้อมูลนั้นออก 
                        string deletebill = "DELETE FROM bill WHERE id_Product = @idProduct;"; 
                        MySqlCommand deleteCmd = new MySqlCommand(deletebill, conn); 
                        deleteCmd.Parameters.AddWithValue("@idProduct", idproduct.Text); 
                        deleteCmd.ExecuteNonQuery();

                        showbill();
                        Caltatal();
                        MessageBox.Show("ลบสินค้าออกจากตะกร้าแล้ว");
                        show.Image = null; // เซ็ตรูปภาพให้ว่าง
                        idproduct.Text = ""; // เซ็ตข้อความในช่อง idproduct เป็นว่าง
                        name.Text = ""; // เซ็ตข้อความในช่อง name เป็นว่าง
                        Num.Text = ""; // เซ็ตข้อความในช่อง Num เป็นว่าง
                    }
                    else //มีค่าว่าง เลขติดลบ เลขมากกว่าสต็อก
                    {
                        MessageBox.Show("ข้อผิดพลาดจากการรับข้อมูล", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e) //ปุ่มลบออกเลย
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            //ดึง Amount จาก Bill มาเก็บไว้ 
            string getCurrentAmountQuery = "SELECT Amount FROM bill WHERE id_Product = @idProduct";
            MySqlCommand getCurrentAmountCmd = new MySqlCommand(getCurrentAmountQuery, conn);
            getCurrentAmountCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            int currentAmount = Convert.ToInt32(getCurrentAmountCmd.ExecuteScalar());

            //ดึงจำนวน Quantity จาก listproduct มาเก็บไว้
            string getQuery = "SELECT Amount FROM bill WHERE id_Product = @idProduct";
            MySqlCommand getQueryCmd = new MySqlCommand(getQuery, conn);
            getQueryCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            int currentquantity = Convert.ToInt32(getQueryCmd.ExecuteScalar());

            //อัพเดพสต็อก 
            string updateQuantity = "UPDATE listproduct SET Quantity = @Quantity + @Amount WHERE id_Product = @idProduct;";
            MySqlCommand updateQuantityCmd = new MySqlCommand(updateQuantity, conn);
            updateQuantityCmd.Parameters.AddWithValue("@Quantity", currentquantity);
            updateQuantityCmd.Parameters.AddWithValue("@Amount", currentAmount);
            updateQuantityCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            updateQuantityCmd.ExecuteNonQuery();

            //ลบข้อมูลนั้นออก 
            string deletebill = "DELETE FROM bill WHERE id_Product = @idProduct;";
            MySqlCommand deleteCmd = new MySqlCommand(deletebill, conn);
            deleteCmd.Parameters.AddWithValue("@idProduct", idproduct.Text);
            deleteCmd.ExecuteNonQuery();

            showbill();
            Caltatal();
            MessageBox.Show("ลบสินค้าออกจากตะกร้าแล้ว");
            show.Image = null; // เซ็ตรูปภาพให้ว่าง
            idproduct.Text = ""; // เซ็ตข้อความในช่อง idproduct เป็นว่าง
            name.Text = ""; // เซ็ตข้อความในช่อง name เป็นว่าง
            Num.Text = ""; // เซ็ตข้อความในช่อง Num เป็นว่าง

        }


        private void payment_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            Form15 form15 = new Form15(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form15.SetData(username);
            form15.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void Caltatal()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            // สร้างคำสั่ง SQL เพื่อดึงค่า Allprice ทั้งหมดจากตาราง bill
            string getTotalQuery = "SELECT Allprice FROM bill";
            MySqlCommand getTotalCmd = new MySqlCommand(getTotalQuery, conn);

            // สร้างตัวแปรเพื่อเก็บผลรวมทั้งหมดของค่า Allprice
            double totalAmount = 0;

            // อ่านค่าจากคำสั่ง SQL และคำนวณผลรวมทั้งหมด
            using (MySqlDataReader reader = getTotalCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string allpriceStr = reader.GetString(0); // ดึงค่า Allprice จากผลลัพธ์ของคำสั่ง SQL
                    allpriceStr = allpriceStr.Replace(",", ""); // ลบลูกน้ำออก
                    double allprice = double.Parse(allpriceStr); // แปลงเป็น double
                    totalAmount += allprice; // เพิ่มค่า Allprice เข้าสู่ผลรวมทั้งหมด
                }
            }

            // ปิดการเชื่อมต่อกับฐานข้อมูล
            conn.Close();

            // แสดงผลลัพธ์ใน label total
            total.Text = totalAmount.ToString("#,##0.00")+" Bath";
        }

        private void total_Click(object sender, EventArgs e)
        {

        }
    }
}
