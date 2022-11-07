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
    public partial class admin_login : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type=null;
        public admin_login(string Type,string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(300, 100);
            this.CenterToScreen();
            this.Type =Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Form1Object = new Form1(this.Type,this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type,this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            if(Username==""||Password=="")
            {
                this.Hide();
                this.Show();
            }
            else
            {
                this.Namex = Username;
                this.Type = "ADMIN";
                this.Hide();
                admin_panel admin_panelObject = new admin_panel(this.Type,this.Namex, this.Idx, this.Emailx);
                admin_panelObject.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkbox.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
