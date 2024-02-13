using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertiesApp
{
    public partial class frmReset : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        DataTable dt = new DataTable();

        public frmReset()
        {
            InitializeComponent();
        }

        private void frmReset_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dt = bll.GetEmail(txtEmail.Text);
            ChangePassword cp = new ChangePassword();

            cp.Email = txtEmail.Text;
            cp.Password = txtNewPw.Text;
            cp.Password = txtConfirmPw.Text;
            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Email does not exist!");
            }
            else if (txtNewPw.Text != txtConfirmPw.Text)
            {
                MessageBox.Show("Passwords do not match!! \nPlease enter matching passwords!");

                txtEmail.Text = "";
                txtNewPw.Text = "";
                txtConfirmPw.Text = "";
            }
            else
            {
                int x = bll.ChangePassword(cp);
                MessageBox.Show("Password changed successfully!");

                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
               txtNewPw.UseSystemPasswordChar = false;
               txtConfirmPw.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hide Password";
            }
            else
            {
                txtNewPw.UseSystemPasswordChar = true;
                txtConfirmPw.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Show Password";
            }
        }
    }
}
