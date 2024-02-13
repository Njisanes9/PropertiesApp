namespace PropertiesApp
{
    partial class frmRental
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
            this.lblRental = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gvRental = new System.Windows.Forms.DataGridView();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYourProps = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvProperties = new System.Windows.Forms.DataGridView();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRental);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(425, 27);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(323, 43);
            this.lblRental.TabIndex = 0;
            this.lblRental.Text = "PROPERTY RENTAL";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(730, 164);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(87, 21);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(730, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Property";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MM-yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(968, 165);
            this.dtStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 4;
            this.dtStart.Value = new System.DateTime(2022, 9, 30, 23, 31, 16, 0);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd-MM-yyyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(968, 224);
            this.dtEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1156, 313);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 29);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightGray;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1042, 313);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(96, 29);
            this.btnView.TabIndex = 41;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(930, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 29);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(815, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(698, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 29);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gvRental
            // 
            this.gvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRental.Location = new System.Drawing.Point(698, 348);
            this.gvRental.Name = "gvRental";
            this.gvRental.Size = new System.Drawing.Size(660, 233);
            this.gvRental.TabIndex = 43;
            this.gvRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRental_CellContentClick);
            this.gvRental.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvRental_CellMouseClick);
            // 
            // cmbProperty
            // 
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(968, 111);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(284, 21);
            this.cmbProperty.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYourProps);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.gvProperties);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 486);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // lblYourProps
            // 
            this.lblYourProps.AutoSize = true;
            this.lblYourProps.Location = new System.Drawing.Point(280, 103);
            this.lblYourProps.Name = "lblYourProps";
            this.lblYourProps.Size = new System.Drawing.Size(178, 20);
            this.lblYourProps.TabIndex = 4;
            this.lblYourProps.Text = "YOUR PROPERTIES";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by City";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvProperties
            // 
            this.gvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProperties.Location = new System.Drawing.Point(15, 133);
            this.gvProperties.Name = "gvProperties";
            this.gvProperties.Size = new System.Drawing.Size(659, 337);
            this.gvProperties.TabIndex = 1;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(15, 53);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(261, 26);
            this.txtProvince.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(968, 271);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(226, 21);
            this.cmbStatus.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(730, 271);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 21);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1370, 624);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbProperty);
            this.Controls.Add(this.gvRental);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.panel1);
            this.Name = "frmRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRental";
            this.Load += new System.EventHandler(this.frmRental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvRental;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvProperties;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblYourProps;
    }
}