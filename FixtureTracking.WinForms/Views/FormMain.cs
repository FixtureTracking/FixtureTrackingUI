using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
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
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            dgvMyDebits.Rows.Clear();
            dgvMyDebits.Refresh();
            await LoadMyDebits();
        }

        private async Task LoadUserDetail()
        {
            var user = await UserService.GetDetail(FormAccessToken.UserId);
            FormAccessToken.CurrentUser = user;

            lblName.Text = FormAccessToken.CurrentUser.FullName;
            lblDepartment.Text = FormAccessToken.CurrentUser.DepartmentName;

            tlpLeftSide.Visible = true;
        }

        private async Task LoadMyDebits()
        {
            var debits = await UserService.GetDebits(FormAccessToken.UserId);
            debits.ForEach(debitDto =>
            {
                dgvMyDebits.Rows.Add(debitDto.FixtureName, debitDto.Debit.Description, debitDto.Debit.DateDebit, debitDto.Debit.IsReturn);
            });
            tlpMyDebitsTitle.Visible = true;
            tlpMyDebits.Visible = true;
        }
    }
}
