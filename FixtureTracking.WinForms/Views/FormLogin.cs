using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utils.CustomExceptions;
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

            try
            {
                await AuthService.Login(userForLoginDto);
                Hide();
            }
            catch (HttpFailureException ex)
            {
                MessageBox.Show(ex.Message, ex.HttpStatusCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
