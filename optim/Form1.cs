using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optim
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            long _selected = calendar.Value.Ticks;
            long _current = DateTime.Now.Ticks;
            TimeSpan selected = TimeSpan.FromTicks(_selected);
            TimeSpan current = TimeSpan.FromTicks(_current);

            int _sec = Convert.ToInt32(selected.TotalSeconds - current.TotalSeconds);

            int _weeks = _sec / 24 / 60 / 60 / 7;
            int _days = _sec / 24 / 60 / 60;
            int _hours = _sec / 60 / 60;
            int _minutes = _sec / 60;
            int _seconds = _sec;

            weeks.Text = _weeks.ToString();
            days.Text = _days.ToString();
            hours.Text = _hours.ToString();
            mins.Text = _minutes.ToString();
            seconds.Text = _seconds.ToString();

        }
    }
}
