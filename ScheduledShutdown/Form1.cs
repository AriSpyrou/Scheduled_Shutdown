using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScheduledShutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            try
            {
                int seconds;
                if (comboBox1.Text == "")
                {
                    seconds = int.Parse(comboBox2.Text) * 3600;
                }
                else if (comboBox2.Text == "")
                {
                    seconds = int.Parse(comboBox1.Text) * 60;
                }
                else
                {
                    seconds = int.Parse(comboBox2.Text) * 3600 + int.Parse(comboBox1.Text) * 60;
                }
                Process.Start("CMD.exe", "/C shutdown -s -t " + seconds.ToString());
            }
            catch(Exception) { MessageBox.Show("Make sure you have picked desired method, hours and minutes","Error"); }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "/C shutdown -a");
        }
    }
}
