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

            var dialogResult = DialogResult.None;
            Settings settings = null;

            using (var startForm = new StartForm())
            {
                dialogResult = startForm.ShowDialog();
                settings = startForm.Settings;
            }

            if (dialogResult == DialogResult.OK)
            {
                Coordinator.Start(settings);
            }
        } 
    }
}
