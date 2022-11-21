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
    public partial class Form1 : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public Form1(string Type,string Namex, string Idx,string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Women f1 = new Women(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob = f1;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
            Men f2 = new Men(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob1 = f2;
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book f3 = new Book(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob3 = f3;
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Hide();
            Bag f4 = new Bag(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob4 = f4;
            f4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shoe f5 = new Shoe(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob2 = f5;
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Furniture f6 = new Furniture(this.Type, this.Namex, this.Idx, this.Emailx);
            pro_display.ob5 = f6;
            f6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact f7 = new Contact(this.Type, this.Namex, this.Idx, this.Emailx);
            f7.Show();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            if(this.Type=="USER"&&this.Namex!="NULL")
            {
                this.Hide();
                user_panel user_PanelObject = new user_panel(this.Type, this.Namex, this.Idx, this.Emailx);
                user_PanelObject.Show();
            }
            else
            {
                this.Hide();
                user_login f8 = new user_login(this.Type, this.Namex, this.Idx, this.Emailx);
                f8.Show();
            }


        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Side.Width == 225)
            {
                Side.Width = 35;
            }
            else
                Side.Width = 225;
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            if(this.Type=="ADMIN"&&this.Namex!="NULL")
            {
                this.Hide();
                admin_panel admin_PanelObject = new admin_panel(this.Type, this.Namex, this.Idx, this.Emailx);
                admin_PanelObject.Show();
            }
            else
            {
                this.Hide();
                admin_login a1 = new admin_login(this.Type, this.Namex, this.Idx, this.Emailx);
                a1.Show();
            }



        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
