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
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void gvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvCity.Rows[e.RowIndex];

                txtCity.Text = row.Cells[1].Value.ToString();
                cmbProvince.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";

            Refresh();
            gvCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Refresh()
        {
            gvCity.DataSource = bll.GetCity();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();

            city.cityDesc = txtCity.Text;
            city.provinceID = int.Parse(cmbProvince.SelectedValue.ToString());


            if (string.IsNullOrEmpty(txtCity.Text))
            {
                errorProvider1.SetError(this.txtCity, "City name required!");

            }
            else
            {
                int x = bll.InsertCity(city);

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
            City city = new City();

            city.cityDesc = txtCity.Text;
            city.provinceID = int.Parse(cmbProvince.SelectedValue.ToString());
            city.cityID = int.Parse(gvCity.SelectedRows[0].Cells["CityID"].Value.ToString());
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                errorProvider1.SetError(this.txtCity, "City name required!");

            }
            else
            {
                int x = bll.UpdateCity(city);
                if (x > 0)
                {
                    MessageBox.Show(" Updated successfully!");
                }
                else
                {
                    MessageBox.Show("Updated successfully!");
                }
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.cityID = int.Parse(gvCity.SelectedRows[0].Cells["City"].Value.ToString());

            int x = bll.DeleteCity(city);

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
            frmSurbub sub = new frmSurbub();
            sub.Show();
            this.Hide();
        }

        private void gvCity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCity.Text = gvCity.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void btnh_Click(object sender, EventArgs e)
        {
            frmAdminDash d = new frmAdminDash();
            d.Show();
            this.Hide();
        }
    }
}
