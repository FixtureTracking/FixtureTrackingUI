using FixtureTracking.Entities.Dtos.Fixture;
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
            await LoadFixtureList();
            await LoadSupplierComboBox();
            await LoadCategoryComboBox();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadFixtureList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddFixture();
        }

        private void ClearInputs()
        {
            txtName.ResetText();
            txtDescription.ResetText();
            txtPrice.Text = "0.00";
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

        private async Task LoadFixtureList()
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
        private async Task LoadSupplierComboBox()
        {
            var suppliers = await SupplierService.GetList();

            cmbSupplier.DisplayMember = "Display";
            cmbSupplier.ValueMember = "Value";

            suppliers.ForEach(supplier =>
            {
                cmbSupplier.Items.Add(new { Display = supplier.Name, Value = supplier.Id });
            });

            cmbSupplier.SelectedItem = cmbSupplier.Items[0];
        }

        private async Task LoadCategoryComboBox()
        {
            var categories = await CategoryService.GetList();

            cmbCategory.DisplayMember = "Display";
            cmbCategory.ValueMember = "Value";

            categories.ForEach(category =>
            {
                cmbCategory.Items.Add(new { Display = category.Name, Value = category.Id });
            });

            cmbCategory.SelectedItem = cmbCategory.Items[0];
        }

        private async Task AddFixture()
        {
            FixtureForAddDto fixtureForAddDto = new FixtureForAddDto()
            {
                CategoryId = (cmbCategory.SelectedItem as dynamic).Value,
                DatePurchase = dtpPurchase.Value.Date,
                DateWarranty = dtpWarranty.Value.Date,
                Description = txtDescription.Text,
                Name = txtName.Text,
                PictureUrl = "pic.lk", // TODO : picture link
                Price = Convert.ToDecimal(txtPrice.Text),
                SupplierId = (cmbSupplier.SelectedItem as dynamic).Value
            };

            await FixtureService.Add(fixtureForAddDto);
            MessageBox.Show("Fixture added.");
            await LoadFixtureList();
        }


    }
}
