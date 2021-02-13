using FixtureTracking.Entities.Dtos.Category;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Constants;
using FixtureTracking.WinForms.Utilities.FormTools;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormCategoryOps : Form
    {
        private short _selectedCategoryId;
        public FormCategoryOps()
        {
            InitializeComponent();
        }

        private async void FormCategoryOps_Load(object sender, EventArgs e)
        {
            await LoadCategoryList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadCategoryList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddCategory();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateCategory();
        }

        private void dgvObjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var categoryIdCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmCategoryId)];
            var categoryNameCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmName)];
            _selectedCategoryId = Convert.ToInt16(categoryIdCell.Value.ToString());

            switch (clickedCell.OwningColumn.Name)
            {
                case nameof(clmUpdate):
                    var categoryDescCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmDescription)];
                    txtName.Text = categoryNameCell.Value.ToString();
                    txtDescription.Text = categoryDescCell.Value.ToString();

                    btnAdd.Hide();
                    btnUpdate.Show();
                    break;

                case nameof(clmDelete):
                    ShowDeleteDiaolog(_selectedCategoryId, categoryNameCell.Value.ToString());
                    break;

                default:
                    break;
            }
        }

        private void ClearInputs()
        {
            txtName.ResetText();
            txtDescription.ResetText();
        }

        private void HideUpdateButton()
        {
            btnUpdate.Hide();
            btnAdd.Show();
        }

        private async void ShowDeleteDiaolog(short categoryId, string categoryName)
        {
            var dialogResult = DeleteDiaolog.Show("category", categoryName);
            if (dialogResult == DialogResult.Yes)
                await DeleteCategory(categoryId);
        }

        private async Task LoadCategoryList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();
            ClearInputs();
            HideUpdateButton();

            var categories = await CategoryService.GetList();
            categories.ForEach(category =>
            {
                dgvObjectList.Rows.Add(category.Id, category.Name, category.Description, category.UpdatedAt, "Update", "Delete");
            });
            dgvObjectList.Columns[nameof(clmUpdate)].DefaultCellStyle.Font = new System.Drawing.Font(dgvObjectList.DefaultCellStyle.Font, System.Drawing.FontStyle.Underline);
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmUpdatedAt)], System.ComponentModel.ListSortDirection.Descending);
        }

        private async Task AddCategory()
        {
            CategoryForAddDto categoryForAddDto = new CategoryForAddDto()
            {
                Description = txtDescription.Text,
                Name = txtName.Text
            };

            await CategoryService.Add(categoryForAddDto);
            MessageBox.Show(Messages.CategoryAdded);
            await LoadCategoryList();
        }

        private async Task UpdateCategory()
        {
            CategoryForUpdateDto categoryForUpdateDto = new CategoryForUpdateDto()
            {
                Id = _selectedCategoryId,
                Description = txtDescription.Text,
                Name = txtName.Text
            };

            await CategoryService.Update(categoryForUpdateDto);
            MessageBox.Show(Messages.CategoryUpdated);
            await LoadCategoryList();
        }

        private async Task DeleteCategory(short categoryId)
        {
            await CategoryService.Delete(categoryId);
            MessageBox.Show(Messages.CategoryDeleted);
            await LoadCategoryList();
        }
    }
}
