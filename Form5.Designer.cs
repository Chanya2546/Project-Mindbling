namespace EditMindTwinkle
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.PictureBox();
            this.TelText = new System.Windows.Forms.TextBox();
            this.id_member = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.AddText = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVE)).BeginInit();
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Angsana New", 19F);
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(35, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 43);
            this.label.TabIndex = 9;
            this.label.Text = "<";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // SAVE
            // 
            this.SAVE.Image = ((System.Drawing.Image)(resources.GetObject("SAVE.Image")));
            this.SAVE.Location = new System.Drawing.Point(724, 700);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(270, 94);
            this.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SAVE.TabIndex = 10;
            this.SAVE.TabStop = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // TelText
            // 
            this.TelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.TelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelText.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.TelText.Location = new System.Drawing.Point(888, 466);
            this.TelText.Name = "TelText";
            this.TelText.Size = new System.Drawing.Size(432, 59);
            this.TelText.TabIndex = 11;
            this.TelText.TextChanged += new System.EventHandler(this.TelText_TextChanged);
            // 
            // id_member
            // 
            this.id_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.id_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_member.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.id_member.Location = new System.Drawing.Point(393, 240);
            this.id_member.Name = "id_member";
            this.id_member.ReadOnly = true;
            this.id_member.Size = new System.Drawing.Size(432, 59);
            this.id_member.TabIndex = 12;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.NameText.Location = new System.Drawing.Point(888, 240);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(432, 59);
            this.NameText.TabIndex = 13;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.EmailText.Location = new System.Drawing.Point(393, 466);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(432, 59);
            this.EmailText.TabIndex = 14;
            // 
            // AddText
            // 
            this.AddText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.AddText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddText.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.AddText.Location = new System.Drawing.Point(393, 578);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(930, 59);
            this.AddText.TabIndex = 15;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("DilleniaUPC", 27F);
            this.Username.Location = new System.Drawing.Point(393, 353);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(418, 59);
            this.Username.TabIndex = 16;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.Password.Location = new System.Drawing.Point(888, 354);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(418, 57);
            this.Password.TabIndex = 17;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.id_member);
            this.Controls.Add(this.TelText);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox SAVE;
        private System.Windows.Forms.TextBox TelText;
        private System.Windows.Forms.TextBox id_member;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox AddText;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
    }
}