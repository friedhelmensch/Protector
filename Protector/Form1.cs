using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protector
{
    public partial class Form1 : Form
    {
        private readonly Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            InterceptInputs.SetHooks(lockMachine);
            timer.Stop();
        }

        void lockMachine()
        {
            H4x0r.LockWorkStation();
            Application.Exit();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.button1.Text = "Started";
            this.button1.Enabled = false;
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}
