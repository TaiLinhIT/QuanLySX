﻿
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySX
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
            // Khởi tạo Startup và đọc cấu hình
            var startup = new StartUp();
            startup.Run();
        }
    }
}