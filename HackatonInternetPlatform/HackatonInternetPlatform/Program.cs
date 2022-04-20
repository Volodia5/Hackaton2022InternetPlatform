using HackatonInternetPlatform.Model;
using HackatonInternetPlatform.Presenter;
using HackatonInternetPlatform.View;

namespace HackatonInternetPlatform
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
            RegistrationForm registrationForm = new RegistrationForm();
            TradingFloorData floorData = new TradingFloorData();
            SignUpPresenter presenter = new SignUpPresenter(floorData, registrationForm);
            Application.Run(new LoginForm());
        }
    }
}