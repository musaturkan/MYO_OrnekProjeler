namespace Lokanta
{
    public static class Program
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
            //LokantaBaslat yeniForm = new LokantaBaslat();
            //yeniForm.KurumAdi = "Bilecik Þeyh Edebali Üniversitesi";

            //Application.Run(yeniForm);
            Application.Run(new LokantaBaslat());
        }
    }
}