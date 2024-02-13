using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;

namespace PropertiesApp
{
    public partial class frmProperty : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public string roleDesc;
        DataTable dt = new DataTable();
        public frmProperty()
        {
            InitializeComponent();
        }

        private void cmbPropType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gvProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvProperty.Rows[e.RowIndex];

                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                cmbPropType.Text = row.Cells[3].Value.ToString();
                cmbStatus.Text = row.Cells[4].Value.ToString();
                cmbSuburb.Text = row.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            cmbPropType.DataSource = bll.GetPropertyType();
            cmbPropType.DisplayMember = "Property Type";
            cmbPropType.ValueMember = "PropertyTypeID";
            cmbPropType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPropType.AutoCompleteSource = AutoCompleteSource.ListItems;




            cmbSuburb.DataSource = bll.GetSuburb();
            cmbSuburb.DisplayMember = "Suburb";
            cmbSuburb.ValueMember = "SuburbID";
            cmbSuburb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSuburb.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadStatus();
            Refresh();
            gvProperty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string imagLoc = "";
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagLoc = dialog.FileName.ToString();
                picBox.ImageLocation = imagLoc;

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Property prop = new Property();

            byte[] images = null;
            FileStream stream = new FileStream(imagLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            images = reader.ReadBytes((int)stream.Length);


            prop.description = txtName.Text;
            prop.price = decimal.Parse(txtPrice.Text.ToString());
            prop.image = images;
            prop.propTypeID = int.Parse(cmbPropType.SelectedValue.ToString());
            prop.subID = int.Parse(cmbSuburb.SelectedValue.ToString());
            prop.status = cmbStatus.SelectedItem.ToString();


            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(this.txtName, "Property name required!");
                errorProvider1.SetError(this.txtPrice, "Price required!");

            }
            else
            {
                int x = bll.InsertProperty(prop);

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
        public void LoadStatus()
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Un-Available");
            cmbStatus.Items.Add("Full");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Property prop = new Property();

            byte[] images = null;
            FileStream stream = new FileStream(imagLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            images = reader.ReadBytes((int)stream.Length);

            prop.propertyID = int.Parse(gvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString());
            prop.description = txtName.Text;
            prop.price = decimal.Parse(txtPrice.Text.ToString());
            prop.image = images;
            prop.propTypeID = int.Parse(cmbPropType.SelectedValue.ToString());
            prop.subID = int.Parse(cmbSuburb.SelectedValue.ToString());
            prop.status = cmbStatus.SelectedItem.ToString();


            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(this.txtName, "Property name required!");
                errorProvider1.SetError(this.txtPrice, "Price required!");

            }
            else
            {
                int x = bll.UpdateProperty(prop);

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
            Property prop = new Property();
            prop.propertyID = int.Parse(gvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString());

            int x = bll.DeleteProperty(prop);

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
            gvProperty.DataSource = bll.GetProperty();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = frmLogin.dtInfo;
            roleDesc = dt.Rows[0]["RoleDescr"].ToString();

            if(roleDesc == "Agent")
            {
                frmAgentDash da = new frmAgentDash();
                da.Show();
                this.Hide();
            }
            else if(roleDesc == "Admin")
            {
                frmAdminDash ad = new frmAdminDash();
                ad.Show();
                this.Hide();
            }
        }

        private void gvProperty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = gvProperty.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = gvProperty.SelectedRows[0].Cells[3].Value.ToString();
            cmbPropType.Text = gvProperty.SelectedRows[0].Cells[4].Value.ToString();
            cmbSuburb.Text = gvProperty.SelectedRows[0].Cells[5].Value.ToString();
            cmbStatus.Text = gvProperty.SelectedRows[0].Cells[6].Value.ToString();
        }
    }

}
