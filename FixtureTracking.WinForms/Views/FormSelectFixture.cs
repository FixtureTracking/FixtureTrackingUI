using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormSelectFixture : Form
    {
        public Guid SelectedFixtureId { get; set; }
        public FormSelectFixture()
        {
            InitializeComponent();
            SelectedFixtureId = new Guid();
        }

        private async void FormSelectFixture_Load(object sender, EventArgs e)
        {
            await LoadFixtureList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadFixtureList();
        }

        private void dgvObjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (clickedCell.OwningColumn.Name == nameof(clmSelect))
            {
                var fixtureIdCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmFixtureId)];
                SelectedFixtureId = Guid.Parse(fixtureIdCell.Value.ToString());
                this.Close();
            }
        }

        private async Task LoadFixtureList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var fixtures = await FixtureService.GetAvailableList();
            fixtures.ForEach(fixtureDto =>
            {
                dgvObjectList.Rows.Add(fixtureDto.Id, fixtureDto.Name, fixtureDto.Description, fixtureDto.DateWarranty.ToShortDateString(), fixtureDto.UpdatedAt, "Select");
            });
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmName)], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
