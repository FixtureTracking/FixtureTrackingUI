﻿using FixtureTracking.Entities.Dtos.Debit;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormDebitOps : Form
    {
        private Guid _selectedFixtureId;
        private Guid _selectedUserId;
        public FormDebitOps()
        {
            InitializeComponent();
        }

        private async void FormDebitOps_Load(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private void btnSlcFixture_Click(object sender, EventArgs e)
        {
            FormSelectFixture formSelectFixture = new FormSelectFixture();
            formSelectFixture.ShowDialog();
            _selectedFixtureId = formSelectFixture.SelectedFixtureId;
            if (_selectedFixtureId != Guid.Empty)
            {
                btnSlcFixture.Enabled = false;
                btnSlcFixture.Text = "Fixture selected";
            }
        }

        private void btnSlcUser_Click(object sender, EventArgs e)
        {
            FormSelectUser formSelectUser = new FormSelectUser();
            formSelectUser.ShowDialog();
            _selectedUserId = formSelectUser.SelectedUserId;
            if (_selectedUserId != Guid.Empty)
            {
                btnSlcUser.Enabled = false;
                btnSlcUser.Text = "User selected";
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddFixture();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvObjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtDescription.ResetText();
            dtpDebit.ResetText();
            btnSlcFixture.Enabled = true;
            btnSlcUser.Enabled = true;
            btnSlcFixture.Text = "Select Fixture";
            btnSlcUser.Text = "Select User";
            _selectedFixtureId = Guid.Empty;
            _selectedUserId = Guid.Empty;
        }

        private async Task LoadDebitList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();
            ClearInputs();

            var debits = await DebitService.GetList();
            debits.ForEach(debitDto =>
            {
                string dateReturn = debitDto.Debit.IsReturn ? debitDto.Debit.DateReturn.ToString() : "-";
                dgvObjectList.Rows.Add(debitDto.Debit.Id, debitDto.Debit.Description, debitDto.FixtureName, debitDto.UserFullName, debitDto.DepartmentName, debitDto.Debit.DateDebit, debitDto.Debit.IsReturn, dateReturn, "Delete");
            });
        }

        private async Task AddFixture()
        {
            DebitForAddDto debitForAddDto = new DebitForAddDto()
            {
                DateDebit = dtpDebit.Value,
                Description = txtDescription.Text,
                FixtureId = _selectedFixtureId,
                UserId = _selectedUserId
            };

            await DebitService.Add(debitForAddDto);
            MessageBox.Show("Debit added");
            await LoadDebitList();
        }
    }
}
