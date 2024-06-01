using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblloading.Top -= 1;
            if(lblloading.Top<=300)
            {
                timer1.Stop();
                timer2.Start();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblloading.Top += 1;
            if (lblloading.Top >= 360)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

        private void lblloading_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width>=443)
            {
                timer3.Stop();
                frmlogin form = new frmlogin();
                form.Show();
                this.Hide();
            }
            
        }
    }
}
