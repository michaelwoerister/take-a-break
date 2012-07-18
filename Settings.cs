using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace take_a_break
{
    class Settings
    {
        public TimeSpan WorkTime = TimeSpan.FromMinutes(10);
        public TimeSpan BreakTime = TimeSpan.FromSeconds(10);

        public Settings Clone()
        {
            return new Settings
            {
                WorkTime = this.WorkTime,
                BreakTime = this.BreakTime,
            };
        }
    }
}
