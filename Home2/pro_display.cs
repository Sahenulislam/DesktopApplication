using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Home2
{
    public partial class pro_display : UserControl
    {
        static public Women ob;
        static public Men ob1;
        static public Shoe ob2;
        static public Book ob3;
        static public Bag ob4;
        static public Furniture ob5;
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public pro_display(string Type, string Namex, string Idx, string Emailx)
        {
            MessageBox.Show(Idx.ToString());
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }
        private string _name;
        [Category("customer props")]
        public string Nam
        {
            get { return _name; }
            set { _name = value; label4.Text = value; }
        }
        private string _proid;
        [Category("customer props")]
        public string proid
        {
            get { return _proid; }
            set { _proid = value; }
        }
        private string _price;
        [Category("customer props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; label5.Text = value; }
        }
        private string _quantity;
        [Category("customer props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; label6.Text = value; }
        }
        private string _procategory;
        [Category("customer props")]
        public string procategory
        {
            get { return _procategory; }
            set { _procategory = value;  }
        }
        private Image _icon;
        [Category("customer props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Namex == "NULL" || this.Type == "ADMIN")
            {
                MessageBox.Show("For Buy You Need to Login First");
                user_login ob8 = new user_login(this.Type, this.Namex, this.Idx, this.Emailx);
                ob8.Show();
                if (procategory == "Women")
                {
                    ob.Hide();
                }
                else if (procategory == "Men")
                {
                    ob1.Hide();
                }
                else if (procategory == "Shoe")
                {
                    ob2.Hide();
                }
                else if (procategory == "Book")
                {
                    ob3.Hide();
                }
                else if (procategory == "Bag")
                {
                    ob4.Hide();
                }
                else if (procategory == "Furniture")
                {
                    ob5.Hide();

                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
                conn.Open();
                string q = "select *from add_product where pro_id=" +proid+ "";
                MySqlCommand command = new MySqlCommand(q, conn);
                MySqlDataReader reader = command.ExecuteReader();
                string pro_name=null;
                string pro_quantity=null;
                string pro_price=null;
                while(reader.Read())
                {
                    pro_name = reader.GetString(2);
                    pro_quantity = reader.GetString(3);
                    pro_price = reader.GetString(4);
                 
                }
                //MessageBox.Show(this.Idx.ToString());
                string pro_id = _proid;
                //MessageBox.Show(pro_id);
                string query = "insert into cart(user_id,product_id ,product_name,quantity,price)values('" + this.Idx + "','" + pro_id + "','" + pro_name + "','" + pro_quantity + "','" + pro_price + "');";
                MySqlCommand commandd = new MySqlCommand(query, conn);

                //commandd.ExecuteNonQuery();
                conn.Close();

            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescriptionForm ob6 = new DescriptionForm(procategory,proid, this.Type, this.Namex, this.Idx, this.Emailx);
            ob6.Show();
            if (procategory == "Women")
            {
                ob.Hide();
            }
            else if (procategory == "Men")
            {
                ob1.Hide();
            }
            else if (procategory == "Shoe")
            {
                ob2.Hide();
            }
            else if (procategory == "Book")
            {
                ob3.Hide();
            }
            else if (procategory == "Bag")
            {
                ob4.Hide();
            }
            else if (procategory == "Furniture")
            {
                ob5.Hide();
            }
        }

        private void pro_display_Load(object sender, EventArgs e)
        {

        }
    }
   
}
