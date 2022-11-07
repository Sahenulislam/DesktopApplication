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
    public partial class admin_panel : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        public admin_panel(string Type, string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 20);
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 From1Object = new Form1("NULL","NULL", -1, "NULL");
            From1Object.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 From1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            From1Object.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_product add_productObject = new add_product(this.Type, this.Namex, this.Idx, this.Emailx);
            add_productObject.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 From1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            From1Object.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            see_productadmin ob = new see_productadmin(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sell_productadmin ob = new Sell_productadmin(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_message ob = new user_message(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
