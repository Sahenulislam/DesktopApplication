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
    public partial class dashboard: Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        public dashboard(string Type,string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        public void loadform(object Form)

        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();


        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new user_login(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new user_reg(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }
    }
}
