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
    public partial class Login : Form
    {
        Config db = new Config();
        public Login()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `userinfo` where username='" + usernameBox.Text + "' and pass='" + passwordBox.Text + "'");
            if (db.Count() == 1)
            {
                MessageBox.Show("Success  You will login as " + db.Results(0, "name"));
            }
            else
                MessageBox.Show("Wrong username and password combination");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
