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
        static void Main(params string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var text = args.GetOrDefault(0, Clipboard.GetText);

            Application.Run(new MainForm(text));
        }

        private static string GetOrDefault(this string[] args, int index, Func<string> defaultValue)
        {
            return index < args.Length
                ? args[index]
                : defaultValue();
        }
    }
}
