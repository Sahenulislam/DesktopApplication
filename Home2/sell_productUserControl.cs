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
    public partial class sell_productUserControl : UserControl
    {
        public sell_productUserControl()
        {
            InitializeComponent();
        }

        private void sell_productUserControl_Load(object sender, EventArgs e)
        {

        }
        private string _id;
        [Category("customer props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; label1.Text = value; }
        }
        private string _Userid;
        [Category("customer props")]
        public string Userid
        {
            get { return _Userid; }
            set { _Userid = value; label2.Text = value; }
        }
        private string _name;
        [Category("customer props")]
        public string Nam
        {
            get { return _name; }
            set { _name = value; label3.Text = value; }
        }

        private string _price;
        [Category("customer props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; label5.Text = value; }
        }
        private string _address;
        [Category("customer props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; label6.Text = value; }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
