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
    partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private readonly Settings _settings = new Settings();

        public Settings Settings { get { return _settings.Clone(); } }

        private void UpdateSettings(object sender, EventArgs e)
        {
            int workTimeMinutes = (int)_workTimeMinutes.Value;
            int workTimeSeconds = (int)_workTimeSeconds.Value;
            int breakTimeMinutes = (int)_breakTimeMinutes.Value;
            int breakTimeSeconds = (int)_breakTimeSeconds.Value;

            _settings.WorkTime = new TimeSpan(hours: 0, minutes: workTimeMinutes, seconds: workTimeSeconds);
            _settings.BreakTime = new TimeSpan(hours: 0, minutes: breakTimeMinutes, seconds: breakTimeSeconds);
        }
        
        private void OkButtonClick(object sender, EventArgs e)
        {
            bool workTimeToShort = (_settings.WorkTime.CompareTo(TimeSpan.FromSeconds(10)) < 0);
            bool breakTimeToShort = (_settings.BreakTime.CompareTo(TimeSpan.FromSeconds(10)) < 0);

            if (workTimeToShort)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("You really need to work at least 10 seconds!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (breakTimeToShort)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Your break should at least be 10 seconds long!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
