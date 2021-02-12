
namespace FixtureTracking.WinForms.Views
{
    partial class FormCategoryOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryOps));
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.clmCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tlpObjectInputs = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tlpListTitle.SuspendLayout();
            this.tlpObjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
            this.tlpObjectInputs.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpListTitle
            // 
            this.tlpListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListTitle.ColumnCount = 2;
            this.tlpListTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpListTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Controls.Add(this.lblListTitle, 0, 0);
            this.tlpListTitle.Controls.Add(this.btnRefreshList, 1, 0);
            this.tlpListTitle.Location = new System.Drawing.Point(318, 5);
            this.tlpListTitle.Name = "tlpListTitle";
            this.tlpListTitle.RowCount = 1;
            this.tlpListTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Size = new System.Drawing.Size(551, 29);
            this.tlpListTitle.TabIndex = 1;
            // 
            // lblListTitle
            // 
            this.lblListTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(3, 7);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(63, 15);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Categories";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(465, 3);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshList.TabIndex = 20;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // tlpObjectList
            // 
            this.tlpObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpObjectList.ColumnCount = 1;
            this.tlpObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpObjectList.Controls.Add(this.dgvObjectList, 0, 0);
            this.tlpObjectList.Location = new System.Drawing.Point(318, 31);
            this.tlpObjectList.Name = "tlpObjectList";
            this.tlpObjectList.RowCount = 1;
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpObjectList.Size = new System.Drawing.Size(551, 182);
            this.tlpObjectList.TabIndex = 2;
            // 
            // dgvObjectList
            // 
            this.dgvObjectList.AllowUserToAddRows = false;
            this.dgvObjectList.AllowUserToDeleteRows = false;
            this.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategoryId,
            this.clmName,
            this.clmDescription,
            this.clmUpdatedAt,
            this.clmUpdate,
            this.clmDelete});
            this.dgvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectList.Location = new System.Drawing.Point(3, 3);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.ReadOnly = true;
            this.dgvObjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvObjectList.RowTemplate.Height = 25;
            this.dgvObjectList.Size = new System.Drawing.Size(545, 176);
            this.dgvObjectList.TabIndex = 21;
            this.dgvObjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjectList_CellClick);
            // 
            // clmCategoryId
            // 
            this.clmCategoryId.HeaderText = "Category Id";
            this.clmCategoryId.Name = "clmCategoryId";
            this.clmCategoryId.ReadOnly = true;
            this.clmCategoryId.Visible = false;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmUpdatedAt
            // 
            this.clmUpdatedAt.HeaderText = "Updated At";
            this.clmUpdatedAt.Name = "clmUpdatedAt";
            this.clmUpdatedAt.ReadOnly = true;
            // 
            // clmUpdate
            // 
            this.clmUpdate.HeaderText = "Update";
            this.clmUpdate.Name = "clmUpdate";
            this.clmUpdate.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // tlpObjectInputs
            // 
            this.tlpObjectInputs.ColumnCount = 2;
            this.tlpObjectInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpObjectInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectInputs.Controls.Add(this.txtName, 1, 0);
            this.tlpObjectInputs.Controls.Add(this.lblName, 0, 0);
            this.tlpObjectInputs.Controls.Add(this.txtDescription, 1, 1);
            this.tlpObjectInputs.Controls.Add(this.lblDescription, 0, 1);
            this.tlpObjectInputs.Controls.Add(this.pnlActionButtons, 1, 2);
            this.tlpObjectInputs.Location = new System.Drawing.Point(12, 12);
            this.tlpObjectInputs.Name = "tlpObjectInputs";
            this.tlpObjectInputs.RowCount = 3;
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpObjectInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectInputs.Size = new System.Drawing.Size(300, 143);
            this.tlpObjectInputs.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(83, 33);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(214, 64);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 30);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "\r\nDescription";
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionButtons.Controls.Add(this.btnAdd);
            this.pnlActionButtons.Controls.Add(this.btnUpdate);
            this.pnlActionButtons.Location = new System.Drawing.Point(167, 103);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(130, 31);
            this.pnlActionButtons.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(30, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Category";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(16, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Category";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormCategoryOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 225);
            this.Controls.Add(this.tlpListTitle);
            this.Controls.Add(this.tlpObjectList);
            this.Controls.Add(this.tlpObjectInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoryOps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking | Category Operations";
            this.Load += new System.EventHandler(this.FormCategoryOps_Load);
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.tlpObjectInputs.ResumeLayout(false);
            this.tlpObjectInputs.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.TableLayoutPanel tlpObjectInputs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUpdatedAt;
        private System.Windows.Forms.DataGridViewLinkColumn clmUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn clmDelete;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Button btnUpdate;
    }
}