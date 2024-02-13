using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PropertiesApp
{
    public partial class frmTenantReports : Form
    {
        DataTable dt = new DataTable();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtInfo;
        public frmTenantReports()
        {
            InitializeComponent();
        }
        int userID;
        private void btnRented_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            userID = int.Parse(dt.Rows[0]["UserID"].ToString());

            dataGridView1.DataSource = bll.GetRentedByTenantID(userID);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dtInfo = bll.GetPriceRentals(decimal.Parse(txtPrice1.Text), decimal.Parse(txtPrice2.Text));

            dataGridView1.DataSource = dtInfo;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmTenantDash td = new frmTenantDash();
            td.Show();
            this.Hide();
        }

        private void frmTenantReports_Load(object sender, EventArgs e)
        {
            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "Name";
            cmbAgency.ValueMember = "AgencyID";
        }

        private void cmbAgency_SelectedIndexChanged(object sender, EventArgs e)
        {
            int agencyID;
            Int32.TryParse(cmbAgency.SelectedValue.ToString(), out agencyID);
            dataGridView1.DataSource = bll.GetByAgencyID(agencyID);
        }
    }
}
