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
    public partial class frmAgentReports : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataTable dt = new DataTable();
        public frmAgentReports()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAgentDash ag = new frmAgentDash();
            ag.Show();
            this.Hide();
        }
        int userID;
        private void btnProperties_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            userID = int.Parse(dt.Rows[0]["UserID"].ToString());

            dtReports.DataSource = bll.GetPropertiesByAgentID(userID);
        }
    }
}
