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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // สร้างหน้าฟอร์มที่ต้องการเปิด
            form1.Show(); // เปิดหน้าฟอร์ม
            this.Hide();
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            if (Pass.Text == "00")
            {
                // ไปที่หน้า 3
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
