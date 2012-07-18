using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace take_a_break
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var startForm = new StartForm())
            {
                if (startForm.ShowDialog() == DialogResult.OK)
                {
                    Start(startForm.Settings);
                }
            }
        }

        static void Start(Settings settings)
        {
            Console.WriteLine(settings.WorkTime);
            Console.WriteLine(settings.BreakTime);
        }
    }
}
