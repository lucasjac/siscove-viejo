using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SISCOVE___Todo_Envase
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Increment(1);

            if (ProgressBar.Value == 100)
            {
                Timer.Stop();
            }
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            for (double i = 0; i <= 1; i+= 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                Thread.Sleep(15);
            }
        }
    }
}
