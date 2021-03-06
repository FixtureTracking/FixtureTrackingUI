﻿using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Security;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();

            await LoadUserDetail();
            await LoadMyDebits();
            EditSidebarSections();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadMyDebits();
        }

        private void btnCategoryOps_Click(object sender, EventArgs e)
        {
            FormCategoryOps formCategoryOps = new FormCategoryOps();
            formCategoryOps.ShowDialog();
        }

        private void btnSupplierOps_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private async void btnFixtureOps_Click(object sender, EventArgs e)
        {
            FormFixtureOps formFixtureOps = new FormFixtureOps();
            formFixtureOps.ShowDialog();
            await LoadMyDebits();
        }

        private void btnDepartmentOps_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void btnUserOps_Click(object sender, EventArgs e)
        {
            FormUserOps formUserOps = new FormUserOps();
            formUserOps.ShowDialog();
        }

        private async void btnDebitOps_Click(object sender, EventArgs e)
        {
            FormDebitOps formDebitOps = new FormDebitOps();
            formDebitOps.ShowDialog();
            await LoadMyDebits();
        }

        private async Task LoadUserDetail()
        {
            var user = await UserService.GetDetail(FormCurrentUser.UserId);
            FormCurrentUser.SetValues(user);

            lblName.Text = FormCurrentUser.FullName;
            lblDepartment.Text = FormCurrentUser.DepartmentName;

            tlpOperationsSideBar.Visible = true;
        }

        private async Task LoadMyDebits()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var debits = await UserService.GetDebits(FormCurrentUser.UserId);
            debits.ForEach(debitDto =>
            {
                string dateReturn = debitDto.Debit.IsReturn ? debitDto.Debit.DateReturn.ToShortDateString() : "-";
                dgvObjectList.Rows.Add(debitDto.Debit.Id, debitDto.FixtureName, debitDto.Debit.Description, debitDto.Debit.DateDebit.Date, debitDto.Debit.IsReturn, dateReturn);
            });
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmDateReturn)], System.ComponentModel.ListSortDirection.Ascending);

            tlpListTitle.Visible = true;
            tlpObjectList.Visible = true;
        }

        private void EditSidebarSections()
        {
            var departmentId = FormCurrentUser.DepartmentId;

            switch (departmentId)
            {
                case 1: // director
                    btnCategoryOps.Enabled = true;
                    btnSupplierOps.Enabled = true;
                    btnFixtureOps.Enabled = true;
                    btnDepartmentOps.Enabled = true;
                    btnUserOps.Enabled = true;
                    btnDebitOps.Enabled = true;
                    break;

                case 2: // human resources
                    btnDepartmentOps.Enabled = true;
                    btnUserOps.Enabled = true;
                    break;

                case 3: // accounting
                    btnCategoryOps.Enabled = true;
                    btnSupplierOps.Enabled = true;
                    btnDebitOps.Enabled = true;
                    break;

                case 4: // sales
                    btnCategoryOps.Enabled = true;
                    btnSupplierOps.Enabled = true;
                    btnFixtureOps.Enabled = true;
                    break;

                default:
                    break;
            }
        }
    }
}
