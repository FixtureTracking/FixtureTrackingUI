using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Windows.Forms;

namespace FixtureTracking.WinForms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            try
            {
                await AuthService.Login(userForLoginDto);
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await CategoryService.GetList();
                MessageBox.Show(result.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await SupplierService.GetList();
                MessageBox.Show(result.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await DepartmentService.GetList();
                MessageBox.Show(result.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnFixture_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await FixtureService.GetList();
                MessageBox.Show(result.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await UserService.GetList();
                MessageBox.Show(result.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
