using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertiesApp
{
    public partial class frmAdminDash : Form
    {
        DataTable dt = frmLogin.dtInfo;
        public frmAdminDash()
        {
            InitializeComponent();
        }

        private void frmAdminDash_Load(object sender, EventArgs e)
        {
            lblDisplayUser.Text = "(" + dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString() +  ")";
            lblRole.Text = "(" + dt.Rows[0]["RoleDescr"].ToString() + ")";
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser u = new frmUser();
            u.Show();
            this.Hide();
        }

        private void btnPropType_Click(object sender, EventArgs e)
        {
            frmPropType pt = new frmPropType();
            pt.Show();
            this.Hide();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            frmProperty pr = new frmProperty();
            pr.Show();
            this.Hide();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            frmCity ct = new frmCity();
            ct.Show();
            this.Hide();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmAgency ag = new frmAgency();
            ag.Show();
            this.Hide();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            frmAgents a = new frmAgents();
            a.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmAdminReports ar = new frmAdminReports();
            ar.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
    }
}
