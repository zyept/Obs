using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class FrmStaffLogin : Form
    {
        OracleConnection con;
        public FrmStaffLogin()
        {
            InitializeComponent();
        }
    
        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            OracleDataReader dr;
            OracleCommand cmd;
            string constr = @"Data Source=Victus:1522/XEPDB1;User Id=SYSTEM;Password=1234;";
            OracleConnection con = new OracleConnection(constr);

            string username = usernameTextBox.Text.Trim();
            string password = staffPasswordTextBox.Text.Trim();

            
            con.Open();
            cmd = new OracleCommand("SELECT * FROM STAFF WHERE username = :username AND password = :password", con);
            cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;
            cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = password;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmStaffPage f4 = new FrmStaffPage();
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
            FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void staffPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
