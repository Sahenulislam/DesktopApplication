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
    public partial class see_productadmin : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public see_productadmin(string Type, string Namex, string Idx, string Emailx)
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
            string query = "select *from add_product;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            see_productusercontrol[] usercontrol2 = new see_productusercontrol[50];
            int i = 0;
            while (reader.Read())
            {
                usercontrol2[i] = new see_productusercontrol();
                usercontrol2[i].Id = reader.GetString(0);
                usercontrol2[i].Nam = reader.GetString(2);
                usercontrol2[i].Category = reader.GetString(1);
                usercontrol2[i].Price = reader.GetString(5);
                usercontrol2[i].Quantity = reader.GetString(9);
                flowLayoutPanel1.Controls.Add(usercontrol2[i]);
                i++;
            }

        }

        private void see_productadmin_Load(object sender, EventArgs e)
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
