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
    public partial class Contact : Form
    {
        string Namex = null;
        int Idx = -1;
        string Emailx = null;
        string Type = null;
        MySqlConnection connection = new MySqlConnection();
        public Contact(string Type, string Namex, int Idx, string Emailx)
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
            string UserName = textName.Text;
            string UserEmail = textEmail.Text;
            string UserMassage = textMassage.Text;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "insert into user_msg(Id,name,email,massage)values('NULL','" + UserName + "','" + UserEmail + "','" + UserMassage + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully sent");
            this.Hide();
            Contact ContactObject = new Contact(this.Type,this.Namex, this.Idx, this.Emailx);
            ContactObject.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            f1.Show();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}
