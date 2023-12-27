using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmTeacherPage : Form
    {
        int teacher_id;
        public static int studentNum;
       
        public FrmTeacherPage(int teacher_id)
        {
            InitializeComponent();
            this.teacher_id = teacher_id;
          
        }

        private void FrmTeacherPage_Load(object sender, EventArgs e)
        {
            GetMyInfo(teacher_id);
            GetAdvisorProcessors(teacher_id);

        }
        private void GetMyInfo(int teacher_id)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT T.TEACHER_ID,T.FName,T.LName,T.Mail,T.PHONE_NUMBER,T. ROOM_NUMBER, D.DEP_NAME,F.FACULTY_NAME
                    FROM A_TEACHER T JOIN A_DEPARTMENT D ON T.DEPARTMENT = D.DEP_ID JOIN A_FACULTY F ON D.FACULTY_ID = F.FACULTY_ID
                    WHERE T.TEACHER_ID = :teacher_id";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":teacher_id", OracleDbType.Int32).Value = teacher_id;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label_teacher_num.Text = reader["TEACHER_ID"].ToString();
                                label_name_surname.Text = $"{reader["FName"]} {reader["LName"]}";
                                label_room_num.Text = reader["ROOM_NUMBER"].ToString();
                                label_faculty.Text = reader["FACULTY_NAME"].ToString();
                                label_department.Text = reader["DEP_NAME"].ToString();
                                label_mail.Text = reader["Mail"].ToString();
                                label_phone_num.Text = reader["PHONE_NUMBER"].ToString();
                                label_my_courses.Text = reader["MY_Courses"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Your Information Not Found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }

        private void GetAdvisorProcessors(int teacher_id)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand())
                    {
                        command.Connection = connection;
                        string query = @"SELECT S.STUDENT_ID,S.FName,S.LName,IDENTITY_Num, Class_Num, S.Mail,S.PHONE_NUMBER
                                FROM A_STUDENT S 
                                WHERE S.TEACHER_ID = :teacher_id";
                        command.CommandText = query;
                        command.Parameters.Add(":teacher_id", OracleDbType.Int32).Value = teacher_id;

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_student_num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            studentNum = Convert.ToInt32(text_student_num.Text);
        }

        private void button_phptp_Click(object sender, EventArgs e)
        {
        //    openFileDialog1.ShowDialog();
        //    text_photo.Text = openFileDialog1.FileName;
        //    pictureBox_photo.ImageLocation = text_photo.Text;
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            FrmTeacherShowCourses a = new FrmTeacherShowCourses(studentNum);
            a.Show();
            this.Close();
            a.ShowCourses(studentNum);
        }
    }
}
