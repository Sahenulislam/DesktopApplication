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
    public partial class user_msgform : UserControl
    {
        public user_msgform()
        {
            InitializeComponent();
        }

       
        private string _Username;
        [Category("customer props")]
        public string Usernam
        {
            get { return _Username; }
            set { _Username = value; label2.Text = value; }
        }

        private string _UserMessage;
        [Category("customer props")]
        public string UserMessage
        {
            get { return _UserMessage; }
            set { _UserMessage = value; label3.Text = value; }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
