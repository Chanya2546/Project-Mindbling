namespace EditMindTwinkle
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.select = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.PictureBox();
            this.idproduct = new System.Windows.Forms.TextBox();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 875);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // select
            // 
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Location = new System.Drawing.Point(143, 425);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(384, 133);
            this.select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.select.TabIndex = 1;
            this.select.TabStop = false;
            this.select.Click += new System.EventHandler(this.select_Click_1);
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(671, 464);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(163, 59);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 12;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(859, 464);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(170, 59);
            this.Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete.TabIndex = 13;
            this.Delete.TabStop = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(1055, 464);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(164, 59);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 14;
            this.Edit.TabStop = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(23, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 43);
            this.label.TabIndex = 15;
            this.label.Text = "<";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(155, 125);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(360, 300);
            this.show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show.TabIndex = 16;
            this.show.TabStop = false;
            // 
            // idproduct
            // 
            this.idproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.idproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idproduct.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.idproduct.Location = new System.Drawing.Point(597, 155);
            this.idproduct.Name = "idproduct";
            this.idproduct.Size = new System.Drawing.Size(199, 57);
            this.idproduct.TabIndex = 17;
            // 
            // NameProduct
            // 
            this.NameProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.NameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameProduct.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.NameProduct.Location = new System.Drawing.Point(841, 155);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(378, 57);
            this.NameProduct.TabIndex = 18;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.detail.Location = new System.Drawing.Point(597, 267);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(622, 57);
            this.detail.TabIndex = 19;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.price.Location = new System.Drawing.Point(597, 377);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(199, 57);
            this.price.TabIndex = 20;
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Num.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.Num.Location = new System.Drawing.Point(841, 377);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(199, 57);
            this.Num.TabIndex = 21;
            // 
            // Stock
            // 
            this.Stock.AllowUserToAddRows = false;
            this.Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stock.BackgroundColor = System.Drawing.Color.White;
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock.Location = new System.Drawing.Point(31, 588);
            this.Stock.Name = "Stock";
            this.Stock.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Stock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Stock.RowTemplate.Height = 24;
            this.Stock.Size = new System.Drawing.Size(1341, 255);
            this.Stock.TabIndex = 22;
            this.Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stock_CellClick);
            this.Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stock_CellContentClick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.price);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.idproduct);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.select);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox select;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.PictureBox Delete;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox show;
        private System.Windows.Forms.TextBox idproduct;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.DataGridView Stock;
    }
}