using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using PdfiumViewer;



namespace EditMindTwinkle
{
    public partial class Form15 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mindbling;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form15()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public void SetData(string username)
        {
            Username.Text = username;

        }
        private void showbill()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_Product, NameProduct, Amount, price_one_pc, Allprice FROM bill";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            bill.DataSource = ds.Tables[0].DefaultView;
        }
        private void label5_Click(object sender, EventArgs e) //ย้อนกลับ
        {
            string username=Username.Text;
            Form14 form14 = new Form14(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form14.SetData(username);
            form14.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            ShowMember();
            showbill();
            conpay.Hide();
            label1.Hide();
            Caltatalmember();
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
                NameText.Text = foundRows[0]["Name"].ToString();
                Username.Text = foundRows[0]["Username"].ToString();
                TelText.Text = foundRows[0]["Tel"].ToString();
                EmailText.Text = foundRows[0]["Email"].ToString();
                AddText.Text = foundRows[0]["Address"].ToString();
               
            }
        }

        private void TelText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Caltatalnonmember()
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

            double Vat = totalAmount * 0.07;
            double Shop = 45;
            double sum= Vat + Shop+ totalAmount;

            vat.Text= Vat.ToString("#,##0.00") + " Bath";
            shop.Text=Shop.ToString("#,##0.00") + " Bath";
            total.Text = sum.ToString("#,##0.00") + " Bath";
        }


        private void Caltatalmember()
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

            double Vat = totalAmount * 0.07; //คิดภาษีก่อนราคาที่จะลด
            double discount = 0;
            double deliveryFee = 0;

            // ตรวจสอบเงื่อนไขและกำหนดส่วนลด
            if (  totalAmount >= 1000)
            {
                //ลด5%
                discount = totalAmount * 0.05;
                shop.Text = "Free";

            }
            //ลด3%
            else if (totalAmount>=799 && totalAmount < 1000)
            {
                discount = totalAmount * 0.03;
                shop.Text = "Free";

            }
            else if (totalAmount >= 499 && totalAmount<799 )
            {
                shop.Text = "Free";
            }
            else
            {
                deliveryFee = 45;
                shop.Text = "45.00 Baht";
            }
            totalAmount -= discount; // หักส่วนลด
            totalAmount += deliveryFee;
            totalAmount = Math.Max(totalAmount, 0); // ตรวจสอบให้ไม่ติดลบ
            double sum = Vat + totalAmount;
            

            // แสดงผลคำนวณทั้งหมด
            vat.Text = Vat.ToString("#,##0.00") + " Baht";
            total.Text = sum.ToString("#,##0.00") + " Baht";
        }


        private void total_Click(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddText_TextChanged(object sender, EventArgs e)
        {

        }

        private void bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vat_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Click(object sender, EventArgs e)
        {

        }

        private void qrPay_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label1.Show();
            if((TelText.Text.Length == 10 && TelText.Text.All(char.IsDigit)))
            {
                if (!string.IsNullOrEmpty(NameText.Text) && !string.IsNullOrEmpty(TelText.Text) && !string.IsNullOrEmpty(EmailText.Text) && !string.IsNullOrEmpty(AddText.Text))
                {
                    Form16 form16 = new Form16(total.Text); // สร้างหน้าฟอร์มที่ต้องการเปิด
                    form16.Show(); // เปิดหน้าฟอร์ม
                    conpay.Show();
                }
                else
                {
                    MessageBox.Show("โปรดกรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("โปรดกรอกเบอร์โทรศัพท์ที่ถูกต้อง (ต้องมี 10 ตัวและไม่มีตัวอักษร)", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void conpay_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = databaseConnection();
            conn.Open();

            //ดึงข้อมูล ไอดี จำนวน ทั้งคอลัมน์จากตารางบิลมา
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_Product, Amount FROM Bill";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> idProducts = new List<string>();
            List<string> amounts = new List<string>();
            while (reader.Read())
            {
                string idProduct = reader.GetString("id_Product");
                idProducts.Add(idProduct);
                string amount = reader.GetString("Amount");
                amounts.Add(amount);
            }
            reader.Close();

                // ต่อเชื่อม idProducts ให้เป็นสตริงที่คั่นด้วยเครื่องหมาย ','
            string allIdProducts = string.Join(", ", idProducts);
                // ต่อเชื่อม amounts ให้เป็นสตริงที่คั่นด้วยเครื่องหมาย ','
            string allAmounts = string.Join(", ", amounts);

            //เก็บข้อมูลเข้า
            string allPrice = total.Text.Replace(" Bath", "");

            string insertQuery = "INSERT INTO summary (Customer_name, id_Product, Amount, AllPrice, Address, Tel, Email) VALUES (@Customer_name, @id_Product, @Amount, @AllPrice, @Address, @Tel, @Email)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@Customer_name", NameText.Text);
            insertCmd.Parameters.AddWithValue("@id_Product", allIdProducts);
            insertCmd.Parameters.AddWithValue("@Amount", allAmounts);
            insertCmd.Parameters.AddWithValue("@AllPrice", allPrice);
            insertCmd.Parameters.AddWithValue("@Address", AddText.Text);
            insertCmd.Parameters.AddWithValue("@Tel", TelText.Text);
            insertCmd.Parameters.AddWithValue("@Email", EmailText.Text);
            insertCmd.ExecuteNonQuery();

            // ดึงค่า IDOrder จากตาราง summary ล่าสุดมาเก็บไว้
            string getLastOrderIDQuery = "SELECT MAX(IDOrder) FROM summary";
            MySqlCommand getLastOrderIDCmd = new MySqlCommand(getLastOrderIDQuery, conn);
            int lastOrderID = Convert.ToInt32(getLastOrderIDCmd.ExecuteScalar());


            MySqlDataReader reader2 = cmd.ExecuteReader();
            Dictionary<string, int> productAmounts = new Dictionary<string, int>();

            while (reader2.Read())
            {
                string idProduct = reader2.GetString("id_Product");
                string amount = reader2.GetString("Amount");

                // ตรวจสอบว่ามี id_Product อยู่ใน Dictionary หรือไม่
                if (productAmounts.ContainsKey(idProduct))
                {
                    // หากมีให้เพิ่มค่า Amount เข้าไปใน Dictionary
                    productAmounts[idProduct] += Convert.ToInt32(amount);
                }
                else
                {
                    // หากยังไม่มีให้เพิ่ม id_Product และค่า Amount เข้าไปใน Dictionary
                    productAmounts.Add(idProduct, Convert.ToInt32(amount));
                }
            }
            reader2.Close();

            // เพิ่มข้อมูลเข้าตาราง forstockcancel โดยวนลูปผ่านค่า id_Product และ Amount จาก Dictionary
            foreach (var kvp in productAmounts)
            {
                string idProduct = kvp.Key;
                int amount = kvp.Value;

                // INSERT เข้าตาราง forstockcancel
                string insertForStockCancelQuery = "INSERT INTO forstockcancel (IDOrder, id_Product, Amount) VALUES (@IDOrder, @id_Product, @Amount)";
                MySqlCommand insertForStockCancelCmd = new MySqlCommand(insertForStockCancelQuery, conn);
                insertForStockCancelCmd.Parameters.AddWithValue("@IDOrder", lastOrderID);
                insertForStockCancelCmd.Parameters.AddWithValue("@id_Product", idProduct);
                insertForStockCancelCmd.Parameters.AddWithValue("@Amount", amount);
                insertForStockCancelCmd.ExecuteNonQuery();
            }
            CreatePDF();
            
            

            //ดึงจำนวนจาก Purchase มาเก็บไว้
            string getCurrentPurchaseQuery = "SELECT Purchase FROM member WHERE Tel = @tel;";
            MySqlCommand getCurrentPurchaseCmd = new MySqlCommand(getCurrentPurchaseQuery, conn);
            getCurrentPurchaseCmd.Parameters.AddWithValue("@tel", TelText.Text);
            int currentPurchase = Convert.ToInt32(getCurrentPurchaseCmd.ExecuteScalar());

           
            //อัพเเดตราคา
            string updatePurchase = "UPDATE member SET Purchase = @Purchase + 1 WHERE Tel = @tel;";
            MySqlCommand updateupdatePurchaseCmd = new MySqlCommand(updatePurchase, conn);
            updateupdatePurchaseCmd.Parameters.AddWithValue("@Purchase", currentPurchase);
            updateupdatePurchaseCmd.Parameters.AddWithValue("@tel", TelText.Text);
            updateupdatePurchaseCmd.ExecuteNonQuery();

            conn.Close();
        }
        private void CreatePDF()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            string getLastDateQuery = "SELECT MAX(date) FROM summary";
            MySqlCommand cmd = new MySqlCommand(getLastDateQuery, conn);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                DateTime lastDate = Convert.ToDateTime(result);
                // ทำอะไรสักอย่างกับ lastDate ที่ได้รับ

                string Lastdate = lastDate.ToString("yyyy-MM-dd");

                string getLastOrderIDQuery = "SELECT MAX(IDOrder) FROM summary";
                MySqlCommand getLastOrderIDCmd = new MySqlCommand(getLastOrderIDQuery, conn);
                int lastOrderID = Convert.ToInt32(getLastOrderIDCmd.ExecuteScalar());
                string lastOrderIDString = lastOrderID.ToString();

                Document doc = new Document(PageSize.A4);
                try
                {
                    string outputFolder = @"C:\Users\Chany\Downloads";
                    string baseFileName = "ใบเสร็จคำสั่งซื้อที่" + lastOrderID;
                    string outputFilePath = Path.Combine(outputFolder, baseFileName + ".pdf");

                    // ตรวจสอบว่าไดเร็กทอรีที่ต้องการบันทึกไฟล์ PDF มีอยู่หรือไม่
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }
                    using (FileStream fs = new FileStream(outputFilePath, FileMode.Create))
                    {
                        BaseFont thaifont = BaseFont.CreateFont(@"C:\Users\Chany\source\repos\EditMindTwinkle\THSarabunNew.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(thaifont, 20);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open(); // เปิดเอกสาร PDF เพื่อเพิ่มเนื้อหา

                        iTextSharp.text.Paragraph empty = new iTextSharp.text.Paragraph();
                        empty.Add(new Chunk("\n"));

                        // เพิ่มเนื้อหาในเอกสาร PDF ที่นี่ (ตามต้องการ)
                        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
                        paragraph.Alignment = Element.ALIGN_CENTER; // กำหนดให้อยู่ตรงกลาง
                        iTextSharp.text.Font font2 = new iTextSharp.text.Font(thaifont, 36, iTextSharp.text.Font.BOLD); // กำหนดตัวหนา
                        Chunk chunk = new Chunk("ใบเสร็จการจ่ายเงิน", font2);
                        paragraph.Add(chunk);
                        doc.Add(paragraph);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph2 = new iTextSharp.text.Paragraph();
                        paragraph2.Alignment = Element.ALIGN_CENTER; // กำหนดให้อยู่ตรงกลาง
                        iTextSharp.text.Font font3 = new iTextSharp.text.Font(thaifont, 25);
                        Chunk namestore = new Chunk("ร้าน MindBling", font3);
                        paragraph2.Add(namestore);
                        doc.Add(paragraph2);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph4 = new iTextSharp.text.Paragraph();
                        paragraph4.Alignment = Element.ALIGN_LEFT; // กำหนดให้อยู่ตรงกลาง
                        iTextSharp.text.Font font4 = new iTextSharp.text.Font(thaifont, 22);
                        Chunk ordertime = new Chunk("หมายเลขคำสั่งซื้อ : " + lastOrderID + "           วันที่สั่งซื้อ : " + Lastdate, font4);
                        paragraph4.Add(ordertime);
                        doc.Add(paragraph4);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph3 = new iTextSharp.text.Paragraph();
                        paragraph3.Alignment = Element.ALIGN_LEFT; // กำหนดให้อยู่ตรงกลาง
                        Chunk namecustomer = new Chunk("ชื่อลูกค้า : " + NameText.Text, font4);
                        paragraph3.Add(namecustomer);
                        doc.Add(paragraph3);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph6 = new iTextSharp.text.Paragraph();
                        paragraph6.Alignment = Element.ALIGN_LEFT; // กำหนดให้อยู่ตรงกลาง
                        Chunk Tel = new Chunk("เบอร์โทร : " + TelText.Text, font4);
                        paragraph6.Add(Tel);
                        doc.Add(paragraph6);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph8 = new iTextSharp.text.Paragraph();
                        paragraph8.Alignment = Element.ALIGN_LEFT; // กำหนดให้อยู่ตรงกลาง
                        Chunk Email = new Chunk("อีเมล : " + EmailText.Text, font4);
                        paragraph8.Add(Email);
                        doc.Add(paragraph8);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph7 = new iTextSharp.text.Paragraph();
                        paragraph7.Alignment = Element.ALIGN_LEFT; // กำหนดให้อยู่ตรงกลาง
                        Chunk Add = new Chunk("ที่อยู่ที่จัดส่ง : " + AddText.Text, font4);
                        paragraph7.Add(Add);
                        doc.Add(paragraph7);
                        doc.Add(empty);

                        iTextSharp.text.Paragraph paragraph5 = new iTextSharp.text.Paragraph();
                        paragraph5.Alignment = Element.ALIGN_CENTER; // กำหนดให้อยู่ตรงกลาง
                        iTextSharp.text.Font font5 = new iTextSharp.text.Font(thaifont, 23);
                        Chunk productlidt = new Chunk("รายการสินค้า", font5);
                        paragraph5.Add(productlidt);
                        doc.Add(paragraph5);
                        doc.Add(empty);

                        //เพิ่มการดึงตารางจาก bill มาแสดง
                        // ดึงข้อมูลจากตาราง bill
                        MySqlCommand billCmd = new MySqlCommand("SELECT id_Product, NameProduct, Amount, price_one_pc, Allprice FROM bill  ", conn);
                        using (MySqlDataReader billReader = billCmd.ExecuteReader())
                        {
                            // สร้างตารางเพื่อเก็บข้อมูลจากตาราง bill และ listproduct
                            PdfPTable dataTable = new PdfPTable(4); // 5 คอลัมน์: id_Product, ProductName, Amount, PriceProduct, Priceproduct

                            // เพิ่มชื่อคอลัมน์
                            dataTable.AddCell("Amount");
                            dataTable.AddCell("ID_Product");
                            dataTable.AddCell("Product Name");
                            dataTable.AddCell("Price_one_pc.");
                            dataTable.AddCell("AllPrice");

                            // อ่านข้อมูลจากตาราง bill และเพิ่มลงในตารางของ PDF
                            while (billReader.Read())
                            {
                                string idProduct = billReader.GetString(0);
                                string productName = billReader.GetString(1);
                                int amount = billReader.GetInt32(2);

                                string priceone = billReader.GetString(3);
                                string formattedSum = float.Parse(priceone).ToString("#,###");

                                string priceProductList = billReader.GetString(4);
                                string formattedSum2 = float.Parse(priceProductList).ToString("#,###");

                               
                                // เพิ่มข้อมูลลงในตาราง PDF
                                dataTable.AddCell(amount.ToString());
                                dataTable.AddCell(idProduct);
                                dataTable.AddCell(productName);
                                dataTable.AddCell(formattedSum.ToString());
                                dataTable.AddCell(formattedSum2.ToString());

                                
                            }
                            billReader.Close();

                            // เพิ่มตารางของ bill  ลงในไฟล์ PDF
                            doc.Add(dataTable);
                            doc.Add(empty);
                            iTextSharp.text.Paragraph paragraph9 = new iTextSharp.text.Paragraph();
                            paragraph9.Alignment = Element.ALIGN_RIGHT; // กำหนดให้อยู่ตรงกลาง
                            Chunk showvat = new Chunk("ภาษี 7% : " + vat.Text, font4);
                            paragraph9.Add(showvat);
                            doc.Add(paragraph9);
                            doc.Add(empty);

                            iTextSharp.text.Paragraph paragraph10 = new iTextSharp.text.Paragraph();
                            paragraph10.Alignment = Element.ALIGN_RIGHT; // กำหนดให้อยู่ตรงกลาง
                            Chunk showshop = new Chunk("ค่าจัดส่ง : " + shop.Text, font4);
                            paragraph10.Add(showshop);
                            doc.Add(paragraph10);
                            doc.Add(empty);

                            iTextSharp.text.Paragraph paragraph11 = new iTextSharp.text.Paragraph();
                            paragraph11.Alignment = Element.ALIGN_RIGHT; // กำหนดให้อยู่ตรงกลาง
                            Chunk showtotal = new Chunk("ยอดคำสั่งซื้อ : " + total.Text, font4);
                            paragraph11.Add(showtotal);
                            doc.Add(paragraph11);
                            doc.Add(empty);

                            string imagePath = @"C:\Users\Chany\source\repos\EditMindTwinkle\____________ ผู้รับเงิน.png"; // ตัวอย่างชื่อไฟล์ภาพ
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath); // สร้างรูปภาพจากไฟล์ภาพ
                            img.ScaleAbsolute(100f, 100f); // กำหนดขนาดของรูปภาพ

                            img.SetAbsolutePosition(400f, 50f);
                            doc.Add(img); // เพิ่มรูปภาพลงในเอกสาร PDF
                        }
                        // บันทึกเอกสาร PDF
                        doc.Close();
                        using (FileStream fs2 = new FileStream(outputFilePath, FileMode.Open, FileAccess.Read))
                        {
                            // อ่านไฟล์ PDF และเก็บข้อมูลลงใน byte array
                            byte[] pdfData = new byte[fs2.Length];
                            fs2.Read(pdfData, 0, pdfData.Length); 

                        }
                        SendEmail(outputFilePath, EmailText.Text);


                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }

  

        private async void SendEmail(string outputFilePath, string recipientEmail)
    {
        MySqlConnection conn = databaseConnection();
        conn.Open();
        string getLastOrderIDQuery = "SELECT MAX(IDOrder) FROM summary";
        MySqlCommand getLastOrderIDCmd = new MySqlCommand(getLastOrderIDQuery, conn);
        int lastOrderID = Convert.ToInt32(getLastOrderIDCmd.ExecuteScalar());
        string lastOrderIDString = lastOrderID.ToString();
        try
        {
            string fromMail = "mindchanya2546@gmail.com";
            string fromPassword = "etku dkcq jctw laoi";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "ใบเสร็จคำสั่งซื้อ " + lastOrderID + " MindBling";
            message.To.Add(new MailAddress(recipientEmail));

            Attachment attachment = new Attachment(outputFilePath);
            message.Attachments.Add(attachment);

            // สร้างอ็อบเจกต์ของ SmtpClient
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                // กำหนดค่า Port ผ่านอ็อบเจกต์ SmtpClient
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true; // เปิดใช้งาน SSL
                smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);

                // ส่งอีเมล
                await smtpClient.SendMailAsync(message);
            }
              DialogResult result = MessageBox.Show("ส่งใบเสร็จทางอีเมลเรียบร้อยแล้ว", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    string dropTableQuery = "DROP TABLE IF EXISTS Bill;";
                    MySqlCommand dropTableCmd = new MySqlCommand(dropTableQuery, conn);
                    dropTableCmd.ExecuteNonQuery();
                    // ไปที่หน้า 2
                    string username = Username.Text;
                    Form2 form2 = new Form2();
                    form2.SetData(username);
                    form2.Show();
                    this.Hide();
                }
        }
        catch (Exception ex)
        {
            // จัดการข้อผิดพลาดในการส่งอีเมล
            Console.WriteLine("Error sending email: " + ex.Message);
        }
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}
