namespace PropertiesApp
{
    partial class frmProperty
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cmbPropType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSuburb = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gvProperty = new System.Windows.Forms.DataGridView();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PROPERTIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Property Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Suburb";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(218, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(208, 175);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(117, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Choose Image";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // cmbPropType
            // 
            this.cmbPropType.FormattingEnabled = true;
            this.cmbPropType.Location = new System.Drawing.Point(658, 121);
            this.cmbPropType.Name = "cmbPropType";
            this.cmbPropType.Size = new System.Drawing.Size(231, 21);
            this.cmbPropType.TabIndex = 10;
            this.cmbPropType.SelectedIndexChanged += new System.EventHandler(this.cmbPropType_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(658, 236);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(231, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // cmbSuburb
            // 
            this.cmbSuburb.FormattingEnabled = true;
            this.cmbSuburb.Location = new System.Drawing.Point(658, 178);
            this.cmbSuburb.Name = "cmbSuburb";
            this.cmbSuburb.Size = new System.Drawing.Size(231, 21);
            this.cmbSuburb.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(639, 339);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 29);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(525, 339);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(96, 29);
            this.btnView.TabIndex = 26;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 29);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(298, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 29);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gvProperty
            // 
            this.gvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProperty.Location = new System.Drawing.Point(94, 395);
            this.gvProperty.Name = "gvProperty";
            this.gvProperty.Size = new System.Drawing.Size(902, 210);
            this.gvProperty.TabIndex = 28;
            this.gvProperty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProperty_CellContentClick);
            this.gvProperty.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProperty_CellMouseClick);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(925, 119);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(359, 249);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 29;
            this.picBox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1296, 631);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.gvProperty);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSuburb);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPropType);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProperty";
            this.Load += new System.EventHandler(this.frmProperty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ComboBox cmbPropType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSuburb;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvProperty;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}