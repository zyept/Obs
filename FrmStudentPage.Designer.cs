namespace WindowsFormsApp3
{
    partial class FrmStudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.labelStudentNum = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelsPhone = new System.Windows.Forms.Label();
            this.labelsMail = new System.Windows.Forms.Label();
            this.labelsDep = new System.Windows.Forms.Label();
            this.labelsFaculty = new System.Windows.Forms.Label();
            this.labelsNameSurname = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelroomnum = new System.Windows.Forms.Label();
            this.labelaphone = new System.Windows.Forms.Label();
            this.labelamail = new System.Windows.Forms.Label();
            this.labeladep = new System.Windows.Forms.Label();
            this.labelafaculty = new System.Windows.Forms.Label();
            this.labelaname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.classcombobox = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.scomboBox = new System.Windows.Forms.ComboBox();
            this.ccomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addcoursebutton = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(-3, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.labelStudentNum);
            this.tabpage1.Controls.Add(this.label21);
            this.tabpage1.Controls.Add(this.labelsPhone);
            this.tabpage1.Controls.Add(this.labelsMail);
            this.tabpage1.Controls.Add(this.labelsDep);
            this.tabpage1.Controls.Add(this.labelsFaculty);
            this.tabpage1.Controls.Add(this.labelsNameSurname);
            this.tabpage1.Controls.Add(this.label15);
            this.tabpage1.Controls.Add(this.label16);
            this.tabpage1.Controls.Add(this.label17);
            this.tabpage1.Controls.Add(this.label18);
            this.tabpage1.Controls.Add(this.label19);
            this.tabpage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabpage1.Location = new System.Drawing.Point(4, 25);
            this.tabpage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabpage1.Size = new System.Drawing.Size(1248, 551);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Student Information";
            this.tabpage1.UseVisualStyleBackColor = true;
            this.tabpage1.Click += new System.EventHandler(this.tabpage1_Click);
            // 
            // labelStudentNum
            // 
            this.labelStudentNum.AutoSize = true;
            this.labelStudentNum.Location = new System.Drawing.Point(279, 63);
            this.labelStudentNum.Name = "labelStudentNum";
            this.labelStudentNum.Size = new System.Drawing.Size(60, 22);
            this.labelStudentNum.TabIndex = 25;
            this.labelStudentNum.Text = "label8";
            this.labelStudentNum.Click += new System.EventHandler(this.labelStudentNum_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(113, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 22);
            this.label21.TabIndex = 24;
            this.label21.Text = "Student Number:";
            // 
            // labelsPhone
            // 
            this.labelsPhone.AutoSize = true;
            this.labelsPhone.Location = new System.Drawing.Point(280, 228);
            this.labelsPhone.Name = "labelsPhone";
            this.labelsPhone.Size = new System.Drawing.Size(70, 22);
            this.labelsPhone.TabIndex = 22;
            this.labelsPhone.Text = "label12";
            // 
            // labelsMail
            // 
            this.labelsMail.AutoSize = true;
            this.labelsMail.Location = new System.Drawing.Point(279, 192);
            this.labelsMail.Name = "labelsMail";
            this.labelsMail.Size = new System.Drawing.Size(69, 22);
            this.labelsMail.TabIndex = 21;
            this.labelsMail.Text = "label11";
            // 
            // labelsDep
            // 
            this.labelsDep.AutoSize = true;
            this.labelsDep.Location = new System.Drawing.Point(279, 160);
            this.labelsDep.Name = "labelsDep";
            this.labelsDep.Size = new System.Drawing.Size(70, 22);
            this.labelsDep.TabIndex = 20;
            this.labelsDep.Text = "label10";
            // 
            // labelsFaculty
            // 
            this.labelsFaculty.AutoSize = true;
            this.labelsFaculty.Location = new System.Drawing.Point(279, 127);
            this.labelsFaculty.Name = "labelsFaculty";
            this.labelsFaculty.Size = new System.Drawing.Size(60, 22);
            this.labelsFaculty.TabIndex = 19;
            this.labelsFaculty.Text = "label9";
            // 
            // labelsNameSurname
            // 
            this.labelsNameSurname.AutoSize = true;
            this.labelsNameSurname.Location = new System.Drawing.Point(279, 94);
            this.labelsNameSurname.Name = "labelsNameSurname";
            this.labelsNameSurname.Size = new System.Drawing.Size(60, 22);
            this.labelsNameSurname.TabIndex = 18;
            this.labelsNameSurname.Text = "label8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 22);
            this.label15.TabIndex = 16;
            this.label15.Text = "Phone:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 22);
            this.label16.TabIndex = 15;
            this.label16.Text = "Mail:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 22);
            this.label17.TabIndex = 14;
            this.label17.Text = "Department:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 13;
            this.label18.Text = "Faculty:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(117, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 22);
            this.label19.TabIndex = 12;
            this.label19.Text = "Name Surname:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelroomnum);
            this.tabPage2.Controls.Add(this.labelaphone);
            this.tabPage2.Controls.Add(this.labelamail);
            this.tabPage2.Controls.Add(this.labeladep);
            this.tabPage2.Controls.Add(this.labelafaculty);
            this.tabPage2.Controls.Add(this.labelaname);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1248, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advisor Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // labelroomnum
            // 
            this.labelroomnum.AutoSize = true;
            this.labelroomnum.Location = new System.Drawing.Point(341, 243);
            this.labelroomnum.Name = "labelroomnum";
            this.labelroomnum.Size = new System.Drawing.Size(70, 22);
            this.labelroomnum.TabIndex = 11;
            this.labelroomnum.Text = "label13";
            // 
            // labelaphone
            // 
            this.labelaphone.AutoSize = true;
            this.labelaphone.Location = new System.Drawing.Point(342, 210);
            this.labelaphone.Name = "labelaphone";
            this.labelaphone.Size = new System.Drawing.Size(70, 22);
            this.labelaphone.TabIndex = 10;
            this.labelaphone.Text = "label12";
            // 
            // labelamail
            // 
            this.labelamail.AutoSize = true;
            this.labelamail.Location = new System.Drawing.Point(341, 174);
            this.labelamail.Name = "labelamail";
            this.labelamail.Size = new System.Drawing.Size(69, 22);
            this.labelamail.TabIndex = 9;
            this.labelamail.Text = "label11";
            // 
            // labeladep
            // 
            this.labeladep.AutoSize = true;
            this.labeladep.Location = new System.Drawing.Point(341, 142);
            this.labeladep.Name = "labeladep";
            this.labeladep.Size = new System.Drawing.Size(70, 22);
            this.labeladep.TabIndex = 8;
            this.labeladep.Text = "label10";
            // 
            // labelafaculty
            // 
            this.labelafaculty.AutoSize = true;
            this.labelafaculty.Location = new System.Drawing.Point(341, 109);
            this.labelafaculty.Name = "labelafaculty";
            this.labelafaculty.Size = new System.Drawing.Size(60, 22);
            this.labelafaculty.TabIndex = 7;
            this.labelafaculty.Text = "label9";
            // 
            // labelaname
            // 
            this.labelaname.AutoSize = true;
            this.labelaname.Location = new System.Drawing.Point(341, 76);
            this.labelaname.Name = "labelaname";
            this.labelaname.Size = new System.Drawing.Size(60, 22);
            this.labelaname.TabIndex = 6;
            this.labelaname.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Faculty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Surname:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1248, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registered Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(52, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(637, 356);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.classcombobox);
            this.tabPage4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1248, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Department Courses";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(178, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 323);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Class:";
            // 
            // classcombobox
            // 
            this.classcombobox.FormattingEnabled = true;
            this.classcombobox.Location = new System.Drawing.Point(218, 69);
            this.classcombobox.Name = "classcombobox";
            this.classcombobox.Size = new System.Drawing.Size(220, 30);
            this.classcombobox.TabIndex = 1;
            this.classcombobox.SelectedIndexChanged += new System.EventHandler(this.classcombobox_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1248, 551);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Time Table";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.scomboBox);
            this.tabPage6.Controls.Add(this.ccomboBox);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.deletebutton);
            this.tabPage6.Controls.Add(this.addcoursebutton);
            this.tabPage6.Controls.Add(this.dataGridView4);
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1248, 551);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Course Registration";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Finalize";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scomboBox
            // 
            this.scomboBox.FormattingEnabled = true;
            this.scomboBox.Location = new System.Drawing.Point(150, 80);
            this.scomboBox.Name = "scomboBox";
            this.scomboBox.Size = new System.Drawing.Size(169, 30);
            this.scomboBox.TabIndex = 7;
            this.scomboBox.SelectedIndexChanged += new System.EventHandler(this.scomboBox_SelectedIndexChanged);
            // 
            // ccomboBox
            // 
            this.ccomboBox.FormattingEnabled = true;
            this.ccomboBox.Location = new System.Drawing.Point(150, 44);
            this.ccomboBox.Name = "ccomboBox";
            this.ccomboBox.Size = new System.Drawing.Size(169, 30);
            this.ccomboBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Class:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Semester:";
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(626, 390);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(98, 30);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addcoursebutton
            // 
            this.addcoursebutton.Location = new System.Drawing.Point(626, 325);
            this.addcoursebutton.Name = "addcoursebutton";
            this.addcoursebutton.Size = new System.Drawing.Size(98, 30);
            this.addcoursebutton.TabIndex = 2;
            this.addcoursebutton.Text = "Add";
            this.addcoursebutton.UseVisualStyleBackColor = true;
            this.addcoursebutton.Click += new System.EventHandler(this.addcoursebutton_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(773, 135);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(426, 323);
            this.dataGridView4.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(565, 320);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage7
            // 
            this.tabPage7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1248, 551);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "List of Grades";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1248, 551);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Transcript";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aurora Borealis University";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(-48, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1546, 179);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // FrmStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 724);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmStudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentPage";
            this.Load += new System.EventHandler(this.FrmStudentPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label labelamail;
        private System.Windows.Forms.Label labeladep;
        private System.Windows.Forms.Label labelafaculty;
        private System.Windows.Forms.Label labelaname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelroomnum;
        private System.Windows.Forms.Label labelaphone;
        private System.Windows.Forms.Label labelsPhone;
        private System.Windows.Forms.Label labelsMail;
        private System.Windows.Forms.Label labelsDep;
        private System.Windows.Forms.Label labelsFaculty;
        private System.Windows.Forms.Label labelsNameSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelStudentNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox classcombobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addcoursebutton;
        private System.Windows.Forms.ComboBox scomboBox;
        private System.Windows.Forms.ComboBox ccomboBox;
        private System.Windows.Forms.Label label10;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Button button1;
    }
}