
namespace FixtureTracking.WinForms.Views
{
    partial class FormSelectFixture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectFixture));
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.clmFixtureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateWarranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpListTitle.SuspendLayout();
            this.tlpObjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
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
            this.tlpListTitle.Location = new System.Drawing.Point(12, 5);
            this.tlpListTitle.Name = "tlpListTitle";
            this.tlpListTitle.RowCount = 1;
            this.tlpListTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Size = new System.Drawing.Size(709, 29);
            this.tlpListTitle.TabIndex = 11;
            // 
            // lblListTitle
            // 
            this.lblListTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(3, 7);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(48, 15);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Fixtures";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(623, 3);
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
            this.tlpObjectList.Location = new System.Drawing.Point(12, 31);
            this.tlpObjectList.Name = "tlpObjectList";
            this.tlpObjectList.RowCount = 1;
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpObjectList.Size = new System.Drawing.Size(709, 281);
            this.tlpObjectList.TabIndex = 10;
            // 
            // dgvObjectList
            // 
            this.dgvObjectList.AllowUserToAddRows = false;
            this.dgvObjectList.AllowUserToDeleteRows = false;
            this.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFixtureId,
            this.clmName,
            this.clmDescription,
            this.clmDateWarranty,
            this.clmUpdatedAt,
            this.clmSelect});
            this.dgvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectList.Location = new System.Drawing.Point(3, 3);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.ReadOnly = true;
            this.dgvObjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvObjectList.RowTemplate.Height = 25;
            this.dgvObjectList.Size = new System.Drawing.Size(703, 275);
            this.dgvObjectList.TabIndex = 100;
            this.dgvObjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjectList_CellClick);
            // 
            // clmFixtureId
            // 
            this.clmFixtureId.HeaderText = "Fixture Id";
            this.clmFixtureId.Name = "clmFixtureId";
            this.clmFixtureId.ReadOnly = true;
            this.clmFixtureId.Visible = false;
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
            // clmDateWarranty
            // 
            this.clmDateWarranty.HeaderText = "Date Warranty";
            this.clmDateWarranty.Name = "clmDateWarranty";
            this.clmDateWarranty.ReadOnly = true;
            // 
            // clmUpdatedAt
            // 
            this.clmUpdatedAt.HeaderText = "Updated At";
            this.clmUpdatedAt.Name = "clmUpdatedAt";
            this.clmUpdatedAt.ReadOnly = true;
            // 
            // clmSelect
            // 
            this.clmSelect.HeaderText = "Select";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.ReadOnly = true;
            this.clmSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSelect.Text = "";
            // 
            // FormSelectFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 324);
            this.Controls.Add(this.tlpListTitle);
            this.Controls.Add(this.tlpObjectList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectFixture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking | Select User for Debit Operations";
            this.Load += new System.EventHandler(this.FormSelectFixture_Load);
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFixtureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateWarranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUpdatedAt;
        private System.Windows.Forms.DataGridViewButtonColumn clmSelect;
    }
}