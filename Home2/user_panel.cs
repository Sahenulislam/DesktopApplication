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
    public partial class user_panel : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        public user_panel(string Type,string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type ;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 HomeObject = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            HomeObject.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Namex = "NULL";
            this.Idx = -1;
            this.Emailx = "NULL";
            this.Hide();
            Form1 f1 = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            f1.Show();
        }

        private void user_panel_Load(object sender, EventArgs e)
        {
            string s = this.Namex;
            /*for(int i=0;i<s.Length;i++)
            {
                if (s[i]>=97)
                {

                    ss += (s[i]-32);
                }
                else
                    ss += s[i];
                
            }*/
            s += " panel";
            label1.Text = s;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserContact ob = new UserContact(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProductBuy ob = new UserProductBuy(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            cart cartObject = new cart(Idx);
            this.Hide();
            cartObject.Show();
        }
    }
}
