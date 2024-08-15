namespace EditMindTwinkle
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signin = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.nonsee = new System.Windows.Forms.PictureBox();
            this.see = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonsee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.see)).BeginInit();
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
            // signin
            // 
            this.signin.Image = ((System.Drawing.Image)(resources.GetObject("signin.Image")));
            this.signin.Location = new System.Drawing.Point(868, 520);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(270, 94);
            this.signin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signin.TabIndex = 10;
            this.signin.TabStop = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // create
            // 
            this.create.AutoSize = true;
            this.create.BackColor = System.Drawing.Color.White;
            this.create.Font = new System.Drawing.Font("Angsana New", 25F);
            this.create.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.create.Location = new System.Drawing.Point(918, 617);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(189, 57);
            this.create.TabIndex = 11;
            this.create.Text = "Create account";
            this.create.Click += new System.EventHandler(this.create_Click);
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
            this.label.TabIndex = 12;
            this.label.Text = "<";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("DilleniaUPC", 26F);
            this.Username.Location = new System.Drawing.Point(788, 320);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(418, 57);
            this.Username.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("DilleniaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(788, 459);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(418, 40);
            this.Password.TabIndex = 14;
            this.Password.UseSystemPasswordChar = true;
            // 
            // nonsee
            // 
            this.nonsee.Image = ((System.Drawing.Image)(resources.GetObject("nonsee.Image")));
            this.nonsee.Location = new System.Drawing.Point(1226, 459);
            this.nonsee.Name = "nonsee";
            this.nonsee.Size = new System.Drawing.Size(72, 28);
            this.nonsee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nonsee.TabIndex = 15;
            this.nonsee.TabStop = false;
            this.nonsee.Click += new System.EventHandler(this.nonsee_Click);
            // 
            // see
            // 
            this.see.Image = ((System.Drawing.Image)(resources.GetObject("see.Image")));
            this.see.Location = new System.Drawing.Point(1226, 459);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(72, 28);
            this.see.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.see.TabIndex = 16;
            this.see.TabStop = false;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 875);
            this.Controls.Add(this.see);
            this.Controls.Add(this.nonsee);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label);
            this.Controls.Add(this.create);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonsee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.see)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox signin;
        private System.Windows.Forms.Label create;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox nonsee;
        private System.Windows.Forms.PictureBox see;
    }
}