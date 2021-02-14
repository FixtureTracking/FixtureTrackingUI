using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormDebitsOfUser : Form
    {
        private Guid _userId;
        public FormDebitsOfUser(Guid userId, string fullName, string departmentName)
        {
            _userId = userId;
            InitializeComponent();
            this.Text += $"{fullName} ({departmentName})";
        }

        private async void FormDebitsOfUser_Load(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private async Task LoadDebitList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var debits = await UserService.GetDebits(_userId);
            debits.ForEach(debitDto =>
            {
                string dateOfReturn = debitDto.Debit.IsReturn ? debitDto.Debit.DateReturn.ToShortDateString() : "-";
                dgvObjectList.Rows.Add(debitDto.Debit.Id, debitDto.FixtureName, debitDto.Debit.Description, debitDto.Debit.DateDebit.Date, debitDto.Debit.IsReturn, dateOfReturn);
            });
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmDateReturn)], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
