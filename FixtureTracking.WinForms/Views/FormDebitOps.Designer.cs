
namespace FixtureTracking.WinForms.Views
{
    partial class FormDebitOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebitOps));
            this.tlpObjectInputs = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelectFixture = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDateDebit = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebit = new System.Windows.Forms.Label();
            this.lblFixture = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.clmDebitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDebitReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.tlpObjectInputs.SuspendLayout();
            this.tlpObjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
            this.tlpListTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpObjectInputs
            // 
            this.tlpObjectInputs.ColumnCount = 2;
            this.tlpObjectInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpObjectInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectInputs.Controls.Add(this.btnClear, 1, 5);
            this.tlpObjectInputs.Controls.Add(this.btnAdd, 1, 4);
            this.tlpObjectInputs.Controls.Add(this.btnSelectFixture, 1, 2);
            this.tlpObjectInputs.Controls.Add(this.txtDescription, 1, 0);
            this.tlpObjectInputs.Controls.Add(this.lblDescription, 0, 0);
            this.tlpObjectInputs.Controls.Add(this.dtpDateDebit, 1, 1);
            this.tlpObjectInputs.Controls.Add(this.lblDateDebit, 0, 1);
            this.tlpObjectInputs.Controls.Add(this.lblFixture, 0, 2);
            this.tlpObjectInputs.Controls.Add(this.lblUser, 0, 3);
            this.tlpObjectInputs.Controls.Add(this.btnSelectUser, 1, 3);
            this.tlpObjectInputs.Location = new System.Drawing.Point(12, 12);
            this.tlpObjectInputs.Name = "tlpObjectInputs";
            this.tlpObjectInputs.RowCount = 6;
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectInputs.Size = new System.Drawing.Size(262, 258);
            this.tlpObjectInputs.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(178, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Inputs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(178, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Debit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelectFixture
            // 
            this.btnSelectFixture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFixture.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectFixture.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectFixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFixture.Location = new System.Drawing.Point(88, 103);
            this.btnSelectFixture.Name = "btnSelectFixture";
            this.btnSelectFixture.Size = new System.Drawing.Size(171, 26);
            this.btnSelectFixture.TabIndex = 2;
            this.btnSelectFixture.Text = "Select Fixture";
            this.btnSelectFixture.UseVisualStyleBackColor = false;
            this.btnSelectFixture.Click += new System.EventHandler(this.btnSelectFixture_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(88, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 64);
            this.txtDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 30);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "\r\nDescription";
            // 
            // dtpDateDebit
            // 
            this.dtpDateDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateDebit.Location = new System.Drawing.Point(88, 73);
            this.dtpDateDebit.Name = "dtpDateDebit";
            this.dtpDateDebit.Size = new System.Drawing.Size(171, 23);
            this.dtpDateDebit.TabIndex = 1;
            // 
            // lblDateDebit
            // 
            this.lblDateDebit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateDebit.AutoSize = true;
            this.lblDateDebit.Location = new System.Drawing.Point(3, 77);
            this.lblDateDebit.Name = "lblDateDebit";
            this.lblDateDebit.Size = new System.Drawing.Size(76, 15);
            this.lblDateDebit.TabIndex = 0;
            this.lblDateDebit.Text = "Date of Debit";
            // 
            // lblFixture
            // 
            this.lblFixture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFixture.AutoSize = true;
            this.lblFixture.Location = new System.Drawing.Point(3, 108);
            this.lblFixture.Name = "lblFixture";
            this.lblFixture.Size = new System.Drawing.Size(43, 15);
            this.lblFixture.TabIndex = 0;
            this.lblFixture.Text = "Fixture";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 140);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectUser.Location = new System.Drawing.Point(88, 135);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(171, 26);
            this.btnSelectUser.TabIndex = 3;
            this.btnSelectUser.Text = "Select User";
            this.btnSelectUser.UseVisualStyleBackColor = false;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // tlpObjectList
            // 
            this.tlpObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpObjectList.ColumnCount = 1;
            this.tlpObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectList.Controls.Add(this.dgvObjectList, 0, 0);
            this.tlpObjectList.Location = new System.Drawing.Point(280, 32);
            this.tlpObjectList.Name = "tlpObjectList";
            this.tlpObjectList.RowCount = 1;
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tlpObjectList.Size = new System.Drawing.Size(822, 273);
            this.tlpObjectList.TabIndex = 2;
            // 
            // dgvObjectList
            // 
            this.dgvObjectList.AllowUserToAddRows = false;
            this.dgvObjectList.AllowUserToDeleteRows = false;
            this.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDebitId,
            this.clmDescription,
            this.clmFixture,
            this.clmUser,
            this.clmDepartment,
            this.clmDateDebit,
            this.clmDebitReturn,
            this.clmDateReturn,
            this.clmDelete});
            this.dgvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectList.Location = new System.Drawing.Point(3, 3);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.ReadOnly = true;
            this.dgvObjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvObjectList.RowTemplate.Height = 25;
            this.dgvObjectList.Size = new System.Drawing.Size(816, 267);
            this.dgvObjectList.TabIndex = 21;
            this.dgvObjectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjectList_CellContentClick);
            // 
            // clmDebitId
            // 
            this.clmDebitId.HeaderText = "Debit Id";
            this.clmDebitId.Name = "clmDebitId";
            this.clmDebitId.ReadOnly = true;
            this.clmDebitId.Visible = false;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmFixture
            // 
            this.clmFixture.HeaderText = "Fixture";
            this.clmFixture.Name = "clmFixture";
            this.clmFixture.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "User";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // clmDepartment
            // 
            this.clmDepartment.HeaderText = "Department";
            this.clmDepartment.Name = "clmDepartment";
            this.clmDepartment.ReadOnly = true;
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
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
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
            this.tlpListTitle.Location = new System.Drawing.Point(280, 5);
            this.tlpListTitle.Name = "tlpListTitle";
            this.tlpListTitle.RowCount = 1;
            this.tlpListTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Size = new System.Drawing.Size(822, 29);
            this.tlpListTitle.TabIndex = 1;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(736, 3);
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
            this.lblListTitle.Size = new System.Drawing.Size(40, 15);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Debits";
            // 
            // FormDebitOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 317);
            this.Controls.Add(this.tlpObjectList);
            this.Controls.Add(this.tlpListTitle);
            this.Controls.Add(this.tlpObjectInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDebitOps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking | Debit Operations";
            this.Load += new System.EventHandler(this.FormDebitOps_Load);
            this.tlpObjectInputs.ResumeLayout(false);
            this.tlpObjectInputs.PerformLayout();
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpObjectInputs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateDebit;
        private System.Windows.Forms.Label lblFixture;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dtpDateDebit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelectFixture;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDebitReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateReturn;
        private System.Windows.Forms.DataGridViewLinkColumn clmDelete;
    }
}