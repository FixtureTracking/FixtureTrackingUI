using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.CustomExceptions;
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
            try
            {
                var user = await UserService.GetDetail(FormAccessToken.UserId);
                FormAccessToken.CurrentUser = user;

                lblUserDepartment.Text = $"{FormAccessToken.CurrentUser.FullName} - {FormAccessToken.CurrentUser.DepartmentName}";
                tlpUserDep.Visible = true;
            }
            catch (HttpFailureException ex)
            {
                MessageBox.Show(ex.Message, ex.HttpStatusCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task LoadMyDebits()
        {
            try
            {
                var debits = await UserService.GetDebits(FormAccessToken.UserId);
                foreach (var debit in debits)
                {
                    dgvMyDebits.Rows.Add(debit.FixtureName, debit.Debit.Description, debit.Debit.DateDebit, debit.Debit.IsReturn);
                }
                tlpMyDebitsTitle.Visible = true;
                tlpMyDebits.Visible = true;
            }
            catch (HttpFailureException ex)
            {
                MessageBox.Show(ex.Message, ex.HttpStatusCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
