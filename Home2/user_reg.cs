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
    public partial class user_reg : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        public user_reg(string Type,string Namex, int Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            string Email = email.Text;
            string ConfirmPassword = conformpassword.Text;
            bool f = true;
            if(Password!=ConfirmPassword)
            {
                f = false;
            }
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "insert into user_login(id,User_name,email,password)values('NULL','" + Username + "','" + Email + "','" + Password + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            if(f==false)
            {
                MessageBox.Show("Password did't Match");
                this.Hide();
                user_reg ob1 = new user_reg(this.Type, this.Namex, this.Idx, this.Emailx);
                ob1.Show();
            }
            else
            {
                MessageBox.Show("Successfully Registered");
                this.Hide();
                user_login ob = new user_login(this.Type, this.Namex, this.Idx, this.Emailx);
                ob.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_login ob1 = new user_login(this.Type, this.Namex, this.Idx, this.Emailx);
            ob1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Object = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            Form1Object.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                password.UseSystemPasswordChar = false;
                conformpassword.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                conformpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
