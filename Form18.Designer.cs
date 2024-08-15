namespace EditMindTwinkle
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idorder = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 875);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idorder
            // 
            this.idorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.idorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idorder.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.idorder.Location = new System.Drawing.Point(701, 372);
            this.idorder.Name = "idorder";
            this.idorder.Size = new System.Drawing.Size(513, 59);
            this.idorder.TabIndex = 35;
            this.idorder.TextChanged += new System.EventHandler(this.idorder_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Image = ((System.Drawing.Image)(resources.GetObject("confirm.Image")));
            this.confirm.Location = new System.Drawing.Point(839, 496);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(270, 94);
            this.confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirm.TabIndex = 36;
            this.confirm.TabStop = false;
            this.confirm.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(36, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 43);
            this.label.TabIndex = 37;
            this.label.Text = "<";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.label);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.idorder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form18";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idorder;
        private System.Windows.Forms.PictureBox confirm;
        private System.Windows.Forms.Label label;
    }
}