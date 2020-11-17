using System;
using System.Windows.Forms;

namespace RegexEscaper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var text = Clipboard.GetText();
            
            Application.Run(new MainForm(text));
        }
    }
}
