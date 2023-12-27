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
    public partial class FrmTeacherLogin : Form
    {
        public FrmTeacherLogin()
        {
            InitializeComponent();
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            OracleDataReader dr;
            OracleCommand cmd;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);

            int teacherId = Convert.ToInt32(teacheridTextBox.Text);
            string password = PasswordTextBox.Text.Trim();


            con.Open();
            cmd = new OracleCommand("SELECT * FROM A_TEACHER WHERE TEACHER_ID = :teacher_id AND password = :password", con);
            cmd.Parameters.Add(new OracleParameter("teacher_id", OracleDbType.Int32)).Value = teacherId;
            cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = password;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmTeacherPage f4 = new FrmTeacherPage(teacherId);
                f4.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FrmHomePage frm= new FrmHomePage();
            frm.Show();
            this.Hide();
        }

        private void FrmTeacherLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
