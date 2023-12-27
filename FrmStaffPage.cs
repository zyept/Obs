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
    public partial class FrmStaffPage : Form
    {
        public FrmStaffPage()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm= new FrmAddStudent();
            frm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            FrmAddTeacher frm = new FrmAddTeacher();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
    
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            VeritabanindanVeriGetirTeacher();
        }
        private void VeritabanindanVeriGetirTeacher()
        {
            using (OracleConnection baglanti = new OracleConnection(@"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;"))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT FACULTY_NAME FROM A_FACULTY";

                    using (OracleCommand komut = new OracleCommand(sorgu, baglanti))
                    {
                        using (OracleDataReader reader = komut.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                facultycomboboxt.Items.Add(reader["FACULTY_NAME"].ToString());
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
        private void FrmStaffPage_Load(object sender, EventArgs e)
        {
            VeritabanindanVeriGetir();
        }
        private void VeritabanindanVeriGetir()
        {
            using (OracleConnection baglanti = new OracleConnection(@"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;"))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT FACULTY_NAME FROM A_FACULTY";

                    using (OracleCommand komut = new OracleCommand(sorgu, baglanti))
                    {
                        using (OracleDataReader reader = komut.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                facultycomboBox.Items.Add(reader["FACULTY_NAME"].ToString());
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
        private void addStudentButton_Click_1(object sender, EventArgs e)
        {
            
                OracleCommand cmd;
                string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
                OracleConnection con = new OracleConnection(constr);
                string identityNum = IdentityNumTextBox.Text;
                string fakulteAdi = facultycomboBox.Text;

                con.Open();
                string queryFaculty = "SELECT FACULTY_ID FROM A_FACULTY WHERE FACULTY_NAME = :faculty";
            using (OracleCommand cmdFaculty = new OracleCommand(queryFaculty, con))
            {
                cmdFaculty.Parameters.Add(":faculty", OracleDbType.Varchar2).Value = fakulteAdi;
                object resultFaculty = cmdFaculty.ExecuteScalar();

                if (resultFaculty != null)
                {
                    int fakulteId = Convert.ToInt32(resultFaculty);
                    string departmentName = depcomboBox.Text;
                    string queryDepartment = "SELECT DEP_ID FROM A_DEPARTMENT WHERE DEP_NAME = :departmentName";
                    using (OracleCommand cmdDepartment = new OracleCommand(queryDepartment, con))
                    {
                        cmdDepartment.Parameters.Add(":departmentName", OracleDbType.Varchar2).Value = departmentName;

                        object resultDepartment = cmdDepartment.ExecuteScalar();

                        if (resultDepartment != null)
                        {
                            int departmentId = Convert.ToInt32(resultDepartment);
                            string selectedTeacherName = AcademicAdvisorCombobox.Text;
                            string[] teacherNameParts = selectedTeacherName.Split(' ');
                            string teacherFirstName = teacherNameParts[0];
                            string teacherLastName = teacherNameParts[1];
                            string queryTeacherId = "SELECT TEACHER_ID FROM A_TEACHER WHERE FNAME = :fname AND LNAME = :lname";
                            using (OracleCommand cmdTeacherId = new OracleCommand(queryTeacherId, con))
                            {
                                cmdTeacherId.Parameters.Add(":fname", OracleDbType.Varchar2).Value = teacherFirstName;
                                cmdTeacherId.Parameters.Add(":lname", OracleDbType.Varchar2).Value = teacherLastName;
                                object resultTeacherId = cmdTeacherId.ExecuteScalar();

                                if (resultTeacherId != null)
                                {
                                    int teacherId = Convert.ToInt32(resultTeacherId);
                                    cmd = new OracleCommand("INSERT INTO A_STUDENT (STUDENT_ID, FNAME, LNAME, MAIL, PHONE_NUMBER, IDENTITY_NUM, FACULTY_ID, DEPARTMENT_ID, PASSWORD,TEACHER_ID) VALUES (:student_id, :fname, :lname, :mail, :phone_num, :identity_num, :faculty, :dep, :password,:teacher_id)", con);

                                    cmd.Parameters.Add(":student_id", OracleDbType.Int32).Value = Convert.ToInt32(studentNumTextBox.Text);
                                    cmd.Parameters.Add(":fname", OracleDbType.Varchar2).Value = studentNameTextBox.Text;
                                    cmd.Parameters.Add(":lname", OracleDbType.Varchar2).Value = studentSurnameTextBox.Text;
                                    cmd.Parameters.Add(":mail", OracleDbType.Varchar2).Value = mailTextBox.Text;
                                    cmd.Parameters.Add(":phone_num", OracleDbType.Varchar2).Value = phoneNumTextBox.Text;
                                    cmd.Parameters.Add(":identity_num", OracleDbType.Varchar2).Value = identityNum;
                                    cmd.Parameters.Add(":faculty", OracleDbType.Int32).Value = fakulteId;
                                    cmd.Parameters.Add(":dep", OracleDbType.Int32).Value = departmentId;
                                    cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = identityNum;
                                    cmd.Parameters.Add(":teacher_id", OracleDbType.Int32).Value = resultTeacherId;
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Student added successfully.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: Failed to add student.");
                                    }
                                }
                            }
                        }
                    }
                    con.Close();
                }
            }
            
        }

        private void facultycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFaculty = facultycomboBox.Text;

            if (!string.IsNullOrEmpty(selectedFaculty))
            {
                depcomboBox.Items.Clear(); // Önceki departmanları temizle

                OracleCommand cmd;
                string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
                OracleConnection con = new OracleConnection(constr);

                try
                {
                    con.Open();
                    string queryFaculty = "SELECT FACULTY_ID FROM A_FACULTY WHERE FACULTY_NAME = :faculty";
                    using (OracleCommand cmdFaculty = new OracleCommand(queryFaculty, con))
                    {
                        cmdFaculty.Parameters.Add(":faculty", OracleDbType.Varchar2).Value = selectedFaculty;
                        object resultFaculty = cmdFaculty.ExecuteScalar();

                        if (resultFaculty != null)
                        {
                            int fakulteId = Convert.ToInt32(resultFaculty);
                            string queryDepartments = "SELECT DEP_NAME FROM A_DEPARTMENT WHERE FACULTY_ID = :facultyId";
                            using (OracleCommand cmdDepartments = new OracleCommand(queryDepartments, con))
                            {
                                cmdDepartments.Parameters.Add(":facultyId", OracleDbType.Int32).Value = fakulteId;

                                using (OracleDataReader readerDepartments = cmdDepartments.ExecuteReader())
                                {
                                    while (readerDepartments.Read())
                                    {
                                        depcomboBox.Items.Add(readerDepartments["DEP_NAME"].ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Faculty ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void addTeacherButton_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);

            string identityNum = identityNumberTextBox.Text;
            string fakulteAdi = facultycomboboxt.Text;

            try
            {
                con.Open();
                string queryFaculty = "SELECT FACULTY_ID FROM FACULTY WHERE FACULTY_NAME = :faculty";
                using (OracleCommand cmdFaculty = new OracleCommand(queryFaculty, con))
                {
                    cmdFaculty.Parameters.Add(":faculty", OracleDbType.Varchar2).Value = fakulteAdi;
                    object resultFaculty = cmdFaculty.ExecuteScalar();

                    if (resultFaculty != null)
                    {
                        int fakulteId = Convert.ToInt32(resultFaculty);
                        string departmentName = depcomboboxt.Text;
                        string queryDepartment = "SELECT DEP_ID FROM DEPARTMENT WHERE DEP_NAME = :departmentName";
                        using (OracleCommand cmdDepartment = new OracleCommand(queryDepartment, con))
                        {
                            cmdDepartment.Parameters.Add(":departmentName", OracleDbType.Varchar2).Value = departmentName;

                            object resultDepartment = cmdDepartment.ExecuteScalar();

                            if (resultDepartment != null)
                            {
                                int departmentId = Convert.ToInt32(resultDepartment);

                                cmd = new OracleCommand("INSERT INTO A_TEACHER (TEACHER_ID, FNAME, LNAME, MAIL, PHONE_NUMBER, ROOM_NUMBER, IDENTITY_NUMBER, PASSWORD, FACULTY, DEPARTMENT) VALUES (:id, :fname, :lname, :mail, :phone_num, :room_num, :identity_num, :password, :faculty, :dep)", con);
                                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = teacheridtextbox.Text;
                                cmd.Parameters.Add(":fname", OracleDbType.Varchar2).Value = NameTextBox.Text;
                                cmd.Parameters.Add(":lname", OracleDbType.Varchar2).Value = SurnameTextBox.Text;
                                cmd.Parameters.Add(":mail", OracleDbType.Varchar2).Value = mailtextboxt.Text;
                                cmd.Parameters.Add(":phone_num", OracleDbType.Varchar2).Value = phonenumbertextboxt.Text;
                                cmd.Parameters.Add(":room_num", OracleDbType.Varchar2).Value = roomNumTextBox.Text;
                                cmd.Parameters.Add(":identity_num", OracleDbType.Varchar2).Value = identityNum;
                                cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = identityNum;
                                cmd.Parameters.Add(":faculty", OracleDbType.Int32).Value = fakulteId;
                                cmd.Parameters.Add(":dep", OracleDbType.Int32).Value = departmentId;
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Teacher added successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Error: Failed to add teacher.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error: Department ID not found.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Faculty ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void facultycomboboxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFaculty = facultycomboboxt.Text;

            if (!string.IsNullOrEmpty(selectedFaculty))
            {
                depcomboboxt.Items.Clear();
                OracleCommand cmd;
                string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
                OracleConnection con = new OracleConnection(constr);

                try
                {
                    con.Open();
                    string queryFaculty = "SELECT FACULTY_ID FROM A_FACULTY WHERE FACULTY_NAME = :faculty";
                    using (OracleCommand cmdFaculty = new OracleCommand(queryFaculty, con))
                    {
                        cmdFaculty.Parameters.Add(":faculty", OracleDbType.Varchar2).Value = selectedFaculty;
                        object resultFaculty = cmdFaculty.ExecuteScalar();

                        if (resultFaculty != null)
                        {
                            int fakulteId = Convert.ToInt32(resultFaculty);

                            // Fakülteye ait bölümleri çeken sorgu
                            string queryDepartments = "SELECT DEP_NAME FROM A_DEPARTMENT WHERE FACULTY_ID = :facultyId";
                            using (OracleCommand cmdDepartments = new OracleCommand(queryDepartments, con))
                            {
                                cmdDepartments.Parameters.Add(":facultyId", OracleDbType.Int32).Value = fakulteId;

                                using (OracleDataReader readerDepartments = cmdDepartments.ExecuteReader())
                                {
                                    while (readerDepartments.Read())
                                    {
                                        depcomboboxt.Items.Add(readerDepartments["DEP_NAME"].ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Faculty ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void depcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = depcomboBox.Text;

            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                AcademicAdvisorCombobox.Items.Clear();
                OracleCommand cmd;
                string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
                OracleConnection con = new OracleConnection(constr);

                try
                {
                    con.Open();

                    // Fakülte ID'sini çeken sorgu
                    string queryFacultyId = "SELECT FACULTY_ID FROM A_FACULTY WHERE FACULTY_NAME = :facultyName";

                    using (OracleCommand cmdFacultyId = new OracleCommand(queryFacultyId, con))
                    {
                        cmdFacultyId.Parameters.Add(":facultyName", OracleDbType.Varchar2).Value = facultycomboBox.Text;
                        object resultFacultyId = cmdFacultyId.ExecuteScalar();

                        if (resultFacultyId != null)
                        {
                            int facultyId = Convert.ToInt32(resultFacultyId);

                            // Öğretmenin bağlı olduğu bölümü ve fakülte ID'sini kontrol ederek öğretmenleri çeken sorgu
                            string queryTeachers = "SELECT fname || ' ' || lname AS TEACHER_NAME FROM A_TEACHER WHERE DEPARTMENT = (SELECT DEP_ID FROM A_DEPARTMENT WHERE DEP_NAME = :department AND FACULTY_ID = :facultyId)";

                            using (OracleCommand cmdTeachers = new OracleCommand(queryTeachers, con))
                            {
                                cmdTeachers.Parameters.Add(":department", OracleDbType.Varchar2).Value = selectedDepartment;
                                cmdTeachers.Parameters.Add(":facultyId", OracleDbType.Int32).Value = facultyId;

                                using (OracleDataReader readerTeachers = cmdTeachers.ExecuteReader())
                                {
                                    while (readerTeachers.Read())
                                    {
                                        AcademicAdvisorCombobox.Items.Add(readerTeachers["TEACHER_NAME"].ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Faculty ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
    
}
