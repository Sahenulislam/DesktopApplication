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
    public partial class UserControlUserProductBuy : UserControl
    {
        public UserControlUserProductBuy()
        {
            InitializeComponent();
        }
        private string _id;
        [Category("customer props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; label1.Text = value; }
        }
        private string _name;
        [Category("customer props")]
        public string Nam
        {
            get { return _name; }
            set { _name = value; label2.Text = value; }
        }

        private string _price;
        [Category("customer props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; label4.Text = value; }
        }
        private string _category;
        [Category("customer props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; label3.Text = value; }

        }
    }
}
