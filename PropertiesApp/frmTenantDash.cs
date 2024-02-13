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
    public partial class frmTenantDash : Form
    {
        DataTable dt = frmLogin.dtInfo;

        public frmTenantDash()
        {
            InitializeComponent();
        }

        private void frmTenantDash_Load(object sender, EventArgs e)
        {
            lblDisplayUser.Text = "(" + dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString() + ")";
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

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmRental r = new frmRental();
            r.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin Log = new frmLogin();
            Log.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmTenantReports tr = new frmTenantReports();
            tr.Show();
            this.Hide();
        }
    }
}
