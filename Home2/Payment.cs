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
    public partial class Payment : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        string pro_id;
        string procategory = null;
        
        public Payment(string procatagory,string pro_id,string Type, string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.procategory = procatagory;
            this.pro_id = pro_id;
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        /*public void loadform(object Form)

        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }*/
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // loadform(new Cashondelivery(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loadform(new Bkash(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loadform(new Nagad(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //loadform(new Rocket(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //loadform(new Master_card(this.Type, this.Namex, this.Idx, this.Emailx));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bkash ob = new Bkash(this.procategory,this.pro_id,this.Type,this.Namex, this.Idx, this.Emailx);
            ob.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Nagad ob = new Nagad(this.procategory,this.pro_id,this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rocket ob = new Rocket(this.procategory,this.pro_id,this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Master_card ob = new Master_card(this.procategory,this.pro_id,this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashondelivery ob = new Cashondelivery(this.procategory,this.pro_id,this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (procategory == "Women")
            {
                this.Hide();
                Women ob1 = new Women(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob = ob1;
                ob1.Show();
            }
            else if (procategory == "Men")
            {
                this.Hide();
                Men ob = new Men(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob1 = ob;
                ob.Show();
            }
            else if (procategory == "Shoe")
            {
                this.Hide();
                Shoe ob = new Shoe(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob2 = ob;
                ob.Show();
            }
            else if (procategory == "Book")
            {
                this.Hide();
                Book ob = new Book(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob3 = ob;
                ob.Show();
            }
            else if (procategory == "Bag")
            {
                this.Hide();
                Bag ob = new Bag(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob4 = ob;
                ob.Show();
            }
            else if (procategory == "Furniture")
            {
                this.Hide();
                Furniture ob = new Furniture(this.Type, this.Namex, this.Idx, this.Emailx);
                pro_display.ob5 = ob;
                ob.Show();
            }
        }
    }
}

