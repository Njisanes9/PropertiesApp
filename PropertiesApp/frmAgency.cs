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
    public partial class frmAgency : Form
    {

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmAgency()
        {
            InitializeComponent();
        }

        private void gvAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvAgency.Rows[e.RowIndex];

                txtAgency.Text = row.Cells[1].Value.ToString();
                cmbSuburb.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }
        public void Refresh()
        {
            gvAgency.DataSource = bll.GetAgency();
        }

        private void frmAgency_Load(object sender, EventArgs e)
        {

            Refresh();
            cmbSuburb.DataSource = bll.GetSuburb();
            cmbSuburb.DisplayMember = "Suburb";
            cmbSuburb.ValueMember = "SuburbID";

            gvAgency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();

            agency.agencyName = txtAgency.Text;
            agency.suburbID = int.Parse(cmbSuburb.SelectedValue.ToString());


            if (string.IsNullOrEmpty(txtAgency.Text))
            {
                errorProvider1.SetError(this.txtAgency, "Agency name required!");

            }
            else
            {
                int x = bll.InsertAgency(agency);

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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();

            agency.agencyName = txtAgency.Text;
            agency.suburbID = int.Parse(cmbSuburb.SelectedValue.ToString());

            agency.agencyID = int.Parse(gvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString());
            if (string.IsNullOrEmpty(txtAgency.Text) || string.IsNullOrEmpty(cmbSuburb.Text))
            {
                errorProvider1.SetError(this.txtAgency, "Agency name required!");
                errorProvider1.SetError(this.cmbSuburb, "Suburb name required!");
            }
            else
            {
                int x = bll.UpdateAgency(agency);
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();
            agency.agencyID = int.Parse(gvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString());

            int x = bll.DeleteAgency(agency);

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

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAgencyProperty ap = new frmAgencyProperty();
            ap.Show();
            this.Hide();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }

        private void gvAgency_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAgency.Text = gvAgency.SelectedRows[0].Cells[1].Value.ToString();
            cmbSuburb.Text = gvAgency.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
