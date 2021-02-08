using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormCategoryOps : Form
    {
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

        private async Task LoadCategoryList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var categories = await CategoryService.GetList();

            categories.ForEach(category =>
            {
                dgvObjectList.Rows.Add(category.Id, category.Name, category.Description, category.UpdatedAt, "Update", "Delete");
            });

            dgvObjectList.Sort(dgvObjectList.Columns["clmUpdatedAt"], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
