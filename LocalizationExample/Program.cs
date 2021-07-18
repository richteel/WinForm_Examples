// REF: https://www.youtube.com/watch?v=D5cUhEXu8Jg
// REF: https://blogs.msmvps.com/peterritchie/2011/11/24/if-you-re-using-if-debug-you-re-doing-it-wrong/

using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace LocalizationExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TestLocalization(null);
            //TestLocalization("de-DE");
            //TestLocalization("es-ES");
            //TestLocalization("fr-FR");
            TestLocalization("lo-LA");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        [Conditional("DEBUG")]
        private static void TestLocalization(string localizationAbbr)
        {
            if (string.IsNullOrEmpty(localizationAbbr))
                return;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(localizationAbbr);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(localizationAbbr);
        }
    }
}
