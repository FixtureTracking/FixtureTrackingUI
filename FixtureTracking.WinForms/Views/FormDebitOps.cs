using FixtureTracking.Entities.Dtos.Debit;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Constants;
using FixtureTracking.WinForms.Utilities.FormTools;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormDebitOps : Form
    {
        private Guid _selectedDebitId;
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

        private void btnSelectFixture_Click(object sender, EventArgs e)
        {
            FormSelectFixture formSelectFixture = new FormSelectFixture();
            formSelectFixture.ShowDialog();

            if (formSelectFixture.SelectedFixtureId != Guid.Empty)
            {
                _selectedFixtureId = formSelectFixture.SelectedFixtureId;
                btnSelectFixture.Enabled = false;
                btnSelectFixture.Text = "Fixture selected";
            }
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            FormSelectUser formSelectUser = new FormSelectUser();
            formSelectUser.ShowDialog();

            if (formSelectUser.SelectedUserId != Guid.Empty)
            {
                _selectedUserId = formSelectUser.SelectedUserId;
                btnSelectUser.Enabled = false;
                btnSelectUser.Text = "User selected";
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddDebit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvObjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var debitIdCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmDebitId)];
            _selectedDebitId = Guid.Parse(debitIdCell.Value.ToString());

            switch (clickedCell.OwningColumn.Name)
            {
                case nameof(clmDelete):
                    var fixtureCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmFixture)];
                    var userCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmUser)];

                    ShowDeleteDiaolog(_selectedDebitId, fixtureCell.Value.ToString(), userCell.Value.ToString());
                    break;

                default:
                    break;
            }
        }

        private void ClearInputs()
        {
            txtDescription.ResetText();
            dtpDateDebit.ResetText();
            btnSelectFixture.Enabled = true;
            btnSelectUser.Enabled = true;
            btnSelectFixture.Text = "Select Fixture";
            btnSelectUser.Text = "Select User";
            _selectedFixtureId = Guid.Empty;
            _selectedUserId = Guid.Empty;
        }

        private async void ShowDeleteDiaolog(Guid debitId, string fixture, string user)
        {
            var dialogResult = DeleteDiaolog.Show("debit", $"{fixture} - {user}");
            if (dialogResult == DialogResult.Yes)
                await DeleteDebit(debitId);
        }

        private async Task LoadDebitList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();
            ClearInputs();

            var debits = await DebitService.GetList();
            debits.ForEach(debitDto =>
            {
                string dateReturn = debitDto.Debit.IsReturn ? debitDto.Debit.DateReturn.ToShortDateString() : "-";
                dgvObjectList.Rows.Add(debitDto.Debit.Id, debitDto.Debit.Description, debitDto.FixtureName, debitDto.UserFullName, debitDto.DepartmentName, debitDto.Debit.DateDebit.Date, debitDto.Debit.IsReturn, dateReturn, debitDto.Debit.UpdatedAt, "Delete");
            });
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmUpdatedAt)], System.ComponentModel.ListSortDirection.Descending);
        }

        private async Task AddDebit()
        {
            DebitForAddDto debitForAddDto = new DebitForAddDto()
            {
                DateDebit = dtpDateDebit.Value.Date,
                Description = txtDescription.Text,
                FixtureId = _selectedFixtureId,
                UserId = _selectedUserId
            };

            await DebitService.Add(debitForAddDto);
            MessageBox.Show(Messages.DebitAdded);
            await LoadDebitList();
        }

        private async Task DeleteDebit(Guid debitId)
        {
            await DebitService.Delete(debitId);
            MessageBox.Show(Messages.DebitDeleted);
            await LoadDebitList();
        }
    }
}
