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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd,cmd2;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);
            string identityNum = IdentityNumTextBox.Text;
            string fakulteAdi = facultycomboBox.Text;

            con.Open();

            cmd = new OracleCommand("INSERT INTO STUDENT (STUDENT_ID, FNAME, LNAME, MAIL, PHONE_NUMBER, IDENTITY_NUM, PASSWORD) VALUES (:student_id, :fname, :lname, :mail, :phone_num, :identity_num, :password)", con);
            cmd.Parameters.Add(":student_id", OracleDbType.Int32).Value = Convert.ToInt32(studentNumTextBox.Text);
            cmd.Parameters.Add(":fname", OracleDbType.Varchar2).Value = studentNameTextBox.Text;
            cmd.Parameters.Add(":lname", OracleDbType.Varchar2).Value = studentSurnameTextBox.Text;
            cmd.Parameters.Add(":mail", OracleDbType.Varchar2).Value = mailTextBox.Text;
            cmd.Parameters.Add(":phone_num", OracleDbType.Varchar2).Value = phoneNumTextBox.Text;
            cmd.Parameters.Add(":identity_num", OracleDbType.Varchar2).Value = identityNum;
            cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = identityNum;
            int rowsAffected = cmd.ExecuteNonQuery();

            OracleCommand cmd3 = new OracleCommand("SELECT DEPARTMENT_ID FROM DEPARTMENT WHERE DEPARTMENT_NAME = :department_name", con);
            cmd3.Parameters.Add(":department_name", OracleDbType.Varchar2).Value = depcomboBox.Text;

            // Assuming you have a reader to read the result
            OracleDataReader reader = cmd3.ExecuteReader();

            if (reader.Read())
            {
                int departmentId = reader.GetInt32(0); // Assuming the first column in the result set is DEPARTMENT_ID
                cmd2 = new OracleCommand("INSERT INTO DEPARTMENT_STUDENT (STUDENT_ID, DEPARTMENT_ID) VALUES (:student_id, :department_id)", con);
                cmd2.Parameters.Add(":student_id", OracleDbType.Int32).Value = Convert.ToInt32(studentNumTextBox.Text);
                cmd2.Parameters.Add(":department_id", OracleDbType.Int32).Value = departmentId;
            }
            else
            {
                Console.WriteLine("Department not found.");
            }

            reader.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Student added successfully.");
            }
            else
            {
                MessageBox.Show("Error: Failed to add student.");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStaffPage frm= new FrmStaffPage();
            frm.Show();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
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

                    string sorgu = "SELECT FACULTY_NAME FROM FACULTY";

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
                    string queryFaculty = "SELECT FACULTY_ID FROM FACULTY WHERE FACULTY_NAME = :faculty";
                    using (OracleCommand cmdFaculty = new OracleCommand(queryFaculty, con))
                    {
                        cmdFaculty.Parameters.Add(":faculty", OracleDbType.Varchar2).Value = selectedFaculty;
                        object resultFaculty = cmdFaculty.ExecuteScalar();

                        if (resultFaculty != null)
                        {
                            int fakulteId = Convert.ToInt32(resultFaculty);
                            string queryDepartments = "SELECT DEP_NAME FROM DEPARTMENT WHERE DEP_ID IN(SELECT DEPARTMENT ID FROM FACULTY WHERE FACULTY_ID=facultyId";
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
    }
}
