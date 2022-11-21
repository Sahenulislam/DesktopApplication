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
    public partial class cart : Form
    {
        string usrID;

        public cart(string ID)
        {
            usrID = ID;
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            
            string query = "SELECT `product_id`,`product_name`,`quantity`,`price`,(`quantity`*`price`) as `total` FROM `cart` WHERE `user_id`= "+usrID;
            MessageBox.Show(usrID);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();


            string id, name, qunt, price, total;
            while (reader.Read())
            {
                id = reader.GetString(0);
                name = reader.GetString(1);
                qunt = reader.GetString(2);
                price = reader.GetString(3);
                total = reader.GetString(4);

                cartGrid.Rows.Add(new object[] { id, name, qunt, price, total });

            }
            conn.Close();

            
        }
    }
}
