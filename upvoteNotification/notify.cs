using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upvoteNotification
{
    public partial class notify : Form
    {
        public notify()
        {
            InitializeComponent();
        }

        public static string url = "";
        public static int upCount = 0;
        public static double sbd = 0;
        //public static string url = "";

        private void notify_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
              label1.Text = url;
            upvoteL.Text = "Upv: " + upCount.ToString(); ;
            sbdL.Text = sbd.ToString()+" SB$";
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 10;
            if (i < 210)
            {
                //it will calculate our screen for right bottom and raise up notify form slowly
                this.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height - i);
            }
            else if (i > 1200) this.Close();
        }
    }
}
