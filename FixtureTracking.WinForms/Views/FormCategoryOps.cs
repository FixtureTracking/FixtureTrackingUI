﻿using FixtureTracking.Entities.Dtos.Category;
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
            var categoryNameCell = dgvObjectList.Rows[e.RowIndex].Cells["clmName"];

            selectedCategoryId = Convert.ToInt16(categoryIdCell.Value.ToString());

            switch (clickedCell.OwningColumn.HeaderCell.Value)
            {
                case "Update":
                    var categoryDescCell = dgvObjectList.Rows[e.RowIndex].Cells["clmDescription"];
                    txtDescription.Text = categoryDescCell.Value.ToString();
                    txtName.Text = categoryNameCell.Value.ToString();

                    btnAdd.Hide();
                    btnUpdate.Show();
                    break;

                case "Delete":
                    string categoryName = categoryNameCell.Value.ToString();
                    ShowDeleteDiaolog(selectedCategoryId, categoryName);
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
            var confirmResult = MessageBox.Show($"Are you sure to delete this category?\r\n({categoryName})", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
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
            await LoadCategoryList();
        }

        private async Task DeleteCategory(short categoryId)
        {
            await CategoryService.Delete(categoryId);
            MessageBox.Show("Category deleted.");
            await LoadCategoryList();
        }
    }
}
