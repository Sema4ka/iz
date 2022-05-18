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
            for(int i=2; i<68; i += 2)
            {
                raz.Items.Add(i);
            }
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


        private void arialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Green;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font("Arial", textBox.Font.Size);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font("Impact", textBox.Font.Size);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font("Comic Sans MS", textBox.Font.Size);
        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Red;
        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Black;
        }

        private void raz_Click(object sender, EventArgs e)
        {
            ComboBox inf = sender as ComboBox;
            textBox.Font = new Font(Convert.ToString(textBox.Font.FontFamily), Convert.ToUInt32(inf.Text));
        }

        private void raz_TextUpdate(object sender, EventArgs e)
        {
            textBox.Font = new Font(Convert.ToString(textBox.Font.FontFamily), Convert.ToUInt32((sender as ToolStripComboBox).Text));
        }
    }
}
