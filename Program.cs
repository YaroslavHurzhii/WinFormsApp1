using MauiApp1;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DBContext.InitializeDatabase();
            Application.Run(new Form1());
        }
    }
}