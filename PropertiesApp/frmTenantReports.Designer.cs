namespace PropertiesApp
{
    partial class frmTenantReports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRented = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbAgency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRented
            // 
            this.btnRented.Location = new System.Drawing.Point(29, 129);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(144, 23);
            this.btnRented.TabIndex = 2;
            this.btnRented.Text = "RENTED PROPERTIES";
            this.btnRented.UseVisualStyleBackColor = true;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(313, 202);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 24);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(313, 176);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(100, 20);
            this.txtPrice2.TabIndex = 18;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(313, 131);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 20);
            this.txtPrice1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "End Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Price";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(760, 202);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 24);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbAgency
            // 
            this.cmbAgency.FormattingEnabled = true;
            this.cmbAgency.Location = new System.Drawing.Point(613, 134);
            this.cmbAgency.Name = "cmbAgency";
            this.cmbAgency.Size = new System.Drawing.Size(157, 21);
            this.cmbAgency.TabIndex = 21;
            this.cmbAgency.SelectedIndexChanged += new System.EventHandler(this.cmbAgency_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search by Agency";
            // 
            // frmTenantReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(886, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAgency);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRented);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTenantReports";
            this.Text = "frmTenantReports";
            this.Load += new System.EventHandler(this.frmTenantReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbAgency;
        private System.Windows.Forms.Label label2;
    }
}