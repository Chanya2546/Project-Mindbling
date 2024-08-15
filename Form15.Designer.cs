namespace EditMindTwinkle
{
    partial class Form15
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.AddText = new System.Windows.Forms.TextBox();
            this.bill = new System.Windows.Forms.DataGridView();
            this.vat = new System.Windows.Forms.Label();
            this.shop = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.qrPay = new System.Windows.Forms.PictureBox();
            this.conpay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conpay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 875);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 43);
            this.label5.TabIndex = 22;
            this.label5.Text = "<";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TelText
            // 
            this.TelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.TelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelText.Font = new System.Drawing.Font("DilleniaUPC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelText.Location = new System.Drawing.Point(145, 407);
            this.TelText.Name = "TelText";
            this.TelText.Size = new System.Drawing.Size(446, 57);
            this.TelText.TabIndex = 23;
            this.TelText.TextChanged += new System.EventHandler(this.TelText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("DilleniaUPC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(145, 305);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(446, 57);
            this.NameText.TabIndex = 24;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("DilleniaUPC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(145, 508);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(446, 57);
            this.EmailText.TabIndex = 25;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // AddText
            // 
            this.AddText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.AddText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddText.Font = new System.Drawing.Font("DilleniaUPC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddText.Location = new System.Drawing.Point(145, 607);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(728, 57);
            this.AddText.TabIndex = 26;
            this.AddText.TextChanged += new System.EventHandler(this.AddText_TextChanged);
            // 
            // bill
            // 
            this.bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill.BackgroundColor = System.Drawing.Color.White;
            this.bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill.Location = new System.Drawing.Point(669, 132);
            this.bill.Name = "bill";
            this.bill.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.bill.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bill.RowTemplate.Height = 24;
            this.bill.Size = new System.Drawing.Size(666, 397);
            this.bill.TabIndex = 27;
            this.bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_CellContentClick);
            // 
            // vat
            // 
            this.vat.AutoSize = true;
            this.vat.BackColor = System.Drawing.Color.White;
            this.vat.Font = new System.Drawing.Font("Angsana New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(43)))), ((int)(((byte)(34)))));
            this.vat.Location = new System.Drawing.Point(1173, 544);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(115, 69);
            this.vat.TabIndex = 28;
            this.vat.Text = "label1";
            this.vat.Click += new System.EventHandler(this.vat_Click);
            // 
            // shop
            // 
            this.shop.AutoSize = true;
            this.shop.BackColor = System.Drawing.Color.White;
            this.shop.Font = new System.Drawing.Font("Angsana New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(43)))), ((int)(((byte)(34)))));
            this.shop.Location = new System.Drawing.Point(1175, 607);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(115, 69);
            this.shop.TabIndex = 29;
            this.shop.Text = "label1";
            this.shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Font = new System.Drawing.Font("Angsana New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(43)))), ((int)(((byte)(34)))));
            this.total.Location = new System.Drawing.Point(1175, 671);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(115, 69);
            this.total.TabIndex = 30;
            this.total.Text = "label2";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // qrPay
            // 
            this.qrPay.Image = ((System.Drawing.Image)(resources.GetObject("qrPay.Image")));
            this.qrPay.Location = new System.Drawing.Point(167, 720);
            this.qrPay.Name = "qrPay";
            this.qrPay.Size = new System.Drawing.Size(272, 97);
            this.qrPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrPay.TabIndex = 31;
            this.qrPay.TabStop = false;
            this.qrPay.Click += new System.EventHandler(this.qrPay_Click);
            // 
            // conpay
            // 
            this.conpay.Image = ((System.Drawing.Image)(resources.GetObject("conpay.Image")));
            this.conpay.Location = new System.Drawing.Point(535, 709);
            this.conpay.Name = "conpay";
            this.conpay.Size = new System.Drawing.Size(321, 113);
            this.conpay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conpay.TabIndex = 32;
            this.conpay.TabStop = false;
            this.conpay.Click += new System.EventHandler(this.conpay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 43);
            this.label1.TabIndex = 33;
            this.label1.Text = "<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.Username.Font = new System.Drawing.Font("Angsana New", 28F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(666, 1);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(163, 65);
            this.Username.TabIndex = 34;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conpay);
            this.Controls.Add(this.qrPay);
            this.Controls.Add(this.total);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.TelText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conpay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox AddText;
        private System.Windows.Forms.DataGridView bill;
        private System.Windows.Forms.Label vat;
        private System.Windows.Forms.Label shop;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox qrPay;
        private System.Windows.Forms.PictureBox conpay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
    }
}