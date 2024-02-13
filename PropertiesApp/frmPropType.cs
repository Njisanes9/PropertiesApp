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
    public partial class frmPropType : Form
    {

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmPropType()
        {
            InitializeComponent();
        }

        private void frmPropType_Load(object sender, EventArgs e)
        {
            Refresh();
            gvTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gvTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvTypes.Rows[e.RowIndex];

                txtType.Text = row.Cells[1].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Please click View");
            }
        }
        public void Refresh()
        {
            gvTypes.DataSource = bll.GetPropertyType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyType propType = new PropertyType();

            propType.description = txtType.Text;



            if (string.IsNullOrEmpty(txtType.Text))
            {
                errorProvider1.SetError(this.txtType, "Property type required!");

            }
            else
            {
                int x = bll.InsertPropertyType(propType);

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
            PropertyType propType = new PropertyType();

            propType.description = txtType.Text;

            propType.propTypeID = int.Parse(gvTypes.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString());
            if (string.IsNullOrEmpty(txtType.Text))
            {
                errorProvider1.SetError(this.txtType, "Property type required!");

            }
            else
            {
                int x = bll.UpdatePropertyType(propType);
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
            PropertyType propType = new PropertyType();
            propType.propTypeID = int.Parse(gvTypes.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString());

            int x = bll.DeletePropertyType(propType);

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
            frmAdminDash ad = new frmAdminDash();
            ad.Show();
            this.Hide();
        }

        private void gvTypes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtType.Text = gvTypes.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
