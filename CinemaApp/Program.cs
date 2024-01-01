using CinemaApp._Repositories;
using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Presenters;
using CinemaApp.Views;

namespace CinemaApp
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
            //Application.Run(new Form1());
            ILoginView loginView = new LoginView();
            IUserRepository userRepository = new UserRepository(new CinemaAppContext());
            new LoginPresenter(loginView, userRepository);

            Application.Run((Form)loginView);
        }
    }
}