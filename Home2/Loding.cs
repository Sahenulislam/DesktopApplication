using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home2
{
    public partial class Loding : Form
    {
        public Loding()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 220; i++)
            {
                panelLOAD.Width = panelLOAD.Width + 3;
                Thread.Sleep(1);
            }
            timer1.Stop();

            this.Hide();
            Form1 mn = new Form1("NULL", "NULL", "NULL", "NULL");
            mn.Show();

        }
        private void Loading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
