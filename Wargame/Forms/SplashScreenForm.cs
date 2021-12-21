using System;
using System.Windows.Forms;

namespace Wargame.Forms
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(15);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                MainForm menuForm = new MainForm();
                menuForm.Show();
                this.Hide();
            }
        }
    }
}
