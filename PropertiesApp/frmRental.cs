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
    public partial class frmRental : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataTable dt = new DataTable();
        int tenantID;
        int agentID;
        string roleDesc = "";
        public frmRental()
        {
            InitializeComponent();
        }

        private void gvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            tenantID = int.Parse(dt.Rows[0]["UserID"].ToString());
            agentID = int.Parse(dt.Rows[0]["UserID"].ToString());

            //RoleDesc

            roleDesc = dt.Rows[0]["RoleDescr"].ToString();

            if(roleDesc == "Tenant")
            {
                lblRental.Text = "APPLY FOR RENTAL";
                lblSearch.Enabled = true;
                lblYourProps.Hide();

                cmbProperty.DataSource = bll.GetProperty();
                cmbProperty.DisplayMember = "Description";
                cmbProperty.ValueMember = "PropertyID";


                lblStatus.Hide();
                cmbStatus.Hide();

                Refresh();
            }
            else if(roleDesc=="Agent")
            {
                btnSearch.Hide();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnView.Enabled = false;
                txtProvince.Hide();
                cmbProperty.Enabled = false;
                dtStart.Enabled = false;
                dtEnd.Enabled = false;
                lblSearch.Hide();

                lblRental.Text = "MANAGE RENTALS";
                gvProperties.DataSource = bll.GetPropertiesByAgentID(agentID);
                gvRental.DataSource = bll.GetAllRentals(agentID);

                lblStatus.Show();
                cmbStatus.Show();

                cmbStatus.Items.Add("Approved");
                cmbStatus.Items.Add("Rejected");
            }


            


            
            gvRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            tenantID = int.Parse(dt.Rows[0]["UserID"].ToString());

            Rental rent = new Rental();
           
            rent.tenantID = tenantID;
            rent.propID = int.Parse(cmbProperty.SelectedValue.ToString());
            rent.startDate = dtStart.Value.ToString();
            rent.endDate = dtEnd.Value.ToString();
            rent.status = "Pending";

            
                int x = bll.InsertRental(rent);

                if (x > 0)
                {
                    MessageBox.Show(" Added Successfully!");
                }
                else
                {
                    MessageBox.Show(" Added Successfully!");
                }
                Refresh();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            roleDesc = dt.Rows[0]["RoleDescr"].ToString();

            if (roleDesc == "Tenant")
            {
                rent.rentalID = int.Parse(gvRental.SelectedRows[0].Cells["RentalID"].Value.ToString());

                rent.propID = int.Parse(cmbProperty.SelectedValue.ToString());
                rent.startDate = dtStart.Value.ToString();
                rent.endDate = dtEnd.Value.ToString();
                rent.status = "Pending";

                int x = bll.UpdateRental(rent);

                if (x > 0)
                {
                    MessageBox.Show(" Updated Successfully!");
                }
                else
                {
                    MessageBox.Show(" Updated Successfully!");
                }
                Refresh();

            }
            else if (roleDesc == "Agent")
            {
                dt = new DataTable();
                dt = frmLogin.dtInfo;
                agentID = int.Parse(dt.Rows[0]["UserID"].ToString());

                rent.rentalID = int.Parse(gvRental.SelectedRows[0].Cells["RentalID"].Value.ToString());
                rent.status = cmbStatus.SelectedItem.ToString();

                int y = bll.UpdateAllRentals(rent);

                if(y > 0)
                {
                    MessageBox.Show(" Updated Successfully!");
                }
                else
                {
                    MessageBox.Show(" Updated Successfully!");
                }
                gvRental.DataSource = bll.GetAllRentals(agentID);
            }


            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            rent.rentalID = int.Parse(gvRental.SelectedRows[0].Cells["RentalID"].Value.ToString());

            int x = bll.DeleteRental(rent);

            if (x > 0)
            {
                MessageBox.Show(" Deleted Successfully!");
            }
            else
            {
                MessageBox.Show(" Deleted Successfully!");
                
            }
            Refresh();
        }
        public void Refresh()
        {

            gvRental.DataSource = bll.GetRental(tenantID);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvProperties.DataSource = bll.SearchByCity(txtProvince.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            roleDesc = dt.Rows[0]["RoleDescr"].ToString();

            if (roleDesc == "Tenant")
            {
                frmTenantDash t = new frmTenantDash();
                t.Show();
                this.Hide();
            }
            else if(roleDesc == "Agent")
            {
                frmAgentDash a = new frmAgentDash();
                a.Show();
                this.Hide();
            }
        }

        private void gvRental_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbProperty.Text = gvRental.SelectedRows[0].Cells[1].Value.ToString();
            
        }
    }
}
