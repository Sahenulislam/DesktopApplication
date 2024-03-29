﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace Home2
{
    public partial class Bag : Form
    {
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public Bag(string Type, string Namex, string Idx, string Emailx)
        {
            InitializeComponent();
            this.MinimumSize = new Size(20, 50);
            this.CenterToScreen();
            this.Type = Type;
            this.Namex = Namex;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1ob = new Form1(this.Type, this.Namex, this.Idx, this.Emailx);
            form1ob.Show();
        }

        private void Bag_Load(object sender, EventArgs e)
        {
            populateitem();
        }
        public void populateitem()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            string query = "select *from add_product where pro_category='bag';";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            pro_display[] usercontrol1 = new pro_display[50];
            int i = 0;
            while (reader.Read())
            {
                usercontrol1[i] = new pro_display(this.Type, this.Namex, this.Idx, this.Emailx);
                usercontrol1[i].proid = reader.GetString(0);
                usercontrol1[i].procategory = reader.GetString(1);
                usercontrol1[i].Nam = reader.GetString(2);
                usercontrol1[i].Price = reader.GetString(5);
                usercontrol1[i].Quantity = reader.GetString(9);
                string img = reader.GetString(3);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                // MessageBox.Show(image);

                usercontrol1[i].Icon = new Bitmap(path + "\\Image\\" + img);

                flowLayoutPanel1.Controls.Add(usercontrol1[i]);
                i++;
            }

        }
    }
}
