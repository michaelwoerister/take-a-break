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
        private Point? _seedPosition;

        public BlackOutForm()
        {
            InitializeComponent();
        }

        public BlackOutForm(Screen screen, Point seedPosition)
        {   
            InitializeComponent();
            _seedPosition = seedPosition;

            this.Opacity = 0;
        }

        private void BlackOutFormClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void Update(object sender, EventArgs e)
        {
            if (_seedPosition.HasValue)
            {
                this.Size = new Size(10, 10);
                this.DesktopLocation = _seedPosition.Value;
                this.WindowState = FormWindowState.Maximized;
                _seedPosition = null;
            }

            if (this.Opacity < 1)
                this.Opacity += 0.1;
            else
            {
                _updateTimer.Enabled = false;
                this.Opacity = 1;
            }
        }
    }
}
