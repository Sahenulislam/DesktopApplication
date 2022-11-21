using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Home2
{
    public partial class UserProductBuy : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public UserProductBuy(string Type, string Namex, string Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }
        public void populateitem()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from product_buy;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            UserControlUserProductBuy[] usercontrol5 = new UserControlUserProductBuy[50];
            int i = 0;
            while (reader.Read())
            {
                if(reader.GetString(1)==this.Namex)
                {
                    string k = reader.GetString(0);
                    usercontrol5[i] = new UserControlUserProductBuy();
                    usercontrol5[i].Id = reader.GetString(2);
                    usercontrol5[i].Nam = reader.GetString(7);
                    usercontrol5[i].Category = reader.GetString(8);
                    usercontrol5[i].Price = reader.GetString(6);
                    flowLayoutPanel1.Controls.Add(usercontrol5[i]);
                    i++;
                }
              
            }

        }

        private void UserProductBuy_Load(object sender, EventArgs e)
        {
            populateitem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_panel ob = new user_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
