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
    public partial class user_message : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        public user_message(string Type, string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void user_message_Load(object sender, EventArgs e)
        {
            populateitem();
        }
        public void populateitem()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from user_msg;";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            user_msgform[] usercontrol4 = new user_msgform[50];
            int i = 0;
            while (reader.Read())
            {
                usercontrol4[i] = new user_msgform();
                usercontrol4[i].Usernam = reader.GetString(1);
                usercontrol4[i].UserMessage = reader.GetString(3);
                flowLayoutPanel1.Controls.Add(usercontrol4[i]);
                i++;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_panel ob = new admin_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
