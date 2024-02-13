namespace PropertiesApp
{
    partial class frmAdminReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.btnUser = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnProvinces = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTenants = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRentedProp = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTS";
            // 
            // gvReports
            // 
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Location = new System.Drawing.Point(12, 242);
            this.gvReports.Name = "gvReports";
            this.gvReports.Size = new System.Drawing.Size(1041, 219);
            this.gvReports.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(12, 116);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(116, 30);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "All Users";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(112, 175);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(191, 21);
            this.cmbUsers.TabIndex = 4;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Users";
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(144, 116);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(116, 30);
            this.btnProperties.TabIndex = 6;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnProvinces
            // 
            this.btnProvinces.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvinces.Location = new System.Drawing.Point(277, 116);
            this.btnProvinces.Name = "btnProvinces";
            this.btnProvinces.Size = new System.Drawing.Size(116, 30);
            this.btnProvinces.TabIndex = 7;
            this.btnProvinces.Text = "Provinces";
            this.btnProvinces.UseVisualStyleBackColor = true;
            this.btnProvinces.Click += new System.EventHandler(this.btnProvinces_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tenants";
            // 
            // cmbTenants
            // 
            this.cmbTenants.FormattingEnabled = true;
            this.cmbTenants.Location = new System.Drawing.Point(427, 175);
            this.cmbTenants.Name = "cmbTenants";
            this.cmbTenants.Size = new System.Drawing.Size(205, 21);
            this.cmbTenants.TabIndex = 9;
            this.cmbTenants.SelectedIndexChanged += new System.EventHandler(this.cmbTenants_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Price";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(563, 126);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 20);
            this.txtPrice1.TabIndex = 12;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(780, 127);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(100, 20);
            this.txtPrice2.TabIndex = 13;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(886, 124);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 24);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRentedProp
            // 
            this.btnRentedProp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentedProp.Location = new System.Drawing.Point(690, 173);
            this.btnRentedProp.Name = "btnRentedProp";
            this.btnRentedProp.Size = new System.Drawing.Size(155, 32);
            this.btnRentedProp.TabIndex = 15;
            this.btnRentedProp.Text = "Rented Properties";
            this.btnRentedProp.UseVisualStyleBackColor = true;
            this.btnRentedProp.Click += new System.EventHandler(this.btnRentedProp_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(963, 467);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 24);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmAdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1090, 515);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRentedProp);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTenants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProvinces);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdminReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminReports";
            this.Load += new System.EventHandler(this.frmAdminReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnProvinces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTenants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRentedProp;
        private System.Windows.Forms.Button btnHome;
    }
}