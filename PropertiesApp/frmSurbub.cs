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
    public partial class frmSurbub : Form
    {

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmSurbub()
        {
            InitializeComponent();
        }

        private void frmSurbub_Load(object sender, EventArgs e)
        {
            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "City";
            cmbCity.ValueMember = "CityID";

            Refresh();

            gvSurbub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Refresh()
        {
            gvSurbub.DataSource = bll.GetSuburb();
        }

        private void gvSurbub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvSurbub.Rows[e.RowIndex];

                txtSurbub.Text = row.Cells[1].Value.ToString();
                txtPostal.Text = row.Cells[2].Value.ToString();
                cmbCity.Text = row.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Suburb sub = new Suburb();

            sub.subDescr = txtSurbub.Text;
            sub.postalCode = txtPostal.Text;
            sub.cityID = int.Parse(cmbCity.SelectedValue.ToString());


            if (string.IsNullOrEmpty(txtSurbub.Text) || string.IsNullOrEmpty(txtPostal.Text))
            {
                errorProvider1.SetError(this.txtSurbub, "Suburb name required!");
                errorProvider1.SetError(this.txtPostal, "Postal Address required!");
            }
            else
            {
                int x = bll.InsertSuburb(sub);

                if (x > 0)
                {
                    MessageBox.Show(" Added successfully");
                }
                else
                {
                    MessageBox.Show(" Something went wrong!");
                }


                Refresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Suburb sub = new Suburb();

            sub.subDescr = txtSurbub.Text;
            sub.postalCode = txtSurbub.Text;
            sub.cityID = int.Parse(cmbCity.SelectedValue.ToString());
            sub.suburbID = int.Parse(gvSurbub.SelectedRows[0].Cells["SuburbID"].Value.ToString());
            if (string.IsNullOrEmpty(txtSurbub.Text) || string.IsNullOrEmpty(txtPostal.Text))
            {
                errorProvider1.SetError(this.txtSurbub, "Suburb name required!");
                errorProvider1.SetError(this.txtPostal, "Postal Address required!");
            }
            else
            {
                int x = bll.UpdateSuburb(sub);
                if (x > 0)
                {
                    MessageBox.Show(" Updated successfully!");
                }
                else
                {
                    MessageBox.Show(" Something went wrong!");
                }
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Suburb sub = new Suburb();
            sub.suburbID = int.Parse(gvSurbub.SelectedRows[0].Cells["SuburbID"].Value.ToString());

            int x = bll.DeleteSuburb(sub);

            if (x > 0)
            {
                MessageBox.Show(" Deleted successfully!");
            }
            else
            {
                MessageBox.Show(" Something went wrong!");
            }
            Refresh();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }

        private void gvSurbub_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSurbub.Text = gvSurbub.SelectedRows[0].Cells[1].Value.ToString();
            txtPostal.Text = gvSurbub.SelectedRows[0].Cells[2].Value.ToString();
            cmbCity.Text = gvSurbub.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCity c = new frmCity();
            c.Show();
            this.Hide();
        }
    }
}
