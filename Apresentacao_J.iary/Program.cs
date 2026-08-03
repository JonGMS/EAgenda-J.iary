using Aplicacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloLogin;
using Apresentacao_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloUsuario;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao_J.iary
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            var serviceLocator = new ServiceLocatorManual();

            if (serviceLocator.ExecutarLogin())
            {
                var form = new Form
                {
                    WindowState = FormWindowState.Maximized,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                var ucTelaInicial = new UCTelaInicial(serviceLocator)
                    {
                        Dock = DockStyle.Fill
                    };

                serviceLocator.RegistrarTelaInicial(ucTelaInicial);

                form.Controls.Add(ucTelaInicial);

                Application.Run(form);
            }

        }
    }
}