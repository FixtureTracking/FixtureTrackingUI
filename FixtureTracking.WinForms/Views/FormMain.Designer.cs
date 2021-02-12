
namespace FixtureTracking.WinForms.Views
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.clmDebitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDebitReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.tlpOperationsSideBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnCategoryOps = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblOperationTitle = new System.Windows.Forms.Label();
            this.btnSupplierOps = new System.Windows.Forms.Button();
            this.btnFixtureOps = new System.Windows.Forms.Button();
            this.btnDepartmentOps = new System.Windows.Forms.Button();
            this.btnUserOps = new System.Windows.Forms.Button();
            this.btnDebitOps = new System.Windows.Forms.Button();
            this.tlpObjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
            this.tlpListTitle.SuspendLayout();
            this.tlpOperationsSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpObjectList
            // 
            this.tlpObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpObjectList.ColumnCount = 1;
            this.tlpObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectList.Controls.Add(this.dgvObjectList, 0, 0);
            this.tlpObjectList.Location = new System.Drawing.Point(130, 31);
            this.tlpObjectList.Name = "tlpObjectList";
            this.tlpObjectList.RowCount = 1;
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tlpObjectList.Size = new System.Drawing.Size(661, 288);
            this.tlpObjectList.TabIndex = 2;
            this.tlpObjectList.Visible = false;
            // 
            // dgvObjectList
            // 
            this.dgvObjectList.AllowUserToAddRows = false;
            this.dgvObjectList.AllowUserToDeleteRows = false;
            this.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDebitId,
            this.clmFixture,
            this.clmDescription,
            this.clmDateDebit,
            this.clmDebitReturn,
            this.clmDateReturn});
            this.dgvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectList.Location = new System.Drawing.Point(3, 3);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.ReadOnly = true;
            this.dgvObjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvObjectList.RowTemplate.Height = 25;
            this.dgvObjectList.Size = new System.Drawing.Size(655, 282);
            this.dgvObjectList.TabIndex = 21;
            // 
            // clmDebitId
            // 
            this.clmDebitId.HeaderText = "Debit Id";
            this.clmDebitId.Name = "clmDebitId";
            this.clmDebitId.ReadOnly = true;
            this.clmDebitId.Visible = false;
            // 
            // clmFixture
            // 
            this.clmFixture.HeaderText = "Fixture Name";
            this.clmFixture.Name = "clmFixture";
            this.clmFixture.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Debit Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmDateDebit
            // 
            this.clmDateDebit.HeaderText = "Date of Debit";
            this.clmDateDebit.Name = "clmDateDebit";
            this.clmDateDebit.ReadOnly = true;
            // 
            // clmDebitReturn
            // 
            this.clmDebitReturn.HeaderText = "Debit Return Status";
            this.clmDebitReturn.Name = "clmDebitReturn";
            this.clmDebitReturn.ReadOnly = true;
            // 
            // clmDateReturn
            // 
            this.clmDateReturn.HeaderText = "Date of Return";
            this.clmDateReturn.Name = "clmDateReturn";
            this.clmDateReturn.ReadOnly = true;
            // 
            // tlpListTitle
            // 
            this.tlpListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListTitle.ColumnCount = 2;
            this.tlpListTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpListTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Controls.Add(this.btnRefreshList, 1, 0);
            this.tlpListTitle.Controls.Add(this.lblListTitle, 0, 0);
            this.tlpListTitle.Location = new System.Drawing.Point(130, 3);
            this.tlpListTitle.Name = "tlpListTitle";
            this.tlpListTitle.RowCount = 1;
            this.tlpListTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Size = new System.Drawing.Size(661, 29);
            this.tlpListTitle.TabIndex = 1;
            this.tlpListTitle.Visible = false;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(575, 3);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshList.TabIndex = 20;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblListTitle
            // 
            this.lblListTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(3, 7);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(60, 15);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "My Debits";
            // 
            // tlpOperationsSideBar
            // 
            this.tlpOperationsSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpOperationsSideBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpOperationsSideBar.ColumnCount = 1;
            this.tlpOperationsSideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOperationsSideBar.Controls.Add(this.btnCategoryOps, 0, 1);
            this.tlpOperationsSideBar.Controls.Add(this.lblName, 0, 11);
            this.tlpOperationsSideBar.Controls.Add(this.lblDepartment, 0, 10);
            this.tlpOperationsSideBar.Controls.Add(this.lblOperationTitle, 0, 0);
            this.tlpOperationsSideBar.Controls.Add(this.btnSupplierOps, 0, 2);
            this.tlpOperationsSideBar.Controls.Add(this.btnFixtureOps, 0, 3);
            this.tlpOperationsSideBar.Controls.Add(this.btnDepartmentOps, 0, 5);
            this.tlpOperationsSideBar.Controls.Add(this.btnUserOps, 0, 6);
            this.tlpOperationsSideBar.Controls.Add(this.btnDebitOps, 0, 8);
            this.tlpOperationsSideBar.Location = new System.Drawing.Point(7, 3);
            this.tlpOperationsSideBar.Name = "tlpOperationsSideBar";
            this.tlpOperationsSideBar.RowCount = 12;
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOperationsSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOperationsSideBar.Size = new System.Drawing.Size(117, 313);
            this.tlpOperationsSideBar.TabIndex = 0;
            this.tlpOperationsSideBar.Visible = false;
            // 
            // btnCategoryOps
            // 
            this.btnCategoryOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCategoryOps.AutoSize = true;
            this.btnCategoryOps.Enabled = false;
            this.btnCategoryOps.FlatAppearance.BorderSize = 0;
            this.btnCategoryOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryOps.Location = new System.Drawing.Point(3, 38);
            this.btnCategoryOps.Name = "btnCategoryOps";
            this.btnCategoryOps.Size = new System.Drawing.Size(111, 24);
            this.btnCategoryOps.TabIndex = 0;
            this.btnCategoryOps.Text = "Category Ops";
            this.btnCategoryOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryOps.Click += new System.EventHandler(this.btnCategoryOps_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 295);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(3, 275);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 15);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // lblOperationTitle
            // 
            this.lblOperationTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOperationTitle.AutoSize = true;
            this.lblOperationTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperationTitle.Location = new System.Drawing.Point(3, 7);
            this.lblOperationTitle.Name = "lblOperationTitle";
            this.lblOperationTitle.Size = new System.Drawing.Size(90, 20);
            this.lblOperationTitle.TabIndex = 1;
            this.lblOperationTitle.Text = " Operations";
            // 
            // btnSupplierOps
            // 
            this.btnSupplierOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSupplierOps.AutoSize = true;
            this.btnSupplierOps.Enabled = false;
            this.btnSupplierOps.FlatAppearance.BorderSize = 0;
            this.btnSupplierOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierOps.Location = new System.Drawing.Point(3, 68);
            this.btnSupplierOps.Name = "btnSupplierOps";
            this.btnSupplierOps.Size = new System.Drawing.Size(111, 24);
            this.btnSupplierOps.TabIndex = 1;
            this.btnSupplierOps.Text = "Supplier Ops";
            this.btnSupplierOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierOps.Click += new System.EventHandler(this.btnSupplierOps_Click);
            // 
            // btnFixtureOps
            // 
            this.btnFixtureOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFixtureOps.AutoSize = true;
            this.btnFixtureOps.Enabled = false;
            this.btnFixtureOps.FlatAppearance.BorderSize = 0;
            this.btnFixtureOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixtureOps.Location = new System.Drawing.Point(3, 98);
            this.btnFixtureOps.Name = "btnFixtureOps";
            this.btnFixtureOps.Size = new System.Drawing.Size(111, 24);
            this.btnFixtureOps.TabIndex = 2;
            this.btnFixtureOps.Text = "Fixture Ops";
            this.btnFixtureOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixtureOps.Click += new System.EventHandler(this.btnFixtureOps_Click);
            // 
            // btnDepartmentOps
            // 
            this.btnDepartmentOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDepartmentOps.AutoSize = true;
            this.btnDepartmentOps.Enabled = false;
            this.btnDepartmentOps.FlatAppearance.BorderSize = 0;
            this.btnDepartmentOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentOps.Location = new System.Drawing.Point(3, 143);
            this.btnDepartmentOps.Name = "btnDepartmentOps";
            this.btnDepartmentOps.Size = new System.Drawing.Size(111, 24);
            this.btnDepartmentOps.TabIndex = 3;
            this.btnDepartmentOps.Text = "Department Ops";
            this.btnDepartmentOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentOps.Click += new System.EventHandler(this.btnDepartmentOps_Click);
            // 
            // btnUserOps
            // 
            this.btnUserOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUserOps.AutoSize = true;
            this.btnUserOps.Enabled = false;
            this.btnUserOps.FlatAppearance.BorderSize = 0;
            this.btnUserOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOps.Location = new System.Drawing.Point(3, 173);
            this.btnUserOps.Name = "btnUserOps";
            this.btnUserOps.Size = new System.Drawing.Size(111, 24);
            this.btnUserOps.TabIndex = 4;
            this.btnUserOps.Text = "User Ops";
            this.btnUserOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserOps.Click += new System.EventHandler(this.btnUserOps_Click);
            // 
            // btnDebitOps
            // 
            this.btnDebitOps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDebitOps.AutoSize = true;
            this.btnDebitOps.Enabled = false;
            this.btnDebitOps.FlatAppearance.BorderSize = 0;
            this.btnDebitOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebitOps.Location = new System.Drawing.Point(3, 218);
            this.btnDebitOps.Name = "btnDebitOps";
            this.btnDebitOps.Size = new System.Drawing.Size(111, 24);
            this.btnDebitOps.TabIndex = 5;
            this.btnDebitOps.Text = "Debit Ops";
            this.btnDebitOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebitOps.Click += new System.EventHandler(this.btnDebitOps_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 331);
            this.Controls.Add(this.tlpOperationsSideBar);
            this.Controls.Add(this.tlpObjectList);
            this.Controls.Add(this.tlpListTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.tlpOperationsSideBar.ResumeLayout(false);
            this.tlpOperationsSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.TableLayoutPanel tlpOperationsSideBar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblOperationTitle;
        private System.Windows.Forms.Button btnCategoryOps;
        private System.Windows.Forms.Button btnSupplierOps;
        private System.Windows.Forms.Button btnFixtureOps;
        private System.Windows.Forms.Button btnDepartmentOps;
        private System.Windows.Forms.Button btnUserOps;
        private System.Windows.Forms.Button btnDebitOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDebitReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateReturn;
    }
}