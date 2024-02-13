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
    public partial class frmLogin : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        string roledesc;
        public static DataTable dtInfo;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtInfo = bll.GetLogin(txtUsername.Text, txtPassword.Text);

            if (dtInfo.Rows.Count > 0)
            {
                roledesc = dtInfo.Rows[0]["RoleDescr"].ToString().Trim();
                if (roledesc == "Admin")
                {
                    frmAdminDash admin = new frmAdminDash();
                    admin.Show();
                    this.Hide();
                }
                else if (roledesc == "Agent")
                {
                    frmAgentDash agent = new frmAgentDash();
                    agent.Show();
                    this.Hide();
                    this.Hide();
                }
                else if (roledesc == "Tenant")
                {
                    frmTenantDash tenant = new frmTenantDash();
                    tenant.Show();
                    this.Hide();
                }

            }
            else
            {
                lblErrorMessage.Text = "Incorrect username or password";
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        //private void chckPassword_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chckPassword.Checked == true)
        //    {
        //        txtPassword.UseSystemPasswordChar = false;
        //        //var checkbox = (CheckBox)sender;
        //        //checkbox.Text = "Hide Password";
        //    }
        //    else
        //    {
        //        txtPassword.UseSystemPasswordChar = true;
        //        //var checkbox = (CheckBox)sender;
        //        //checkbox.Text = "Show Password";
        //    }
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReset r = new frmReset();
            r.Show();
            this.Hide();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Show Password";
            }
        }
    }
}
