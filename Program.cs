namespace Hotel
{
    internal static class Program
    {
        public static lessons_db db;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            db = new lessons_db();
            Application.Run(new FormMain());
        }
    }
}