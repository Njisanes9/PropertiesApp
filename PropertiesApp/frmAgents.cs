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
    
    public partial class frmAgents : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public frmAgents()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmPropAgent pa = new frmPropAgent();
            pa.Show();
           this.Hide();
        }

        private void frmAgents_Load(object sender, EventArgs e)
        {
            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "FullName";
            cmbAgent.ValueMember = "UserID";


            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "Name";
            cmbAgency.ValueMember = "AgencyID";


            gvAgencts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refresh();
        }
        public void Refresh()
        {
            gvAgencts.DataSource = bll.GetAgentAgency();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agent ag = new Agent();

            ag.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            ag.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());


           
                int x = bll.InsertAgent(ag);

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
            Agent ag = new Agent();

            ag.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            ag.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());

            ag.AgentAgencyID = int.Parse(gvAgencts.SelectedRows[0].Cells["AgentAgency"].Value.ToString());
         
                int x = bll.UpdateAgent(ag);
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
            Agent ag = new Agent();
            ag.AgentAgencyID = int.Parse(gvAgencts.SelectedRows[0].Cells["AgentAgency"].Value.ToString());

            int x = bll.DeleteAgent(ag);

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

        private void btnH_Click(object sender, EventArgs e)
        {
            frmAdminDash a = new frmAdminDash();
            a.Show();
            this.Hide();
        }
    }
}
