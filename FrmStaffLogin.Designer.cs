namespace WindowsFormsApp3
{
    partial class FrmStaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffLogin));
            this.StaffLoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.staffPasswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Showpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffLoginButton
            // 
            this.StaffLoginButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StaffLoginButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StaffLoginButton.Location = new System.Drawing.Point(374, 388);
            this.StaffLoginButton.Name = "StaffLoginButton";
            this.StaffLoginButton.Size = new System.Drawing.Size(131, 47);
            this.StaffLoginButton.TabIndex = 19;
            this.StaffLoginButton.Text = "Login";
            this.StaffLoginButton.UseVisualStyleBackColor = false;
            this.StaffLoginButton.Click += new System.EventHandler(this.StaffLoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1261, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student Management System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // staffPasswordTextBox
            // 
            this.staffPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffPasswordTextBox.Location = new System.Drawing.Point(239, 336);
            this.staffPasswordTextBox.Name = "staffPasswordTextBox";
            this.staffPasswordTextBox.Size = new System.Drawing.Size(168, 30);
            this.staffPasswordTextBox.TabIndex = 14;
            this.staffPasswordTextBox.UseSystemPasswordChar = true;
            this.staffPasswordTextBox.TextChanged += new System.EventHandler(this.staffPasswordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.Location = new System.Drawing.Point(239, 289);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(168, 30);
            this.usernameTextBox.TabIndex = 13;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(12, 183);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(43, 45);
            this.backButton.TabIndex = 51;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(1462, 841);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 52;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 34);
            this.label3.TabIndex = 57;
            this.label3.Text = "Aurora Borealis University";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(-55, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1546, 179);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Showpassword
            // 
            this.Showpassword.AutoSize = true;
            this.Showpassword.Location = new System.Drawing.Point(423, 342);
            this.Showpassword.Name = "Showpassword";
            this.Showpassword.Size = new System.Drawing.Size(125, 20);
            this.Showpassword.TabIndex = 58;
            this.Showpassword.Text = "Show Password";
            this.Showpassword.UseVisualStyleBackColor = true;
            // 
            // FrmStaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 724);
            this.Controls.Add(this.Showpassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.StaffLoginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.staffPasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StaffLoginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffPasswordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Showpassword;
    }
}