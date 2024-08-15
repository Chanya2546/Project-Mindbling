using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Form18 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form18()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string checkOrderQuery = "SELECT COUNT(*) FROM summary WHERE IDOrder = @IDOrder";
            MySqlCommand checkOrderCmd = new MySqlCommand(checkOrderQuery, conn);
            checkOrderCmd.Parameters.AddWithValue("@IDOrder", idorder.Text);
            ////conn.Open();
            int existingCount = Convert.ToInt32(checkOrderCmd.ExecuteScalar());
            //มีออเดอร์ใน summary มั้ย
            if (existingCount > 0) //ถ้ามีออร์เดอร์ให้ทำ
            {
                //ดึงข้อมูลมาเก็บไว้
                string getCurrentDataQuery = "SELECT IDOrder,date,Customer_name,id_Product, Amount, AllPrice,Address,Tel,Email FROM summary WHERE IDOrder = @IDOrder";
                MySqlCommand getCurrentDataCmd = new MySqlCommand(getCurrentDataQuery, conn);
                getCurrentDataCmd.Parameters.AddWithValue("@IDOrder", idorder.Text);

                MySqlDataReader reader = getCurrentDataCmd.ExecuteReader();

                if (reader.Read())
                {
                    //int IDorder = reader.GetInt32(0);
                    DateTime date = reader.GetDateTime(1);
                    string name = reader.GetString(2);
                    string idproduct = reader.GetString(3);
                    string amounts = reader.GetString(4);
                    string priceproduct = reader.GetString(5);
                    string add = reader.GetString(6);
                    string tel = reader.GetString(7);
                    string email = reader.GetString(8);
                    reader.Close();
                    //เพิ่มเข้าการยกเลิก
                    string insertQuery2 = "INSERT INTO ordercancel (IDOrder,date,Customer_name,id_Product, Amount, AllPrice,Address,Tel,Email ) VALUES (@IDOrder,@date,@Customer_name,@id_Product,@Amount,@Priceproduct,@Address,@Tel,@Email)";
                    MySqlCommand insert2Cmd = new MySqlCommand(insertQuery2, conn);
                    insert2Cmd.Parameters.AddWithValue("@IDOrder", idorder.Text);
                    insert2Cmd.Parameters.AddWithValue("date", date);
                    insert2Cmd.Parameters.AddWithValue("@Customer_name", name);
                    insert2Cmd.Parameters.AddWithValue("@id_Product", idproduct);
                    insert2Cmd.Parameters.AddWithValue("@Amount", amounts);
                    insert2Cmd.Parameters.AddWithValue("@Priceproduct", priceproduct);
                    insert2Cmd.Parameters.AddWithValue("@Address", add);
                    insert2Cmd.Parameters.AddWithValue("@Tel", tel);
                    insert2Cmd.Parameters.AddWithValue("@Email", email);
                    insert2Cmd.ExecuteNonQuery();

                    // มี เลขออร์เดอร์ที่คีเข้าในตาราง forordercancel มั้ย
                    string checkExistQuery = "SELECT COUNT(*) FROM forstockcancel WHERE IDOrder = @idorder";
                    MySqlCommand checkExistingCmd = new MySqlCommand(checkExistQuery, conn);
                    checkExistingCmd.Parameters.AddWithValue("@idorder", idorder.Text);
                    int existingCount2 = Convert.ToInt32(checkExistingCmd.ExecuteScalar());

                    if (existingCount2 > 0) // ถ้ามีเลขในตารางให้ทำ
                    {
                        // ดึงข้อมูล id_Product และ Amount จากตาราง forstockcancel
                        string getForStockCancelDataQuery = "SELECT id_Product, Amount FROM forstockcancel WHERE IDOrder = @IDOrder";
                        MySqlCommand getForStockCancelDataCmd = new MySqlCommand(getForStockCancelDataQuery, conn);
                        getForStockCancelDataCmd.Parameters.AddWithValue("@IDOrder", idorder.Text);

                        MySqlDataReader forStockCancelReader = getForStockCancelDataCmd.ExecuteReader();

                        Dictionary<string, int> productAmounts = new Dictionary<string, int>();

                        // เก็บข้อมูล id_Product และ Amount ใน Dictionary
                        while (forStockCancelReader.Read())
                        {
                            string idProduct = forStockCancelReader.GetString("id_Product");
                            int amount = forStockCancelReader.GetInt32("Amount");

                            if (productAmounts.ContainsKey(idProduct))
                            {
                                productAmounts[idProduct] += amount;
                            }
                            else
                            {
                                productAmounts.Add(idProduct, amount);
                            }
                        }
                        forStockCancelReader.Close();
                        // ตรวจสอบและบวกจำนวนสินค้าในตาราง listproduct
                        foreach (var kvp in productAmounts)
                        {
                            string idProduct = kvp.Key;
                            int amount = kvp.Value;

                            // ตรวจสอบว่า id_Product มีในตาราง listproduct หรือไม่
                            string checkListProductQuery = "SELECT COUNT(*) FROM listproduct WHERE id_Product = @idProduct";
                            MySqlCommand checkListProductCmd = new MySqlCommand(checkListProductQuery, conn);
                            checkListProductCmd.Parameters.AddWithValue("@idProduct", idProduct);
                            int productListCount = Convert.ToInt32(checkListProductCmd.ExecuteScalar());

                            if (productListCount > 0) // ถ้ามี id_Product ในตาราง listproduct
                            {
                                // บวกค่า Amount เข้าไปใน Quantity ของ id_Product ที่ตรงกัน
                                string updateListProductQuery = "UPDATE listproduct SET Quantity = Quantity + @Amount WHERE id_Product = @idProduct";
                                MySqlCommand updateListProductCmd = new MySqlCommand(updateListProductQuery, conn);
                                updateListProductCmd.Parameters.AddWithValue("@Amount", amount);
                                updateListProductCmd.Parameters.AddWithValue("@idProduct", idProduct);
                                updateListProductCmd.ExecuteNonQuery();

                                // ทำการยกเลิกออร์เดอร์โดยลบข้อมูลในตาราง summary
                                string deletebill = "DELETE FROM summary WHERE IDOrder = @IDOrder;";
                                MySqlCommand deleteCmd = new MySqlCommand(deletebill, conn);
                                deleteCmd.Parameters.AddWithValue("@IDOrder", idorder.Text);
                                deleteCmd.ExecuteNonQuery();

                                
                            }
                            

                        }
                    }
                }
                // แสดงฟอร์มยกเลิกออร์เดอร์
                MessageBox.Show("ยกเลิกคำสั่งซื้อเรียบร้อย");
                idorder.Text = string.Empty;
            }
            
            else
            {
                MessageBox.Show("ไม่มีหมายเลขคำสั่งซื้อนี้หรือคำสั่งซื้อนี้ถูกยกเลิกไปแล้ว", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idorder.Text = string.Empty;

            }



        }

        private void label_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void idorder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
