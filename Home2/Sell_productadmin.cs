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
    public partial class Sell_productadmin : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public Sell_productadmin(string Type, string Namex, string Idx, string Emailx)
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
            sell_productUserControl[] usercontrol3 = new sell_productUserControl[50];
            int i = 0;
            while (reader.Read())
            {
                usercontrol3[i] = new sell_productUserControl();
                usercontrol3[i].Id = reader.GetString(2);
                usercontrol3[i].Userid = reader.GetString(1);
                usercontrol3[i].Nam = reader.GetString(7);
                usercontrol3[i].Price = reader.GetString(6);
                usercontrol3[i].Address= reader.GetString(4);
                flowLayoutPanel1.Controls.Add(usercontrol3[i]);
                i++;
            }

        }

        private void Sell_productadmin_Load(object sender, EventArgs e)
        {
            populateitem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_panel ob = new admin_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
