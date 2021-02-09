using FixtureTracking.Entities.Dtos.Category;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormCategoryOps : Form
    {
        private short selectedCategoryId;
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
            var categoryIdCell = dgvObjectList.Rows[e.RowIndex].Cells["clmCategoryId"];
            short categoryId = Convert.ToInt16(categoryIdCell.Value.ToString());
            selectedCategoryId = categoryId;
            switch (clickedCell.OwningColumn.HeaderCell.Value)
            {
                case "Update":
                    btnAdd.Hide();
                    btnUpdate.Show();

                    var categoryNameCell = dgvObjectList.Rows[e.RowIndex].Cells["clmName"];
                    var categoryDescCell = dgvObjectList.Rows[e.RowIndex].Cells["clmDescription"];
                    txtDescription.Text = categoryDescCell.Value.ToString();
                    txtName.Text = categoryNameCell.Value.ToString();
                    break;

                //case "Delete":
                //    var firstNameCell = dgvUserList.Rows[e.RowIndex].Cells["clmFirstName"];
                //    var lastNameCell = dgvUserList.Rows[e.RowIndex].Cells["clmLastName"];
                //    var usernameCell = dgvUserList.Rows[e.RowIndex].Cells["clmUsername"];

                //    var fullName = $"{firstNameCell.Value} {lastNameCell.Value}";
                //    var username = usernameCell.Value.ToString();

                //    ShowDeleteDiaolog(categoryId, fullName, username);
                //    break;

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

            dgvObjectList.Sort(dgvObjectList.Columns["clmUpdatedAt"], System.ComponentModel.ListSortDirection.Descending);
        }

        private async Task AddCategory()
        {
            CategoryForAddDto categoryForAddDto = new CategoryForAddDto()
            {
                Description = txtDescription.Text,
                Name = txtName.Text
            };

            await CategoryService.Add(categoryForAddDto);
            MessageBox.Show("Category added.");

            ClearInputs();
            await LoadCategoryList();
        }

        private async Task UpdateCategory()
        {
            CategoryForUpdateDto categoryForUpdateDto = new CategoryForUpdateDto()
            {
                Id = selectedCategoryId,
                Description = txtDescription.Text,
                Name = txtName.Text
            };

            await CategoryService.Update(categoryForUpdateDto);
            MessageBox.Show("Category updated.");

            ClearInputs();
            HideUpdateButton();
            await LoadCategoryList();
        }
    }
}
