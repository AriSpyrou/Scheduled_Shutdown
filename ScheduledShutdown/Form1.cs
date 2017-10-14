using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                int seconds = int.Parse(comboBox2.Text) * 3600;
                switch (comboBox1.SelectedIndex)
                {
                    case (0):
                        {
                            Process.Start("CMD.exe", "/C shutdown -s -t " + seconds.ToString());
                            break;
                        }
                    case (1):
                        {
                            Process.Start("CMD.exe", "/C shutdown -r -t " + seconds.ToString());
                            break;
                        }
                }
            }
            catch(Exception) { MessageBox.Show("Make sure you have picked desired method and hours","Error"); }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "/C shutdown -a");
        }
    }
}
