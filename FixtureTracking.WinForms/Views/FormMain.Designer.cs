
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
            this.tlpUserDep = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserDepartment = new System.Windows.Forms.Label();
            this.dgvMyDebits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMyDebits = new System.Windows.Forms.TableLayoutPanel();
            this.FixtureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpUserDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDebits)).BeginInit();
            this.tlpMyDebits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUserDep
            // 
            this.tlpUserDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserDep.ColumnCount = 2;
            this.tlpUserDep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDep.Controls.Add(this.lblUserDepartment, 1, 0);
            this.tlpUserDep.Location = new System.Drawing.Point(12, 3);
            this.tlpUserDep.Name = "tlpUserDep";
            this.tlpUserDep.RowCount = 1;
            this.tlpUserDep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDep.Size = new System.Drawing.Size(639, 26);
            this.tlpUserDep.TabIndex = 1;
            this.tlpUserDep.Visible = false;
            // 
            // lblUserDepartment
            // 
            this.lblUserDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserDepartment.AutoSize = true;
            this.lblUserDepartment.Location = new System.Drawing.Point(532, 5);
            this.lblUserDepartment.Name = "lblUserDepartment";
            this.lblUserDepartment.Size = new System.Drawing.Size(104, 15);
            this.lblUserDepartment.TabIndex = 0;
            this.lblUserDepartment.Text = "User - Department";
            // 
            // dgvMyDebits
            // 
            this.dgvMyDebits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyDebits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyDebits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FixtureName,
            this.DebitDescription,
            this.DateDebit,
            this.IsReturn});
            this.dgvMyDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyDebits.Location = new System.Drawing.Point(3, 23);
            this.dgvMyDebits.Name = "dgvMyDebits";
            this.dgvMyDebits.ReadOnly = true;
            this.dgvMyDebits.RowTemplate.Height = 25;
            this.dgvMyDebits.Size = new System.Drawing.Size(633, 292);
            this.dgvMyDebits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Debits";
            // 
            // tlpMyDebits
            // 
            this.tlpMyDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMyDebits.ColumnCount = 1;
            this.tlpMyDebits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebits.Controls.Add(this.dgvMyDebits, 0, 1);
            this.tlpMyDebits.Controls.Add(this.label1, 0, 0);
            this.tlpMyDebits.Location = new System.Drawing.Point(12, 35);
            this.tlpMyDebits.Name = "tlpMyDebits";
            this.tlpMyDebits.RowCount = 2;
            this.tlpMyDebits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMyDebits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMyDebits.Size = new System.Drawing.Size(639, 318);
            this.tlpMyDebits.TabIndex = 4;
            this.tlpMyDebits.Visible = false;
            // 
            // FixtureName
            // 
            this.FixtureName.HeaderText = "Fixture Name";
            this.FixtureName.Name = "FixtureName";
            this.FixtureName.ReadOnly = true;
            // 
            // DebitDescription
            // 
            this.DebitDescription.HeaderText = "Debit Description";
            this.DebitDescription.Name = "DebitDescription";
            this.DebitDescription.ReadOnly = true;
            // 
            // DateDebit
            // 
            this.DateDebit.HeaderText = "Date of Debit";
            this.DateDebit.Name = "DateDebit";
            this.DateDebit.ReadOnly = true;
            // 
            // IsReturn
            // 
            this.IsReturn.HeaderText = "Debit Return Status";
            this.IsReturn.Name = "IsReturn";
            this.IsReturn.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 365);
            this.Controls.Add(this.tlpMyDebits);
            this.Controls.Add(this.tlpUserDep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixture Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpUserDep.ResumeLayout(false);
            this.tlpUserDep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDebits)).EndInit();
            this.tlpMyDebits.ResumeLayout(false);
            this.tlpMyDebits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpUserDep;
        private System.Windows.Forms.Label lblUserDepartment;
        private System.Windows.Forms.DataGridView dgvMyDebits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpMyDebits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixtureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReturn;
    }
}