
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
            this.btnSlcFixture = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWarranty = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSlcUser = new System.Windows.Forms.Button();
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.clmDebitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameOfUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.tlpObjectInputs.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
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
            this.tlpObjectInputs.Controls.Add(this.btnSlcFixture, 1, 2);
            this.tlpObjectInputs.Controls.Add(this.txtDescription, 1, 0);
            this.tlpObjectInputs.Controls.Add(this.label1, 0, 0);
            this.tlpObjectInputs.Controls.Add(this.dtpWarranty, 1, 1);
            this.tlpObjectInputs.Controls.Add(this.label2, 0, 1);
            this.tlpObjectInputs.Controls.Add(this.label3, 0, 2);
            this.tlpObjectInputs.Controls.Add(this.label4, 0, 3);
            this.tlpObjectInputs.Controls.Add(this.pnlActionButtons, 1, 4);
            this.tlpObjectInputs.Controls.Add(this.btnSlcUser, 1, 3);
            this.tlpObjectInputs.Location = new System.Drawing.Point(12, 12);
            this.tlpObjectInputs.Name = "tlpObjectInputs";
            this.tlpObjectInputs.RowCount = 5;
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectInputs.Size = new System.Drawing.Size(262, 203);
            this.tlpObjectInputs.TabIndex = 8;
            // 
            // btnSlcFixture
            // 
            this.btnSlcFixture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlcFixture.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlcFixture.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSlcFixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlcFixture.Location = new System.Drawing.Point(88, 103);
            this.btnSlcFixture.Name = "btnSlcFixture";
            this.btnSlcFixture.Size = new System.Drawing.Size(171, 26);
            this.btnSlcFixture.TabIndex = 10;
            this.btnSlcFixture.Text = "Select Fixture";
            this.btnSlcFixture.UseVisualStyleBackColor = false;
            this.btnSlcFixture.Click += new System.EventHandler(this.btnSlcFixture_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(88, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 64);
            this.txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nDescription";
            // 
            // dtpWarranty
            // 
            this.dtpWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpWarranty.Location = new System.Drawing.Point(88, 73);
            this.dtpWarranty.Name = "dtpWarranty";
            this.dtpWarranty.Size = new System.Drawing.Size(171, 23);
            this.dtpWarranty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Debit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fixture";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "User";
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionButtons.Controls.Add(this.btnAdd);
            this.pnlActionButtons.Location = new System.Drawing.Point(129, 167);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(130, 31);
            this.pnlActionButtons.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(49, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Debit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSlcUser
            // 
            this.btnSlcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlcUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlcUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSlcUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlcUser.Location = new System.Drawing.Point(88, 135);
            this.btnSlcUser.Name = "btnSlcUser";
            this.btnSlcUser.Size = new System.Drawing.Size(171, 26);
            this.btnSlcUser.TabIndex = 10;
            this.btnSlcUser.Text = "Select User";
            this.btnSlcUser.UseVisualStyleBackColor = false;
            this.btnSlcUser.Click += new System.EventHandler(this.btnSlcUser_Click);
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
            this.tlpObjectList.TabIndex = 10;
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
            this.clmNameOfUser,
            this.clmDepartment,
            this.clmDateDebit,
            this.clmIsReturn,
            this.clmDateReturn,
            this.clmDelete});
            this.dgvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectList.Location = new System.Drawing.Point(3, 3);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.ReadOnly = true;
            this.dgvObjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvObjectList.RowTemplate.Height = 25;
            this.dgvObjectList.Size = new System.Drawing.Size(816, 267);
            this.dgvObjectList.TabIndex = 2;
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
            // clmNameOfUser
            // 
            this.clmNameOfUser.HeaderText = "User";
            this.clmNameOfUser.Name = "clmNameOfUser";
            this.clmNameOfUser.ReadOnly = true;
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
            // clmIsReturn
            // 
            this.clmIsReturn.HeaderText = "Debit Return Status";
            this.clmIsReturn.Name = "clmIsReturn";
            this.clmIsReturn.ReadOnly = true;
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
            this.tlpListTitle.TabIndex = 9;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(736, 3);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshList.TabIndex = 2;
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
            this.pnlActionButtons.ResumeLayout(false);
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpObjectInputs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpWarranty;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSlcFixture;
        private System.Windows.Forms.Button btnSlcUser;
        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameOfUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateReturn;
        private System.Windows.Forms.DataGridViewLinkColumn clmDelete;
    }
}