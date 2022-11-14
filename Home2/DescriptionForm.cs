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
    public partial class DescriptionForm : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        string procategory = null;
        public DescriptionForm(string procategory, string Type, string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 20);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
            this.procategory = procategory;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
