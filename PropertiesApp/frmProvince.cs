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
    public partial class frmProvince : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public frmProvince()
        {
            InitializeComponent();
        }

        private void gvProvince_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvProvince.Rows[e.RowIndex];

                txtProvince.Text = row.Cells[1].Value.ToString();
                

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }

        private void frmProvince_Load(object sender, EventArgs e)
        {
            gvProvince.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refresh();
        }
        public void Refresh()
        {

            gvProvince.DataSource = bll.GetProvince();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Province prov = new Province();

            prov.description = txtProvince.Text;


            if (string.IsNullOrEmpty(txtProvince.Text))
            {
                errorProvider1.SetError(this.txtProvince, "Province name required!");

            }
            else
            {
                int x = bll.InsertProvince(prov);

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
            Province prov = new Province();

            prov.description = txtProvince.Text;
            prov.id = int.Parse(gvProvince.SelectedRows[0].Cells["ProvinceID"].Value.ToString());
            if (string.IsNullOrEmpty(txtProvince.Text))
            {
                errorProvider1.SetError(this.txtProvince, "Province name required!");

            }
            else
            {
                int x = bll.UpdateProvince(prov);
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
            Province prov = new Province();
            prov.id = int.Parse(gvProvince.SelectedRows[0].Cells["ProvinceID"].Value.ToString());

            int x = bll.DeleteProvince(prov);

            if (x > 0)
            {
                MessageBox.Show(" Deleted successfully!");
            }
            else
            {
                MessageBox.Show(" Deleted successfully!");
            }
            //Refresh();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void gvProvince_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProvince.Text = gvProvince.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
