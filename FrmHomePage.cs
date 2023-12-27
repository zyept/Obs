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
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            FrmStudentLogin frm2 = new FrmStudentLogin();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStaffLogin frm3=new FrmStaffLogin();
            frm3.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmTeacherLogin frm = new FrmTeacherLogin();
            frm.Show();
            this.Hide();
        }
    }
}
