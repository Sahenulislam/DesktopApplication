using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Home2
{

    public partial class add_product : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        string imagelocation;
        public add_product(string Type,string Namex, string Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_panel admin_panelObject= new admin_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            admin_panelObject.Show();
        }

        private void add_product_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                imagelocation = System.IO.Path.GetFileName(ofd.FileName);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                System.IO.File.Copy(ofd.FileName, path + "\\Image\\" + imagelocation);
                //imagelocation = ofd.FileName.ToString();
                pictureBox.ImageLocation = path + "\\Image\\" + imagelocation;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
         
            string ProName = proname.Text;
            string ProCategory = comboBox1.Text;
            MessageBox.Show(imagelocation);

            string ProVideo = provideo.Text;
            string ProId = procode.Text;
            string ProPrice = proprice.Text;
            string ProDiscount = prodiscount.Text;
            string ProPercent = propercent.Text;
            string ProDescription = prodescription.Text;
            string ProQuantity = proquantity.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "insert into add_product(pro_id,pro_category,pro_name,pro_image,pro_video,pro_price,pro_discount,pro_percent,pro_description,pro_quantity)values('"+ ProId +"','" + ProCategory + "','" + ProName + "','" + imagelocation + "','" + ProVideo + "','" + ProPrice + "','" + ProDiscount + "','" + ProPercent + "','" + ProDescription + "','" + ProQuantity + "');";
            //string query = "insert into add_product(id,pro_category,pro_name,pro_image,pro_video,pro_code,pro_price,pro_discount,pro_percent,pro_description,quantity)values('NULL',@procate,@proname,@proimage,@provideo,@procode,@proprice,@prodiscount,@propercent,@prodes,@proqunatity);";
            MySqlCommand command = new MySqlCommand(query, conn);
           /* command.Parameters.Add("@procate", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@proname", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@proimage", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@provideo", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@procode", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@proprice", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@prodiscount", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@propercent", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@prodes", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@proqunatity", MySqlDbType.VarChar, 20);
            command.Parameters["@procate"].Value = procategory.Text;
            command.Parameters["@proname"].Value = procategory.Text;
            command.Parameters["@proimage"].Value = procategory.Text;
            command.Parameters["@provideo"].Value = procategory.Text;
            command.Parameters["@procode"].Value = procategory.Text;
            command.Parameters["@proprice"].Value = procategory.Text;
            command.Parameters["@prodiscount"].Value = procategory.Text;
            command.Parameters["@propercent"].Value = procategory.Text;
            command.Parameters["@prodes"].Value = procategory.Text;
            command.Parameters["@proqunatity"].Value = procategory.Text;*/

            command.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            add_product add_productObject = new add_product(this.Type, this.Namex, this.Idx, this.Emailx);
            add_productObject.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Text = comboBox1.Text;
        }
    }
}
