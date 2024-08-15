namespace EditMindTwinkle
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showdata = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.daysell = new System.Windows.Forms.Label();
            this.monthsell = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.label1.Font = new System.Drawing.Font("Angsana New", 31F);
            this.label1.Location = new System.Drawing.Point(96, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.label2.Font = new System.Drawing.Font("Angsana New", 31F);
            this.label2.Location = new System.Drawing.Point(189, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales recap";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.label3.Font = new System.Drawing.Font("Angsana New", 31F);
            this.label3.Location = new System.Drawing.Point(279, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 70);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.label4.Font = new System.Drawing.Font("Angsana New", 31F);
            this.label4.Location = new System.Drawing.Point(618, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 70);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order cancel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(183)))));
            this.label5.Font = new System.Drawing.Font("Angsana New", 31F);
            this.label5.Location = new System.Drawing.Point(893, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 70);
            this.label5.TabIndex = 5;
            this.label5.Text = "Membership information";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 43);
            this.label6.TabIndex = 7;
            this.label6.Text = "<";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(1350, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 43);
            this.label7.TabIndex = 8;
            this.label7.Text = "i";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // showdata
            // 
            this.showdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showdata.BackgroundColor = System.Drawing.Color.White;
            this.showdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Location = new System.Drawing.Point(83, 393);
            this.showdata.Name = "showdata";
            this.showdata.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.showdata.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showdata.RowTemplate.Height = 24;
            this.showdata.Size = new System.Drawing.Size(1208, 383);
            this.showdata.TabIndex = 9;
            this.showdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdata_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("DilleniaUPC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 321);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 56);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("DilleniaUPC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(499, 321);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(400, 56);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // daysell
            // 
            this.daysell.AutoSize = true;
            this.daysell.BackColor = System.Drawing.Color.White;
            this.daysell.Font = new System.Drawing.Font("Angsana New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.daysell.Location = new System.Drawing.Point(339, 774);
            this.daysell.Name = "daysell";
            this.daysell.Size = new System.Drawing.Size(137, 83);
            this.daysell.TabIndex = 30;
            this.daysell.Text = "label1";
            this.daysell.Click += new System.EventHandler(this.daysell_Click);
            // 
            // monthsell
            // 
            this.monthsell.AutoSize = true;
            this.monthsell.BackColor = System.Drawing.Color.White;
            this.monthsell.Font = new System.Drawing.Font("Angsana New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.monthsell.Location = new System.Drawing.Point(991, 774);
            this.monthsell.Name = "monthsell";
            this.monthsell.Size = new System.Drawing.Size(137, 83);
            this.monthsell.TabIndex = 31;
            this.monthsell.Text = "label1";
            this.monthsell.Click += new System.EventHandler(this.monthsell_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-58, 779);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1339, 69);
            this.label8.TabIndex = 32;
            this.label8.Text = ".............................................................................";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("DilleniaUPC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(845, 321);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(446, 57);
            this.search.TabIndex = 33;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.monthsell);
            this.Controls.Add(this.daysell);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView showdata;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label daysell;
        private System.Windows.Forms.Label monthsell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search;
    }
}