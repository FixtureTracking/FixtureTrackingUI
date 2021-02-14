using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Fixture;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Constants;
using FixtureTracking.WinForms.Utilities.FormTools;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormFixtureOps : Form
    {
        private Guid _selectedFixtureId;
        private List<Supplier> _suppliers;
        private List<Category> _categories;
        public FormFixtureOps()
        {
            InitializeComponent();
        }

        private async void FormFixtureOps_Load(object sender, EventArgs e)
        {
            await LoadSupplierComboBox();
            await LoadCategoryComboBox();
            await LoadFixtureList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadFixtureList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddFixture();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateFixture();
        }

        private void dgvObjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var fixtureIdCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmFixtureId)];
            _selectedFixtureId = Guid.Parse(fixtureIdCell.Value.ToString());

            switch (clickedCell.OwningColumn.Name)
            {
                case nameof(clmUpdate):
                    FillInputValues();

                    btnAdd.Hide();
                    btnUpdate.Show();
                    break;

                case nameof(clmDelete):
                    var nameCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmName)];
                    var categoryCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmCategory)];

                    ShowDeleteDiaolog(_selectedFixtureId, nameCell.Value.ToString(), categoryCell.Value.ToString());
                    break;

                default:
                    break;
            }
        }

        private async void ShowDeleteDiaolog(Guid fixtureId, string fixtureName, string fixtureCategory)
        {
            var dialogResult = DeleteDiaolog.Show("fixture", $"{fixtureName} - {fixtureCategory}");
            if (dialogResult == DialogResult.Yes)
                await DeleteFixture(fixtureId);
        }

        private async void FillInputValues()
        {
            var fixture = await FixtureService.GetById(_selectedFixtureId);

            txtName.Text = fixture.Name;
            txtDescription.Text = fixture.Description;
            txtPrice.Text = fixture.Price.ToString();
            dtpPurchase.Value = fixture.DatePurchase.Date;
            dtpWarranty.Value = fixture.DateWarranty.Date;

            var selectedSupplier = _suppliers.Find(s => s.Id == fixture.SupplierId);
            var selectedCategory = _categories.Find(c => c.Id == fixture.CategoryId);

            cmbSupplier.SelectedItem = new { Display = selectedSupplier.Name, Value = selectedSupplier.Id };
            cmbCategory.SelectedItem = new { Display = selectedCategory.Name, Value = selectedCategory.Id };
        }

        private void ClearInputs()
        {
            txtName.ResetText();
            txtDescription.ResetText();
            txtPrice.Text = "0.00";
            dtpPurchase.ResetText();
            dtpWarranty.ResetText();
            cmbSupplier.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
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
            fixtures.ForEach(fixtureDto =>
            {
                var availableStatus = fixtureDto.Fixture.FixturePositionId == 1;
                dgvObjectList.Rows.Add(fixtureDto.Fixture.Id, fixtureDto.Fixture.Name, fixtureDto.Fixture.Description, fixtureDto.Fixture.DateWarranty.Date, fixtureDto.Fixture.Price, fixtureDto.CategoryName, fixtureDto.SupplierName, availableStatus, fixtureDto.FixturePosName, fixtureDto.Fixture.UpdatedAt, "Update", "Delete");
            });
            dgvObjectList.Columns[nameof(clmUpdate)].DefaultCellStyle.Font = new System.Drawing.Font(dgvObjectList.DefaultCellStyle.Font, System.Drawing.FontStyle.Underline);
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmUpdatedAt)], System.ComponentModel.ListSortDirection.Descending);
        }

        private async Task LoadSupplierComboBox()
        {
            var suppliers = await SupplierService.GetList();
            _suppliers = suppliers;

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
            _categories = categories;

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
            MessageBox.Show(Messages.FixtureAdded);
            await LoadFixtureList();
        }

        private async Task UpdateFixture()
        {
            FixtureForUpdateDto fixtureForUpdateDto = new FixtureForUpdateDto()
            {
                Id = _selectedFixtureId,
                CategoryId = (cmbCategory.SelectedItem as dynamic).Value,
                DatePurchase = dtpPurchase.Value.Date,
                DateWarranty = dtpWarranty.Value.Date,
                Description = txtDescription.Text,
                Name = txtName.Text,
                PictureUrl = "pic.lk", // TODO : picture link
                Price = Convert.ToDecimal(txtPrice.Text),
                SupplierId = (cmbSupplier.SelectedItem as dynamic).Value
            };

            await FixtureService.Update(fixtureForUpdateDto);
            MessageBox.Show(Messages.FixtureUpdated);
            await LoadFixtureList();
        }

        private async Task DeleteFixture(Guid fixtureId)
        {
            await FixtureService.Delete(fixtureId);
            MessageBox.Show(Messages.FixtureDeleted);
            await LoadFixtureList();
        }
    }
}
