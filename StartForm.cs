using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace take_a_break
{
    partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private bool _inWorkTimeCallback = false;
        private readonly Settings _settings = new Settings();

        public Settings Settings { get { return _settings.Clone(); } }

        private void UpdateSettings(object sender, EventArgs e)
        {
            if (_inWorkTimeCallback)
                return;

            _inWorkTimeCallback = true;

            int workTimeMinutes = (int)_workTimeMinutes.Value;
            int workTimeSeconds = (int)_workTimeSeconds.Value;
            int breakTimeMinutes = (int)_breakTimeMinutes.Value;
            int breakTimeSeconds = (int)_breakTimeSeconds.Value;

            workTimeMinutes += workTimeSeconds/60;
            workTimeSeconds %= 60;

            breakTimeMinutes += breakTimeSeconds / 60;
            breakTimeSeconds %= 60;

            if (_workTimeMinutes.Value != workTimeMinutes)
                _workTimeMinutes.Value = workTimeMinutes;

            if (_workTimeSeconds.Value != workTimeSeconds)
                _workTimeSeconds.Value = workTimeSeconds;

            if (_breakTimeMinutes.Value != breakTimeMinutes)
                _breakTimeMinutes.Value = breakTimeMinutes;

            if (_breakTimeSeconds.Value != breakTimeSeconds)
                _breakTimeSeconds.Value = breakTimeSeconds;

            _inWorkTimeCallback = false;
        }

    }
}
