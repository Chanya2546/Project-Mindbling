namespace EditMindTwinkle
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.TextBox();
            this.dataorder = new System.Windows.Forms.DataGridView();
            this.confirm = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 875);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(36, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 43);
            this.label5.TabIndex = 33;
            this.label5.Text = "<";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tel
            // 
            this.Tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.Tel.Location = new System.Drawing.Point(583, 139);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(513, 59);
            this.Tel.TabIndex = 34;
            this.Tel.TextChanged += new System.EventHandler(this.Tel_TextChanged);
            // 
            // dataorder
            // 
            this.dataorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataorder.BackgroundColor = System.Drawing.Color.White;
            this.dataorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataorder.Location = new System.Drawing.Point(302, 215);
            this.dataorder.Name = "dataorder";
            this.dataorder.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataorder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataorder.RowTemplate.Height = 24;
            this.dataorder.Size = new System.Drawing.Size(732, 499);
            this.dataorder.TabIndex = 35;
            this.dataorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataorder_CellClick);
            this.dataorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataorder_CellContentClick);
            this.dataorder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataorder_RowHeaderMouseClick);
            // 
            // confirm
            // 
            this.confirm.Image = ((System.Drawing.Image)(resources.GetObject("confirm.Image")));
            this.confirm.Location = new System.Drawing.Point(686, 741);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(270, 94);
            this.confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirm.TabIndex = 37;
            this.confirm.TabStop = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Username.Font = new System.Drawing.Font("Angsana New", 23F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(1196, 19);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(133, 54);
            this.Username.TabIndex = 38;
            this.Username.Text = "Username";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1047, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(289, 499);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.dataorder);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.DataGridView dataorder;
        private System.Windows.Forms.PictureBox confirm;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}