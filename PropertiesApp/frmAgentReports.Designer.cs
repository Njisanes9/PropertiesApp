namespace PropertiesApp
{
    partial class frmAgentReports
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
            this.dtReports = new System.Windows.Forms.DataGridView();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 1;
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
            // dtReports
            // 
            this.dtReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReports.Location = new System.Drawing.Point(31, 237);
            this.dtReports.Name = "dtReports";
            this.dtReports.Size = new System.Drawing.Size(887, 201);
            this.dtReports.TabIndex = 2;
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(31, 132);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(142, 31);
            this.btnProperties.TabIndex = 3;
            this.btnProperties.Text = "My Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(776, 198);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 31);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmAgentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.dtReports);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgentReports";
            this.Text = "frmAgentReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtReports;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnHome;
    }
}