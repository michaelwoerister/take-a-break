using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace take_a_break
{
    class Coordinator
    {
        private readonly Settings _settings;
        private readonly Object _lock = new Object();
        private bool _running;

        private Coordinator(Settings settings)
        {
            _settings = settings;
        }

        private void Start()
        {
            _running = true;

            while (_running)
            {
                Thread.Sleep(_settings.WorkTime);
                StartBlackout(_settings.BreakTime);
                Console.WriteLine("restart");
            }
        }

        private void StartBlackout(TimeSpan breakTime)
        {
            var appCtx = new ApplicationContext();

            var screens = PickScreens();

            foreach (var screen in screens)
            {
                var blackoutform = new BlackOutForm(screen.Key, screen.Value);
                blackoutform.Show();
                
                if (screen.Key.Primary)
                    appCtx.MainForm = blackoutform;
            }
            
            Application.Run(appCtx);
        }

        private static Dictionary<Screen, Point> PickScreens()
        {
            var screens = new Dictionary<Screen, Point>();

            for (int y = 0; y < Screen.PrimaryScreen.Bounds.Height; y += 20)
            {
                var pointLeft = new Point(Screen.PrimaryScreen.Bounds.Left - 120, y);
                var screenLeft = Screen.FromPoint(pointLeft);
                if (!screens.ContainsKey(screenLeft))
                    screens.Add(screenLeft, pointLeft);

                var pointRight = new Point(Screen.PrimaryScreen.Bounds.Right + 120, y);
                var screenRight = Screen.FromPoint(pointRight);
                if (!screens.ContainsKey(screenRight))
                    screens.Add(screenRight, pointRight);
            }

            return screens;
        }

        #region Static Interface
        private static Coordinator s_instance;
        private static Thread s_thread;
        
        public static void Start(Settings settings)
        {
            s_instance = new Coordinator(settings);
            s_thread = new Thread(s_instance.Start);
            s_thread.Start();

        }
        #endregion
    }
}
