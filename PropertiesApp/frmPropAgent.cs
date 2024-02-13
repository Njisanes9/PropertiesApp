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
    public partial class frmPropAgent : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmPropAgent()
        {
            InitializeComponent();
        }

        private void frmPropAgent_Load(object sender, EventArgs e)
        {
            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "FullName";
            cmbAgent.ValueMember = "UserID";

            cmbProp.DataSource = bll.GetProperty();
            cmbProp.DisplayMember = "Description";
            cmbProp.ValueMember = "PropertyID";
            
            Refresh();

            gvPropAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gvPropAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvPropAgent.Rows[e.RowIndex];

                cmbProp.Text = row.Cells[1].Value.ToString();
                cmbAgent.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }
        public void Refresh()
        {
            gvPropAgent.DataSource = bll.GetPropertyAgent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent propAgent = new PropertyAgent();

            propAgent.propID = int.Parse(cmbProp.SelectedValue.ToString());
            propAgent.agentID = int.Parse(cmbAgent.SelectedValue.ToString());
            propAgent.date =  dtPicker.Value.ToString(); 
            //propAgent.agentID = dtPicker.ToString();


            if (string.IsNullOrEmpty(cmbAgent.Text)|| string.IsNullOrEmpty(cmbProp.Text))
            {
                errorProvider1.SetError(this.cmbAgent, "Agent name required!");
                errorProvider1.SetError(this.cmbProp, "Property name required!");
            }
            else
            {
                int x = bll.InsertPropertyAgent(propAgent);

                if (x > 0)
                {
                    MessageBox.Show(" Added successfully");
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
            PropertyAgent propAgent = new PropertyAgent();

            propAgent.propID = int.Parse(cmbProp.SelectedValue.ToString());
            propAgent.agentID = int.Parse(cmbProp.SelectedValue.ToString());
            propAgent.date = dtPicker.Value.ToString();
            propAgent.propAgentID = int.Parse(gvPropAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString());
            if (string.IsNullOrEmpty(cmbAgent.Text) || string.IsNullOrEmpty(cmbProp.Text))
            {
                errorProvider1.SetError(this.cmbAgent, "Agenct name required!");
                errorProvider1.SetError(this.cmbProp, "Property name required!");
            }
            else
            {
                int x = bll.UpdatePropertyAgent(propAgent);
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
            PropertyAgent propAgent = new PropertyAgent();
            propAgent.propAgentID = int.Parse(gvPropAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString());

            int x = bll.DeletePropertyAgent(propAgent);

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
            frmProperty p = new frmProperty();
            p.Show();
            this.Hide();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }

        private void gvPropAgent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbProp.Text = gvPropAgent.SelectedRows[0].Cells[1].Value.ToString();
            cmbAgent.Text = gvPropAgent.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
