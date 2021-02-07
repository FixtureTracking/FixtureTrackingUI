
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
            this.tlpMyDebits = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMyDebits = new System.Windows.Forms.DataGridView();
            this.fixtureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpMyDebitsTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblMyDebitTitle = new System.Windows.Forms.Label();
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
            this.tlpMyDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDebits)).BeginInit();
            this.tlpMyDebitsTitle.SuspendLayout();
            this.tlpOperationsSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMyDebits
            // 
            this.tlpMyDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMyDebits.ColumnCount = 1;
            this.tlpMyDebits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebits.Controls.Add(this.dgvMyDebits, 0, 0);
            this.tlpMyDebits.Location = new System.Drawing.Point(130, 31);
            this.tlpMyDebits.Name = "tlpMyDebits";
            this.tlpMyDebits.RowCount = 1;
            this.tlpMyDebits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tlpMyDebits.Size = new System.Drawing.Size(582, 288);
            this.tlpMyDebits.TabIndex = 4;
            this.tlpMyDebits.Visible = false;
            // 
            // dgvMyDebits
            // 
            this.dgvMyDebits.AllowUserToAddRows = false;
            this.dgvMyDebits.AllowUserToDeleteRows = false;
            this.dgvMyDebits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyDebits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyDebits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fixtureName,
            this.debitDescription,
            this.dateDebit,
            this.isReturn});
            this.dgvMyDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyDebits.Location = new System.Drawing.Point(3, 3);
            this.dgvMyDebits.Name = "dgvMyDebits";
            this.dgvMyDebits.ReadOnly = true;
            this.dgvMyDebits.RowTemplate.Height = 25;
            this.dgvMyDebits.Size = new System.Drawing.Size(576, 282);
            this.dgvMyDebits.TabIndex = 2;
            // 
            // fixtureName
            // 
            this.fixtureName.HeaderText = "Fixture Name";
            this.fixtureName.Name = "fixtureName";
            this.fixtureName.ReadOnly = true;
            // 
            // debitDescription
            // 
            this.debitDescription.HeaderText = "Debit Description";
            this.debitDescription.Name = "debitDescription";
            this.debitDescription.ReadOnly = true;
            // 
            // dateDebit
            // 
            this.dateDebit.HeaderText = "Date of Debit";
            this.dateDebit.Name = "dateDebit";
            this.dateDebit.ReadOnly = true;
            // 
            // isReturn
            // 
            this.isReturn.HeaderText = "Debit Return Status";
            this.isReturn.Name = "isReturn";
            this.isReturn.ReadOnly = true;
            // 
            // tlpMyDebitsTitle
            // 
            this.tlpMyDebitsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMyDebitsTitle.ColumnCount = 2;
            this.tlpMyDebitsTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMyDebitsTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebitsTitle.Controls.Add(this.btnRefreshList, 1, 0);
            this.tlpMyDebitsTitle.Controls.Add(this.lblMyDebitTitle, 0, 0);
            this.tlpMyDebitsTitle.Location = new System.Drawing.Point(130, 3);
            this.tlpMyDebitsTitle.Name = "tlpMyDebitsTitle";
            this.tlpMyDebitsTitle.RowCount = 1;
            this.tlpMyDebitsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebitsTitle.Size = new System.Drawing.Size(582, 29);
            this.tlpMyDebitsTitle.TabIndex = 1;
            this.tlpMyDebitsTitle.Visible = false;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(496, 3);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblMyDebitTitle
            // 
            this.lblMyDebitTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMyDebitTitle.AutoSize = true;
            this.lblMyDebitTitle.Location = new System.Drawing.Point(3, 7);
            this.lblMyDebitTitle.Name = "lblMyDebitTitle";
            this.lblMyDebitTitle.Size = new System.Drawing.Size(60, 15);
            this.lblMyDebitTitle.TabIndex = 0;
            this.lblMyDebitTitle.Text = "My Debits";
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
            this.tlpOperationsSideBar.TabIndex = 5;
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
            this.btnCategoryOps.TabIndex = 2;
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
            this.btnSupplierOps.TabIndex = 2;
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
            this.btnDepartmentOps.TabIndex = 2;
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
            this.btnUserOps.TabIndex = 2;
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
            this.btnDebitOps.TabIndex = 2;
            this.btnDebitOps.Text = "Debit Ops";
            this.btnDebitOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebitOps.Click += new System.EventHandler(this.btnDebitOps_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 331);
            this.Controls.Add(this.tlpOperationsSideBar);
            this.Controls.Add(this.tlpMyDebits);
            this.Controls.Add(this.tlpMyDebitsTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMyDebits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDebits)).EndInit();
            this.tlpMyDebitsTitle.ResumeLayout(false);
            this.tlpMyDebitsTitle.PerformLayout();
            this.tlpOperationsSideBar.ResumeLayout(false);
            this.tlpOperationsSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMyDebits;
        private System.Windows.Forms.DataGridView dgvMyDebits;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixtureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReturn;
        private System.Windows.Forms.TableLayoutPanel tlpMyDebitsTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblMyDebitTitle;
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
    }
}