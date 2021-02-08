using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormUserDetail : Form
    {
        private readonly UserForDetailDto userForDetail;
        public FormUserDetail(UserForDetailDto userForDetailDto)
        {
            InitializeComponent();
            userForDetail = userForDetailDto;
        }

        private async void FormUserDetail_Load(object sender, EventArgs e)
        {
            lblBirthdate.Text = userForDetail.BirthDate.ToShortDateString();
            lblDepartment.Text = userForDetail.DepartmentName;
            lblEmail.Text = userForDetail.Email;
            lblFullName.Text = $"{userForDetail.FirstName} {userForDetail.LastName}";
            lblUsername.Text = userForDetail.Username;
            await LoadDebits();
        }

        private async Task LoadDebits()
        {
            var debits = await UserService.GetDebits(userForDetail.Id);
            debits.ForEach(debitDto =>
            {
                cmbDebits.Items.Add(debitDto.FixtureName);
            });
        }
    }
}
