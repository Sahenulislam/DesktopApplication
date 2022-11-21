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
    public partial class Bkash : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        string pro_id = null;
        string procategory = null;
        public Bkash(string procategory, string pro_id, string Type, string Namex, string Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.procategory = procategory;
            this.pro_id = pro_id;
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string q = "select *from add_product";
            MySqlCommand command = new MySqlCommand(q, conn);
            MySqlDataReader reader = command.ExecuteReader();
            string username = this.Namex;
            string proid = this.pro_id;
            string userphone = user_phone.Text;
            string address = Address.Text;
            string delivery = "Bkash";
            string ProCategory = null;
            string ProPrice = null;
            string ProName = null;
            string ProQuantity = null;
            while (reader.Read())
            {
                if (reader.GetString(0) == this.pro_id)
                {
                    ProCategory = reader.GetString(1);
                    ProPrice = reader.GetString(5);
                    ProName = reader.GetString(2);
                    ProQuantity = reader.GetString(8);
                    break;
                }



            }
            conn.Close();
            MySqlConnection connn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            connn.Open();
            

            string query = "insert into product_buy(user_name,pro_id,user_phone,address,delivery,pro_price,pro_name,pro_category,pro_quantity)values('" + username + "','" + proid + "','" + userphone + "','" + address + "','" + delivery + "','" + ProPrice + "','" + ProName + "','" + ProCategory + "','" + ProQuantity + "');";
            MySqlCommand commandd = new MySqlCommand(query, connn);

            commandd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Buy");
            this.Hide();
            Form1 obj = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment ob = new Payment(this.procategory, this.Type, this.pro_id, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
