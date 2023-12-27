namespace WindowsFormsApp3
{
    partial class FrmTeacherPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacherPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_name_surname = new System.Windows.Forms.TextBox();
            this.text_student_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_my_courses = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_phone_num = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_department = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_room_num = new System.Windows.Forms.Label();
            this.label_name_surname = new System.Windows.Forms.Label();
            this.label_teacher_num = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1369, 179);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aurora Borealis University";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button_update);
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Controls.Add(this.text_name_surname);
            this.tabPage7.Controls.Add(this.text_student_num);
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1190, 451);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Advisor Processors";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(999, 112);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(155, 30);
            this.button_update.TabIndex = 16;
            this.button_update.Text = "Show Courses";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // text_name_surname
            // 
            this.text_name_surname.Location = new System.Drawing.Point(204, 86);
            this.text_name_surname.Name = "text_name_surname";
            this.text_name_surname.Size = new System.Drawing.Size(140, 30);
            this.text_name_surname.TabIndex = 9;
            // 
            // text_student_num
            // 
            this.text_student_num.Location = new System.Drawing.Point(204, 33);
            this.text_student_num.Name = "text_student_num";
            this.text_student_num.Size = new System.Drawing.Size(140, 30);
            this.text_student_num.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name Surname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Student Number:";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1190, 451);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Examination Date Assignment";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1190, 451);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Grading";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1190, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Absence of Attendance";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1190, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Course Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1190, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_my_courses);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label_phone_num);
            this.tabPage1.Controls.Add(this.label_mail);
            this.tabPage1.Controls.Add(this.label_department);
            this.tabPage1.Controls.Add(this.label_faculty);
            this.tabPage1.Controls.Add(this.label_room_num);
            this.tabPage1.Controls.Add(this.label_name_surname);
            this.tabPage1.Controls.Add(this.label_teacher_num);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.printPreviewControl1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label_my_courses
            // 
            this.label_my_courses.AutoSize = true;
            this.label_my_courses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_my_courses.Location = new System.Drawing.Point(238, 363);
            this.label_my_courses.Name = "label_my_courses";
            this.label_my_courses.Size = new System.Drawing.Size(70, 22);
            this.label_my_courses.TabIndex = 22;
            this.label_my_courses.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(69, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "My Courses:";
            // 
            // label_phone_num
            // 
            this.label_phone_num.AutoSize = true;
            this.label_phone_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_phone_num.Location = new System.Drawing.Point(238, 306);
            this.label_phone_num.Name = "label_phone_num";
            this.label_phone_num.Size = new System.Drawing.Size(70, 22);
            this.label_phone_num.TabIndex = 20;
            this.label_phone_num.Text = "label15";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mail.Location = new System.Drawing.Point(238, 256);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(70, 22);
            this.label_mail.TabIndex = 19;
            this.label_mail.Text = "label14";
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_department.Location = new System.Drawing.Point(238, 210);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(70, 22);
            this.label_department.TabIndex = 18;
            this.label_department.Text = "label13";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_faculty.Location = new System.Drawing.Point(238, 164);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(70, 22);
            this.label_faculty.TabIndex = 17;
            this.label_faculty.Text = "label12";
            // 
            // label_room_num
            // 
            this.label_room_num.AutoSize = true;
            this.label_room_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_room_num.Location = new System.Drawing.Point(238, 122);
            this.label_room_num.Name = "label_room_num";
            this.label_room_num.Size = new System.Drawing.Size(69, 22);
            this.label_room_num.TabIndex = 16;
            this.label_room_num.Text = "label11";
            // 
            // label_name_surname
            // 
            this.label_name_surname.AutoSize = true;
            this.label_name_surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name_surname.Location = new System.Drawing.Point(238, 83);
            this.label_name_surname.Name = "label_name_surname";
            this.label_name_surname.Size = new System.Drawing.Size(70, 22);
            this.label_name_surname.TabIndex = 15;
            this.label_name_surname.Text = "label10";
            // 
            // label_teacher_num
            // 
            this.label_teacher_num.AutoSize = true;
            this.label_teacher_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_teacher_num.Location = new System.Drawing.Point(238, 44);
            this.label_teacher_num.Name = "label_teacher_num";
            this.label_teacher_num.Size = new System.Drawing.Size(60, 22);
            this.label_teacher_num.TabIndex = 14;
            this.label_teacher_num.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(69, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Faculty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher Number:";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(73, 83);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(60, 22);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 196);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1198, 486);
            this.tabControl1.TabIndex = 10;
            // 
            // FrmTeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 686);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTeacherPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeacherPage";
            this.Load += new System.EventHandler(this.FrmTeacherPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_name_surname;
        private System.Windows.Forms.TextBox text_student_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_phone_num;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_room_num;
        private System.Windows.Forms.Label label_name_surname;
        private System.Windows.Forms.Label label_teacher_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label_my_courses;
        private System.Windows.Forms.Label label11;
    }
}