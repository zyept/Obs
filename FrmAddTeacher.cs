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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class FrmAddTeacher : Form
    {
        public FrmAddTeacher()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);

            string identityNum = identityNumberTextBox.Text;
            string fakulteAdi = facultyComboBox.Text;

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
                        string departmentName = depcomboBox.Text; 
                        string queryDepartment = "SELECT DEP_ID FROM DEPARTMENT WHERE DEP_NAME = :departmentName";
                        using (OracleCommand cmdDepartment = new OracleCommand(queryDepartment, con))
                        {
                            cmdDepartment.Parameters.Add(":departmentName", OracleDbType.Varchar2).Value = departmentName;

                            object resultDepartment = cmdDepartment.ExecuteScalar();

                            if (resultDepartment != null)
                            {
                                int departmentId = Convert.ToInt32(resultDepartment);

                                string getIdQuery = "SELECT teacher_id_seq.NEXTVAL FROM DUAL";
                                using (OracleCommand getIdCmd = new OracleCommand(getIdQuery, con))
                                {
                                    int newTeacherId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                                    cmd = new OracleCommand("INSERT INTO TEACHER (TEACHER_ID, FNAME, LNAME, MAIL, PHONE_NUMBER, ROOM_NUMBER, IDENTITY_NUMBER, PASSWORD, FACULTY, DEPARTMENT) VALUES (:id, :fname, :lname, :mail, :phone_num, :room_num, :identity_num, :password, :faculty, :dep)", con);
                                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = newTeacherId;
                                    cmd.Parameters.Add(":fname", OracleDbType.Varchar2).Value = NameTextBox.Text;
                                    cmd.Parameters.Add(":lname", OracleDbType.Varchar2).Value = SurnameTextBox.Text;
                                    cmd.Parameters.Add(":mail", OracleDbType.Varchar2).Value = mailTextBox.Text;
                                    cmd.Parameters.Add(":phone_num", OracleDbType.Varchar2).Value = phoneNumTextBox.Text;
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void facultyTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFaculty = facultyComboBox.Text;

            if (!string.IsNullOrEmpty(selectedFaculty))
            {
                depcomboBox.Items.Clear(); 
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

                            // Fakülteye ait bölümleri çeken sorgu
                            string queryDepartments = "SELECT DEP_NAME FROM DEPARTMENT WHERE FACULTY = :facultyId";
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

        private void FrmAddTeacher_Load(object sender, EventArgs e)
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
                                facultyComboBox.Items.Add(reader["FACULTY_NAME"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStaffPage frm=new FrmStaffPage();
            frm.Show();
            this.Hide();
        }
    }
}
