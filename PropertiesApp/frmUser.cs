using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PropertiesApp
{
    public partial class frmUser : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataTable dt = new DataTable();
        public frmUser()
        {
            InitializeComponent();
        }

        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.gvUser.Rows[e.RowIndex];

                //txtName.Text = row.SelectedRows[0].Cells[0].Value.ToString();
                //txtSurname.Text = row.Cells[2].Value.ToString();
                //txtEmail.Text = row.Cells[3].Value.ToString();
                //txtPassword.Text = row.Cells[4].Value.ToString();
                //txtPhone.Text = row.Cells[4].Value.ToString();
                //cmbUserType.Text = row.Cells[5].Value.ToString();
                ////cmbSatus.Text = row.Cells[6].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click View");


            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string partten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, partten))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Please enter a valid email!");
                return;
            }
        }
        public void LoadStatus()
        {
            cmbSatus.Items.Add("Active");
            cmbSatus.Items.Add("In-Active");
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            cmbUserType.DataSource = bll.GetRole();
            cmbUserType.DisplayMember = "RoleDescr";
            cmbUserType.ValueMember = "RoleID";

            Refresh();
            LoadStatus();
            gvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Refresh()
        {
            gvUser.DataSource = bll.GetUser();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            dt = bll.GetEmail(txtEmail.Text);
            user.Name = txtName.Text;
            user.surname = txtSurname.Text;
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.phone = txtPhone.Text;
            user.userType = int.Parse(cmbUserType.SelectedValue.ToString());
            user.status = cmbSatus.SelectedItem.ToString();


            if (string.IsNullOrEmpty(txtName.Text)|| string.IsNullOrEmpty(txtSurname.Text)|| 
                string.IsNullOrEmpty(txtPhone.Text)|| string.IsNullOrEmpty(txtPassword.Text)|| string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cmbSatus.Text))
            {
                errorProvider1.SetError(this.txtName, " Name required!");
                errorProvider1.SetError(this.txtSurname, " Surname required!");
                errorProvider1.SetError(this.txtEmail, " Password required!");
                errorProvider1.SetError(this.txtPhone, " Phone number required!"); 
                errorProvider1.SetError(this.cmbSatus, " Status required!");
            }
            else if(dt.Rows.Count >=1)
                {
                MessageBox.Show("Email already exists!");
            }
            else
            {
                int x = bll.InsertUser(user);

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
            User user = new User();


            user.Name = txtName.Text;
            user.surname = txtSurname.Text;
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.phone = txtPhone.Text;
            user.userType = int.Parse(cmbUserType.SelectedValue.ToString());
            user.status = cmbSatus.SelectedItem.ToString();
            user.userID = int.Parse(gvUser.SelectedRows[0].Cells["UserID"].Value.ToString());

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(this.txtName, " Name required!");
                errorProvider1.SetError(this.txtSurname, " Surname required!");
                errorProvider1.SetError(this.txtEmail, " Password required!");
                errorProvider1.SetError(this.txtPhone, " Phone required!");
            }
            else
            {
                int x = bll.UpdateUser(user);
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            gvUser.DataSource = bll.GetInActive();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDash a = new frmAdminDash();
            a.Show();
            this.Hide();
        }

        private void gvUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            txtName.Text = gvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtSurname.Text = gvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = gvUser.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = gvUser.SelectedRows[0].Cells[4].Value.ToString();
            txtPhone.Text = gvUser.SelectedRows[0].Cells[5].Value.ToString();
            cmbUserType.Text = gvUser.SelectedRows[0].Cells[6].Value.ToString();
            cmbSatus.Text = gvUser.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
