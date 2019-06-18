using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CapaPresentacion
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }



        private void SplashScreen_Load(object sender, EventArgs e)
        {
  
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuSeparator1.Width < 558 )
            {
                bunifuSeparator1.Width = bunifuSeparator1.Width + 15;  
            }
           

            if (bunifuSeparator2.Height < 345)
            {
                bunifuSeparator2.Height = bunifuSeparator2.Height + Convert.ToInt32(9.27);   
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
                
            }

        }



        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal lg = new MenuPrincipal();
            lg.Show();
        }


    }
}
