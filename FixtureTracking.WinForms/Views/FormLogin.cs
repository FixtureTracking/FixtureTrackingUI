using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Security;
using System;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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

            await AuthService.Login(userForLoginDto);
            FormJwtDecoder.DecodeNameIdendifier();
            Hide();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
