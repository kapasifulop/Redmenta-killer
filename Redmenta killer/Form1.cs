using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redmenta_killer
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
            randomise.Checked = true;
        }
        bool chk = true;

        private async void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false;
            button1.Enabled = false;
            timer_lbl.Text = "Timer: 3";
            await Task.Delay(1000);
            timer_lbl.Text = "Timer: 2";
            await Task.Delay(1000);
            timer_lbl.Text = "Timer: 1";
            await Task.Delay(1000);
            timer_lbl.Text = "Sending";

            List<char> datalist = new List<char>();
            datalist.AddRange(txt.Text);

            foreach (char item in datalist)
            {
                SendKeys.SendWait(item.ToString());
                if (randomise.Checked)
                {
                    Random rnd = new Random();
                    int dl = rnd.Next(1,int.Parse(textBox1.Text));
                    cur_delay.Visible = true;
                    cur_delay.Text = "Current delay: " + dl.ToString() + "ms";
                    await Task.Delay(dl);
                }
                else { await Task.Delay(10); }
            }
            timer_lbl.Text = "Sent";
            button1.Enabled = true;
            if (randomise.Checked) { textBox1.Enabled = true; }
            cur_delay.Visible = false;
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void randomise_CheckedChanged(object sender, EventArgs e)
        {
            if (!randomise.Checked) textBox1.Enabled = false;
            else textBox1.Enabled = true;
        }

        private void checkbox_click(object sender, EventArgs e)
        {
            if (randomise.Checked && chk)
            {
                randomise.Checked = false;
                chk = false;
            }
            else { randomise.Checked = true; chk = true; }
        }
    }
}
