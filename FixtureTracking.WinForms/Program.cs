using FixtureTracking.WinForms.Utilities.CustomExceptions;
using FixtureTracking.WinForms.Views;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FixtureTracking.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomainUnhandledException);
            Application.ThreadException += new ThreadExceptionEventHandler(ApplicationThreadException);

            Application.Run(new FormMain());
        }

        static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString(), "InternalServerError - CurrentDomainUnhandledExc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is HttpFailureException httpFailureException)
                MessageBox.Show(httpFailureException.Message, httpFailureException.HttpStatusCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
                MessageBox.Show(e.Exception.Message, "InternalServerError - ApplicationThreadExc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
