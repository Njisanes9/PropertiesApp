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
    public partial class frmAdminReports : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtInfo;
        public frmAdminReports()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            gvReports.DataSource = bll.GetAllUsers();
        }

        private void frmAdminReports_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = bll.GetAllUsers();
            cmbUsers.DisplayMember = "Fullname";
            cmbUsers.ValueMember = "UserID";

            cmbTenants.DataSource = bll.GetTenant();
            cmbTenants.DisplayMember = "Fullname";
            cmbTenants.ValueMember = "UserID";

            gvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userID;
            Int32.TryParse(cmbUsers.SelectedValue.ToString(), out userID);
            gvReports.DataSource = bll.GetUserByID(userID);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            gvReports.DataSource = bll.GetPropertyPropType();
        }

        private void btnProvinces_Click(object sender, EventArgs e)
        {
            gvReports.DataSource = bll.GetCityProv();
        }

        private void cmbTenants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userID;
            Int32.TryParse(cmbTenants.SelectedValue.ToString(), out userID);
            gvReports.DataSource = bll.GetPropertyRental(userID);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dtInfo = bll.GetPriceRentals(decimal.Parse(txtPrice1.Text), decimal.Parse(txtPrice2.Text));

            gvReports.DataSource = dtInfo;
        }

        private void btnRentedProp_Click(object sender, EventArgs e)
        {
            gvReports.DataSource = bll.GetRentedProperties();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }
    }
}
