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
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FrmHomePage frm = new FrmHomePage();
            frm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OracleDataReader dr;
            OracleCommand cmd;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);

            string password = PasswordTextBox.Text.Trim();
            con.Open();
            cmd = new OracleCommand("SELECT * FROM A_STUDENT WHERE STUDENT_ID = :id AND PASSWORD = :password", con);
            cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = Convert.ToInt32(StudentNumberTextBox.Text);
            cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = password;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmStudentPage frm = new FrmStudentPage(Convert.ToInt32(StudentNumberTextBox.Text));
                frm.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
                con.Close();
            }
        }
    }
}
