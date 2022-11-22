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
    public partial class UserContact : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public UserContact(string Type, string Namex, string Idx, string Emailx)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = this.Namex;
            string UserEmail = this.Emailx;
            string UserMassage = message.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "insert into user_msg(Id,name,email,massage)values('NULL','" + UserName + "','" + UserEmail + "','" + UserMassage + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully sent");
            this.Hide();
            UserContact ContactObject = new UserContact(this.Type, this.Namex, this.Idx, this.Emailx);
            ContactObject.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_panel ob = new user_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }
    }
}
