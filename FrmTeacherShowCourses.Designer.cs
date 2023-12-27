namespace WindowsFormsApp3
{
    partial class FrmTeacherShowCourses
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
            this.coursedataGridView = new System.Windows.Forms.DataGridView();
            this.ApproveChechBox = new System.Windows.Forms.CheckBox();
            this.rejectCheckBox = new System.Windows.Forms.CheckBox();
            this.text_student_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // coursedataGridView
            // 
            this.coursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursedataGridView.Location = new System.Drawing.Point(26, 122);
            this.coursedataGridView.Name = "coursedataGridView";
            this.coursedataGridView.RowHeadersWidth = 51;
            this.coursedataGridView.RowTemplate.Height = 24;
            this.coursedataGridView.Size = new System.Drawing.Size(826, 413);
            this.coursedataGridView.TabIndex = 1;
            this.coursedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ApproveChechBox
            // 
            this.ApproveChechBox.AutoSize = true;
            this.ApproveChechBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ApproveChechBox.Location = new System.Drawing.Point(657, 557);
            this.ApproveChechBox.Name = "ApproveChechBox";
            this.ApproveChechBox.Size = new System.Drawing.Size(102, 26);
            this.ApproveChechBox.TabIndex = 2;
            this.ApproveChechBox.Text = "Approve";
            this.ApproveChechBox.UseVisualStyleBackColor = true;
            this.ApproveChechBox.CheckedChanged += new System.EventHandler(this.ApproveChechBox_CheckedChanged);
            // 
            // rejectCheckBox
            // 
            this.rejectCheckBox.AutoSize = true;
            this.rejectCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rejectCheckBox.Location = new System.Drawing.Point(781, 557);
            this.rejectCheckBox.Name = "rejectCheckBox";
            this.rejectCheckBox.Size = new System.Drawing.Size(83, 26);
            this.rejectCheckBox.TabIndex = 3;
            this.rejectCheckBox.Text = "Reject";
            this.rejectCheckBox.UseVisualStyleBackColor = true;
            this.rejectCheckBox.CheckedChanged += new System.EventHandler(this.rejectCheckBox_CheckedChanged);
            // 
            // text_student_num
            // 
            this.text_student_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_student_num.Location = new System.Drawing.Point(182, 50);
            this.text_student_num.Name = "text_student_num";
            this.text_student_num.Size = new System.Drawing.Size(140, 30);
            this.text_student_num.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Student Number:";
            // 
            // FrmTeacherShowCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 596);
            this.Controls.Add(this.text_student_num);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rejectCheckBox);
            this.Controls.Add(this.ApproveChechBox);
            this.Controls.Add(this.coursedataGridView);
            this.Name = "FrmTeacherShowCourses";
            this.Text = "FrmTeacherShowCourses";
            this.Load += new System.EventHandler(this.FrmTeacherShowCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coursedataGridView;
        private System.Windows.Forms.CheckBox ApproveChechBox;
        private System.Windows.Forms.CheckBox rejectCheckBox;
        private System.Windows.Forms.TextBox text_student_num;
        private System.Windows.Forms.Label label9;
    }
}