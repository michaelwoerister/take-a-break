using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace take_a_break
{
    partial class CoordinatorForm : Form
    {
        public CoordinatorForm()
        {
            InitializeComponent();
        }

        public CoordinatorForm(Settings settings)
        {
            InitializeComponent();

            _workTime = settings.WorkTime;
            _breakTime = settings.BreakTime;
            _workPeriodStart = DateTime.Now;
        }
        
        public void UpdateSettings(Settings settings)
        {
            _workTime = settings.WorkTime;
            _breakTime = settings.BreakTime;
        }

        private TimeSpan _workTime;
        private TimeSpan _breakTime;
        private DateTime _workPeriodStart;
        private readonly List<BlackOutForm> _activeBlackOutForms = new List<BlackOutForm>(); 

        private bool CurrentlyWorking { get { return _workTimer.Enabled; } }

        private void WorkTimerTick(object sender, EventArgs e)
        {
            if ( DateTime.Now > _workPeriodStart + _workTime )
            {
                var screenInfo = PickScreens();

                foreach ( var entry in screenInfo )
                {
                    var blackoutform = new BlackOutForm(entry.Value, _breakTime);
                    
                    _activeBlackOutForms.Add(blackoutform);
                    blackoutform.FormClosed += BlackoutformOnFormClosed;
                    
                    blackoutform.Show();
                }

                _workTimer.Enabled = false;
            }
        }

        private void BlackoutformOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            Debug.Assert(sender is BlackOutForm);
            Debug.Assert(_activeBlackOutForms.Contains(sender as BlackOutForm));

            _activeBlackOutForms.Remove(sender as BlackOutForm);

            if (_activeBlackOutForms.Count == 0)
            {
                _workPeriodStart = DateTime.Now;
                _workTimer.Enabled = true;
            }
        }

        private static Dictionary<Screen, Point> PickScreens()
        {
            var screens = new Dictionary<Screen, Point>();

            var primaryScreenPoint = Screen.PrimaryScreen.WorkingArea.Location;
            primaryScreenPoint.Offset(10, 10);
            screens[Screen.PrimaryScreen] = primaryScreenPoint;

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
    }
}
