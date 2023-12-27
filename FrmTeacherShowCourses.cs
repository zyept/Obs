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
    public partial class FrmTeacherShowCourses : Form
    {
        int studentNumber;
        public FrmTeacherShowCourses(int studentNum)
        {
            InitializeComponent();
            this.studentNumber = studentNum;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTeacherShowCourses_Load(object sender, EventArgs e)
        {
        }

        public void ShowCourses(int studentNumber)
        {

            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            // Oracle bağlantısı oluştur
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                // Öğrencinin seçtiği dersleri getiren sorgu
                string query = "SELECT A.COURSE_CODE, A.COURSE_NAME FROM a_CLASSROOM C JOIN A_COURSE A ON(C.COURSE_ID=A.COURSE_ID) " +
                    "WHERE C.Student_ID = :StudentNumber";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":StudentNumber", OracleDbType.Varchar2).Value = studentNumber;

                    // OracleDataAdapter kullanarak verileri çek
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e verileri bağla
                        coursedataGridView.DataSource = dataTable;
                    }
                }
            }

        }

        private void ApproveChechBox_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            // Oracle bağlantısı oluştur
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE A_CLASSROOM SET is_approved = 1 WHERE Student_ID = :StudentNumber";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":StudentNumber", OracleDbType.Varchar2).Value = studentNumber;
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        coursedataGridView.DataSource = dataTable;
                    }
                }
            }
            MessageBox.Show("Approved");
            ShowCourses(studentNumber);
        }

        private void rejectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            // Oracle bağlantısı oluştur
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE A_CLASSROOM SET is_approved = 0 WHERE Student_ID = :StudentNumber";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":StudentNumber", OracleDbType.Varchar2).Value = studentNumber;
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        coursedataGridView.DataSource = dataTable;
                    }
                }
            }
            MessageBox.Show("Rejected");
            ShowCourses(studentNumber);
        }
    }
}

