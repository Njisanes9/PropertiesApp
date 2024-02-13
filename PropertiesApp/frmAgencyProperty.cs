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
    public partial class frmAgencyProperty : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmAgencyProperty()
        {
            InitializeComponent();
        }

        private void frmAgencyProperty_Load(object sender, EventArgs e)
        {
            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "Name";
            cmbAgency.ValueMember = "AgencyID";

            cmbProperty.DataSource = bll.GetProperty();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";


            Refresh();
            gvAgentAgencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgencyProperty ap = new AgencyProperty();

            ap.agencyID = int.Parse(cmbAgency.SelectedValue.ToString());
            ap.propertyID = int.Parse(cmbProperty.SelectedValue.ToString());


          
                int x = bll.InsertAgencyProperty(ap);

                if (x > 0)
                {
                    MessageBox.Show(" Added successfully!");
                }
                else
                {
                    MessageBox.Show(" Added successfully!");
                }


                Refresh();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AgencyProperty ap = new AgencyProperty();

            ap.AgencyPropertyID = int.Parse(gvAgentAgencies.SelectedRows[0].Cells["AgencyPropertyID"].Value.ToString());
            ap.agencyID = int.Parse(cmbAgency.SelectedValue.ToString());
            ap.propertyID = int.Parse(cmbProperty.SelectedValue.ToString());



            int x = bll.UpdateAgencyProperty(ap);

            if (x > 0)
            {
                MessageBox.Show(" Updated successfully!");
            }
            else
            {
                MessageBox.Show(" Updated successfully!");
            }


            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AgencyProperty ap = new AgencyProperty();
            ap.AgencyPropertyID = int.Parse(gvAgentAgencies.SelectedRows[0].Cells["AgencyPropertyID"].Value.ToString());

            int x = bll.DeleteAgencyProperty(ap);

            if (x > 0)
            {
                MessageBox.Show(" Deleted successfully!");
            }
            else
            {
                MessageBox.Show(" Deleted successfully!");
            }
            Refresh();
        }
        public void Refresh()
        {
            gvAgentAgencies.DataSource = bll.GetAgencyProperty();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmAgency a = new frmAgency();
            a.Show();
            this.Hide();
        }
    }
}
