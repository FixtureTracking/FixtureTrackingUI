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
            EditSidebarSections();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            dgvMyDebits.Rows.Clear();
            dgvMyDebits.Refresh();
            await LoadMyDebits();
        }

        private void btnCategoryOps_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplierOps_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void btnFixtureOps_Click(object sender, EventArgs e)
        {

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

        private void btnDebitOps_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadUserDetail()
        {
            var user = await UserService.GetDetail(FormAccessToken.UserId);
            FormAccessToken.CurrentUser = user;

            lblName.Text = FormAccessToken.CurrentUser.FullName;
            lblDepartment.Text = FormAccessToken.CurrentUser.DepartmentName;

            tlpOperationsSideBar.Visible = true;
        }

        private async Task LoadMyDebits()
        {
            var debits = await UserService.GetDebits(FormAccessToken.UserId);
            debits.ForEach(debitDto =>
            {
                dgvMyDebits.Rows.Add(debitDto.Debit.Id, debitDto.FixtureName, debitDto.Debit.Description, debitDto.Debit.DateDebit, debitDto.Debit.IsReturn);
            });
            tlpMyDebitsTitle.Visible = true;
            tlpMyDebits.Visible = true;
        }

        private void EditSidebarSections()
        {
            var departmentId = FormAccessToken.CurrentUser.DepartmentId;

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
