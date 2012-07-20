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
    public partial class BlackOutForm : Form
    {
        private Point _seedPosition;
        private TimeSpan _timeSpan;
        private DateTime? _startTime;

        public BlackOutForm()
        {
            InitializeComponent();
        }

        public BlackOutForm(Point seedPosition, TimeSpan time)
        {
            _seedPosition = seedPosition;
            _timeSpan = time;
            
            InitializeComponent();
            
            this.Opacity = 0;
            
        }

        private void BlackOutFormClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void Update(object sender, EventArgs e)
        {
            if (!_startTime.HasValue)
            {
                this.Size = new Size(10, 10);
                this.DesktopLocation = _seedPosition;
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
                
                _startTime = DateTime.Now;
            }

            var elapsedTime = (DateTime.Now - _startTime.Value);
            var fadeTime = TimeSpan.FromSeconds(0.3);

            if (elapsedTime < fadeTime)
            {
                this.Opacity = elapsedTime.TotalSeconds / fadeTime.TotalSeconds;
            }
            else if (DateTime.Now > (_startTime.Value + (_timeSpan - fadeTime)))
            {
                this.Opacity = ((_startTime.Value + _timeSpan) - DateTime.Now).TotalSeconds / fadeTime.TotalSeconds;
            }
            else if (this.Opacity != 1)
            {
                this.Opacity = 1;
            }

            if (DateTime.Now > _startTime.Value + _timeSpan)
                this.Close();
        }
    }
}
