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
    public partial class user_login : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;

        public user_login(string Type,string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            user_reg ob = new user_reg(this.Type, this.Namex, this.Idx, this.Emailx);
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from user_login;";
            MySqlCommand command = new MySqlCommand(query,conn);
            MySqlDataReader reader = command.ExecuteReader();
            bool f = false;
            while(reader.Read())
            {
                if (reader.GetString(1)==Username&&reader.GetString(3)==Password)
                {
                    f = true;
                    this.Namex = reader.GetString(1);
                    this.Type = "USER";
                    break; 
                }
            }
            conn.Close();
            if (f==true)
            {
                this.Hide();
                user_panel user_panelObject = new user_panel(this.Type, this.Namex, this.Idx, this.Emailx);
                user_panelObject.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                this.Refresh();
                /*user_login ob = new user_login();
                ob.Show();*/
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void user_login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void application_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
