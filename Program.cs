using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace BurcVKIUygulamasi
{
    static class Program
    {
        // Uygulamanın başlangıç noktası
        [STAThread]
        static void Main()
        {
            // Gerekli bileşenleri başlat
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Formu başlat
            Application.Run(new Form1());
        }
    }
}
