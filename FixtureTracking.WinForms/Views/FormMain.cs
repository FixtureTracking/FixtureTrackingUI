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
            // TODO : debit ops form
            await LoadMyDebits();
        }

        private async Task LoadUserDetail()
        {
            var user = await UserService.GetById(FormCurrentUser.UserId);
            FormCurrentUser.SetUserValues(user);

            var department = await DepartmentService.GetById(FormCurrentUser.DepartmentId);
            FormCurrentUser.SetDepartmentValues(department);

            lblName.Text = FormCurrentUser.FullName;
            lblDepartment.Text = FormCurrentUser.DepartmentName;

            tlpOperationsSideBar.Visible = true;
        }

        private async Task LoadMyDebits()
        {
            dgvMyDebits.Rows.Clear();
            dgvMyDebits.Refresh();

            var debits = await UserService.GetDebits(FormCurrentUser.UserId);
            debits.ForEach(debitDto =>
            {
                dgvMyDebits.Rows.Add(debitDto.Debit.Id, debitDto.FixtureName, debitDto.Debit.Description, debitDto.Debit.DateDebit, debitDto.Debit.IsReturn);
            });
            tlpMyDebitsTitle.Visible = true;
            tlpMyDebits.Visible = true;
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
