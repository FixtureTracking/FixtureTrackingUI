﻿
namespace FixtureTracking.WinForms.Views
{
    partial class FormDebitsOfUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebitsOfUser));
            this.tlpObjectList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.tlpListTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.clmDebitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDebitReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpObjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
            this.tlpListTitle.SuspendLayout();
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
            this.tlpObjectList.Location = new System.Drawing.Point(12, 35);
            this.tlpObjectList.Name = "tlpObjectList";
            this.tlpObjectList.RowCount = 1;
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tlpObjectList.Size = new System.Drawing.Size(644, 261);
            this.tlpObjectList.TabIndex = 2;
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
            this.dgvObjectList.Size = new System.Drawing.Size(638, 255);
            this.dgvObjectList.TabIndex = 3;
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
            this.tlpListTitle.Location = new System.Drawing.Point(12, 7);
            this.tlpListTitle.Name = "tlpListTitle";
            this.tlpListTitle.RowCount = 1;
            this.tlpListTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListTitle.Size = new System.Drawing.Size(644, 29);
            this.tlpListTitle.TabIndex = 0;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Location = new System.Drawing.Point(558, 3);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshList.TabIndex = 1;
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
            this.clmDebitReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmDebitReturn.HeaderText = "Debit Return";
            this.clmDebitReturn.Name = "clmDebitReturn";
            this.clmDebitReturn.ReadOnly = true;
            this.clmDebitReturn.Width = 79;
            // 
            // clmDateReturn
            // 
            this.clmDateReturn.HeaderText = "Date of Return";
            this.clmDateReturn.Name = "clmDateReturn";
            this.clmDateReturn.ReadOnly = true;
            // 
            // FormDebitsOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 308);
            this.Controls.Add(this.tlpObjectList);
            this.Controls.Add(this.tlpListTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDebitsOfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking | Debits of ";
            this.Load += new System.EventHandler(this.FormDebitsOfUser_Load);
            this.tlpObjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.tlpListTitle.ResumeLayout(false);
            this.tlpListTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpObjectList;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.TableLayoutPanel tlpListTitle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDebitReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateReturn;
    }
}