namespace WinFormsApp7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       static public  List<string> words = new List<string>();
        static public List<string> meanings = new List<string>();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}