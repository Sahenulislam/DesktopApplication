using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 266; i++)
            {
                //panelLOAD.Width = panelLOAD.Width + 3;
               // thread.Sleep(1);
            }
            //Form2.Stop();



        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
