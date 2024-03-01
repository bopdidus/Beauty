namespace Beauty
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
            var box = new BeautyMessageBox("Info", "Save done!", BeautyMessageType.Success, BeautyMessageButtons.OK, BeautyMessageIcon.TickMark);
            Application.Run(box);
        }
    }
}