using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanOOP
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int sql = db.Execute("INSERT INTO userinfo (username,pass,name) VALUES ('" + usernameBox.Text + "','" + passwordBox.Text + "','" + nameBox.Text + "')");
            if (sql != 0)
            {
                MessageBox.Show("Successfuly Registered");
            }
            else
                MessageBox.Show("Failed to Register");

            this.Close();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
