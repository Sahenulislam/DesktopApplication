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
    public partial class DescriptionForm : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        string procategory = null;
        string pro_id = null;

        public DescriptionForm(string procatagory, string pro_id, string Type, string Namex, int Idx, string Emailx)
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

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string x = pro_id.ToString();
            string query = "select *from add_product where pro_id=" + x + ";";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string img = reader.GetString(3);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                PictureBox.Image = new Bitmap(path + "\\Image\\" + img);
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Description.Text = reader.GetString(8);
                waranty.Text = reader.GetString(5);

            }
            conn.Close();
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
