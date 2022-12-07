using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPMS.Login_Forms
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

       
        private void toLoginFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //click getting started event
            LoginForm l1 = new LoginForm();
            l1.Show();
            this.Hide();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            if (circularProgressBar1.Value < 100)
            {
                circularProgressBar1.Value += 10;

            }
            else if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                label1.Hide();
                toLoginFormLink.Show();
            }
        }
        private void startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
