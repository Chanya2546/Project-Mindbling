namespace EditMindTwinkle
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bill = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.idproduct = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.PictureBox();
            this.payment = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.total = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 875);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bill
            // 
            this.bill.AllowUserToAddRows = false;
            this.bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill.BackgroundColor = System.Drawing.Color.White;
            this.bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill.Location = new System.Drawing.Point(74, 540);
            this.bill.Name = "bill";
            this.bill.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.bill.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bill.RowTemplate.Height = 24;
            this.bill.Size = new System.Drawing.Size(1251, 258);
            this.bill.TabIndex = 5;
            this.bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Billcheek);
            this.bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_CellContentClick_1);
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
            this.label5.TabIndex = 21;
            this.label5.Text = "<";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // idproduct
            // 
            this.idproduct.AutoSize = true;
            this.idproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.idproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idproduct.Font = new System.Drawing.Font("DilleniaUPC", 23.8F);
            this.idproduct.Location = new System.Drawing.Point(597, 222);
            this.idproduct.Name = "idproduct";
            this.idproduct.Size = new System.Drawing.Size(0, 52);
            this.idproduct.TabIndex = 22;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("DilleniaUPC", 23.8F);
            this.name.Location = new System.Drawing.Point(793, 222);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 52);
            this.name.TabIndex = 23;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Num.Font = new System.Drawing.Font("DilleniaUPC", 24.8F);
            this.Num.Location = new System.Drawing.Point(1190, 220);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(153, 54);
            this.Num.TabIndex = 24;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(136, 130);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(390, 330);
            this.show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show.TabIndex = 25;
            this.show.TabStop = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // payment
            // 
            this.payment.Image = ((System.Drawing.Image)(resources.GetObject("payment.Image")));
            this.payment.Location = new System.Drawing.Point(855, 398);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(232, 84);
            this.payment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payment.TabIndex = 26;
            this.payment.TabStop = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(706, 310);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(185, 56);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 27;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // minus
            // 
            this.minus.Image = ((System.Drawing.Image)(resources.GetObject("minus.Image")));
            this.minus.Location = new System.Drawing.Point(894, 310);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(185, 56);
            this.minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minus.TabIndex = 28;
            this.minus.TabStop = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // delete
            // 
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(1084, 310);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(185, 56);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 29;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.total.Font = new System.Drawing.Font("Angsana New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(43)))), ((int)(((byte)(34)))));
            this.total.Location = new System.Drawing.Point(1153, 803);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 69);
            this.total.TabIndex = 30;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.Username.Font = new System.Drawing.Font("Angsana New", 28F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(666, 1);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(163, 65);
            this.Username.TabIndex = 31;
            this.Username.Text = "Username";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.total);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idproduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView bill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idproduct;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.PictureBox show;
        private System.Windows.Forms.PictureBox payment;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.PictureBox minus;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label Username;
    }
}