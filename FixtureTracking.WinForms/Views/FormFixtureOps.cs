using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormFixtureOps : Form
    {
        public FormFixtureOps()
        {
            InitializeComponent();
        }

        private async void FormFixtureOps_Load(object sender, EventArgs e)
        {
            await LoadFixture();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadFixture();
        }


        private void ClearInputs()
        {
            txtName.ResetText();
            txtDescription.ResetText();
            txtPrice.ResetText();
            dtpPurchase.ResetText();
            dtpWarranty.ResetText();
            cmbSupplier.ResetText();
            cmbCategory.ResetText();
        }

        private void HideUpdateButton()
        {
            btnUpdate.Hide();
            btnAdd.Show();
        }

        private async Task LoadFixture()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();
            ClearInputs();
            HideUpdateButton();

            var fixtures = await FixtureService.GetList();
            fixtures.ForEach(fixture =>
            {
                dgvObjectList.Rows.Add(fixture.Id, fixture.Name, fixture.Description, fixture.DateWarranty.ToShortDateString(), fixture.Price, fixture.UpdatedAt, "Update", "Delete");
            });

            dgvObjectList.Sort(dgvObjectList.Columns["clmUpdatedAt"], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
