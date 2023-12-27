using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmStudentPage : Form
    {
        int studentNum;

        public FrmStudentPage(int studentNum)
        {
            InitializeComponent();
            this.studentNum = studentNum;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmStudentPage_Load(object sender, EventArgs e)
        {
            GetStudentInfo(studentNum);
            GetAdvisorInfo(studentNum);
            GetDepartmentCourse(studentNum);
            GetClassFromDatabase(studentNum);


        }

        private void GetClassFromDatabase(int studentNumber)
        {
            using (OracleConnection baglanti = new OracleConnection(@"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;"))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT DEP_YEAR FROM A_STUDENT S JOIN A_DEPARTMENT D ON (S.DEPARTMENT_ID=D.DEP_ID) where student_id=:studentNumber";

                    using (OracleCommand komut = new OracleCommand(sorgu, baglanti))
                    {
                        komut.Parameters.Add(":studentNumber", OracleDbType.Int32).Value = studentNumber;
                        using (OracleDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int year = Convert.ToInt32(reader["DEP_YEAR"].ToString());
                                for (int i = 1; i <= year; i++)
                                {
                                    ccomboBox.Items.Add(i);

                                }
                                scomboBox.Items.Add("Fall");
                                scomboBox.Items.Add("Spring");

                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Hatası: " + ex.Message);
                }
            }
        }

        private void GetStudentInfo(int studentNumber)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT S.STUDENT_ID,S.FName,S.LName,S.Mail,S.PHONE_NUMBER,D.DEP_NAME,F.FACULTY_NAME
                    FROM A_STUDENT S JOIN A_DEPARTMENT D ON S.DEPARTMENT_ID = D.DEP_ID JOIN A_FACULTY F ON D.FACULTY_ID = F.FACULTY_ID
                    WHERE S.STUDENT_ID = :studentNumber";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":studentNumber", OracleDbType.Int32).Value = studentNumber;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labelStudentNum.Text = reader["STUDENT_ID"].ToString();
                                labelsNameSurname.Text = $"{reader["FName"]} {reader["LName"]}";
                                labelsFaculty.Text = reader["FACULTY_NAME"].ToString();
                                labelsDep.Text = reader["DEP_NAME"].ToString();
                                labelsMail.Text = reader["Mail"].ToString();
                                labelsPhone.Text = reader["PHONE_NUMBER"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci bilgileri bulunamadı.");
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

        private void GetAdvisorInfo(int studentNumber)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query = @"SELECT A.FName || ' ' || A.LName AS FULL_NAME,A.Mail,A.Phone_NUMBER,D.DEP_NAME,F.FACULTY_NAME,A.ROOM_NUMBER
                    FROM A_STUDENT S JOIN A_TEACHER A ON S.TEACHER_ID = A.TEACHER_ID
                    JOIN A_DEPARTMENT D ON A.DEPARTMENT = D.DEP_ID
                    JOIN A_FACULTY F ON D.FACULTY_ID = F.FACULTY_ID
                    WHERE S.STUDENT_ID = :studentNumber";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":studentNumber", OracleDbType.Int32).Value = studentNumber;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labelaname.Text = reader["FULL_NAME"].ToString();
                                labelamail.Text = reader["Mail"].ToString();
                                labelaphone.Text = reader["Phone_number"].ToString();
                                labeladep.Text = reader["DEP_NAME"].ToString();
                                labelafaculty.Text = reader["FACULTY_NAME"].ToString();
                                labelroomnum.Text = reader["ROOM_NUMBER"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Danışman bilgileri bulunamadı.");
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

        private void GetDepartmentCourse(int studentNumber)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryDepartmentAndYear = "SELECT d.DEP_ID, d.DEP_YEAR FROM A_STUDENT s INNER JOIN A_DEPARTMENT d ON s.DEPARTMENT_ID = d.DEP_ID WHERE s.STUDENT_ID = :studentId";

                    using (OracleCommand cmdDepartmentAndYear = new OracleCommand(queryDepartmentAndYear, connection))
                    {
                        cmdDepartmentAndYear.Parameters.Add(":studentId", OracleDbType.Int32).Value = studentNumber;

                        using (OracleDataReader readerDepartmentAndYear = cmdDepartmentAndYear.ExecuteReader())
                        {
                            if (readerDepartmentAndYear.Read())
                            {
                                int departmentYear = Convert.ToInt32(readerDepartmentAndYear["DEP_YEAR"]);
                                for (int i = 1; i <= departmentYear; i++)
                                {
                                    classcombobox.Items.Add(i);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void labelStudentNum_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void classcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryDepartment = "SELECT DEPARTMENT_ID FROM A_STUDENT WHERE STUDENT_ID = :studentId";

                    using (OracleCommand cmdDepartment = new OracleCommand(queryDepartment, connection))
                    {
                        cmdDepartment.Parameters.Add(":studentId", OracleDbType.Int32).Value = studentNum;

                        using (OracleDataReader readerDepartment = cmdDepartment.ExecuteReader())
                        {
                            if (readerDepartment.Read())
                            {
                                int departmentId = Convert.ToInt32(readerDepartment["DEPARTMENT_ID"]);
                                string selectedClass = Convert.ToString(classcombobox.SelectedItem);
                                string queryCourses = "SELECT COURSE_CODE,COURSE_NAME,CREDIT,AKTS FROM A_Course WHERE department_id = :departmentId AND classnum = :classNum";

                                using (OracleCommand cmdCourses = new OracleCommand(queryCourses, connection))
                                {
                                    cmdCourses.Parameters.Add(":departmentId", OracleDbType.Int32).Value = departmentId;
                                    cmdCourses.Parameters.Add(":classNum", OracleDbType.Varchar2).Value = selectedClass;

                                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmdCourses))
                                    {
                                        DataTable dt = new DataTable();
                                        adapter.Fill(dt);
                                        dataGridView1.DataSource = dt;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tabpage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    string year = ccomboBox.SelectedItem.ToString();
                    string semester = scomboBox.SelectedItem.ToString();

                    connection.Open();
                    string queryDepartment = "SELECT COURSE_CODE,COURSE_NAME, CREDIT, AKTS " +
                        "FROM A_COURSE WHERE Department_id=(SELECT DEPARTMENT_ID FROM A_STUDENT WHERE STUDENT_ID=:studentId)  AND classnum = :year AND semester = :semester";

                    using (OracleCommand cmdDepartment = new OracleCommand(queryDepartment, connection))
                    {
                        cmdDepartment.Parameters.Add(":studentId", OracleDbType.Int32).Value = studentNum;
                        cmdDepartment.Parameters.Add(":year", OracleDbType.Varchar2).Value = year;
                        cmdDepartment.Parameters.Add(":semester", OracleDbType.Varchar2).Value = semester;

                        using (OracleDataReader readerDepartment = cmdDepartment.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(readerDepartment);
                            dataGridView3.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void addcoursebutton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView3.SelectedRows;

            // DataGridView4'ün mevcut DataSource'ını al
            DataTable dt = dataGridView4.DataSource as DataTable;

            // Eğer mevcut DataSource null ise, yeni bir DataTable oluştur
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("COURSE_CODE");
                dt.Columns.Add("COURSE_NAME");
                dt.Columns.Add("CREDIT");
                dt.Columns.Add("AKTS");
            }

            // Seçili satırları DataTable'a ekle
            foreach (DataGridViewRow row in selectedRows)
            {
                DataRow dr = dt.NewRow();
                dr["COURSE_CODE"] = row.Cells["COURSE_CODE"].Value.ToString();
                dr["COURSE_NAME"] = row.Cells["COURSE_NAME"].Value.ToString();
                dr["CREDIT"] = row.Cells["CREDIT"].Value.ToString();
                dr["AKTS"] = row.Cells["AKTS"].Value.ToString();
                dt.Rows.Add(dr);
            }

            // DataTable'ı dataGridView4'e atanarak veriyi ekleyin
            dataGridView4.DataSource = dt;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            // Seçili satırları al
            DataGridViewSelectedRowCollection selectedRows = dataGridView4.SelectedRows;

            

            // Silme işlemini onaylamak için kullanıcıya bir ileti göster
            DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Seçili satırları dataGridView4'ten kaldır
                foreach (DataGridViewRow row in selectedRows)
                {
                    dataGridView4.Rows.Remove(row);
                }
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

        //    using (OracleConnection connection = new OracleConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            // DataGridView4'ten verileri al
        //            DataTable dt = dataGridView4.DataSource as DataTable;

        //            if (dt != null && dt.Rows.Count > 0)
        //            {
        //                foreach (DataRow row in dt.Rows)
        //                {
        //                    // Örnek tablo adı ve sütun adlarına göre SQL sorgusunu düzenleyin
        //                    string insertQuery = "INSERT INTO A_STUDENT (COURSE_CODE, COURSE_NAME, CREDIT, AKTS) " +
        //                        "VALUES (:courseCode, :courseName, :credit, :akts)";

        //                    using (OracleCommand cmdInsert = new OracleCommand(insertQuery, connection))
        //                    {
        //                        cmdInsert.Parameters.Add(":courseCode", OracleDbType.Varchar2).Value = row["COURSE_code"].ToString();
        //                        cmdInsert.Parameters.Add(":courseName", OracleDbType.Varchar2).Value = row["COURSE_name"].ToString();
        //                        cmdInsert.Parameters.Add(":credit", OracleDbType.Decimal).Value = row["CREDIT"];
        //                        cmdInsert.Parameters.Add(":akts", OracleDbType.Decimal).Value = row["AKTS"];


        //                        cmdInsert.ExecuteNonQuery();
        //                    }
        //                }

        //                MessageBox.Show("Veriler başarıyla eklendi.");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Eklenacak veri bulunmamaktadır.");
        //            }
        //        }
        //        //catch (Exception ex)
        //        //{
        //        //    MessageBox.Show("Error: " + ex.Message);
        //        //}
        //        catch (OracleException ex)
        //        {
        //            MessageBox.Show("Oracle Hatası: " + ex.Message + "\n" + ex.StackTrace);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Genel Hata: " + ex.Message + "\n" + ex.StackTrace);
        //        }


        //    }
        //}


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

        //    using (OracleConnection connection = new OracleConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            foreach (DataGridViewRow row in dataGridView4.Rows)
        //            {
        //                string courseCode = row.Cells["COURSE_CODE"].Value.ToString();
        //                int classroomId = GetClassroomIdByCourseCode(courseCode, connection);

        //                if (classroomId != -1)
        //                {
        //                    string queryInsert = "INSERT INTO A_CLASSROOM_STUDENT (STUDENT_ID, CLASSROOM_ID) VALUES (:studentId, :classroomId)";

        //                    using (OracleCommand cmdInsert = new OracleCommand(queryInsert, connection))
        //                    {
        //                        cmdInsert.Parameters.Add(":studentId", OracleDbType.Int32).Value = studentNum;
        //                        cmdInsert.Parameters.Add(":classroomId", OracleDbType.Int32).Value = classroomId;

        //                        cmdInsert.ExecuteNonQuery();
        //                    }
        //                }
        //                else
        //                {

        //                    MessageBox.Show($"Hata: '{courseCode}' için CLASSROOM_ID bulunamadı.");

        //                }

        //            }


        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }


        //    }
        //}


        private int GetClassroomIdByCourseCode(string courseCode, OracleConnection connection)
        {
            string query = "SELECT A.CLASSROOM_ID FROM A_CLASSROOM A JOIN A_COURSE C ON (A.COURSE_ID=C.COURSE_ID) WHERE C.COURSE_CODE = :courseCode";

            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add(":courseCode", OracleDbType.Varchar2).Value = courseCode;
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int row_count = dataGridView4.Rows.Count;

                    for (int i=0; i<row_count-1; i++)
                    {
                        DataGridViewRow row = dataGridView4.Rows[i];
                        string courseCode = row.Cells["COURSE_CODE"].Value?.ToString();
                        if (courseCode != null)
                        {
                            int classroomId = GetClassroomIdByCourseCode(courseCode, connection);

                            if (classroomId != -1)
                            {
                                string queryInsert = "INSERT INTO A_CLASSROOM_STUDENT (STUDENT_ID, CLASSROOM_ID) VALUES (:studentId, :classroomId)";

                                using (OracleCommand cmdInsert = new OracleCommand(queryInsert, connection))
                                {
                                    cmdInsert.Parameters.Add(":studentId", OracleDbType.Int32).Value = studentNum;
                                    cmdInsert.Parameters.Add(":classroomId", OracleDbType.Int32).Value = classroomId;

                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Hata: '{courseCode}' için CLASSROOM_ID bulunamadı.");
                            }
                        }
                        else
                        {
                            // COURSE_CODE değeri null ise bir işlem yapmayabilir veya hata mesajı gösterebilirsiniz.
                            MessageBox.Show("Hata: COURSE_CODE değeri null.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message + "\nStack Trace: " + ex.StackTrace);
                }
            }
        }


    }
}
