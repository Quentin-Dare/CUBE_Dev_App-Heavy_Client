using Gestion_stock.MainForm;

namespace Gestion_stock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialisation du projet
            if (InitializeProject())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Login());
            }
        }

        private static bool InitializeProject()
        {
            return Utils.CustomFont.LoadFonts();
        }
    }
}