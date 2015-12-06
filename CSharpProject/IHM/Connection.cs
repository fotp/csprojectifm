using CSharpProject.authentification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject.IHM
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            try
            {
                AuthentificationManager am = new Authentification();
                am.load("users.txt");
                am.authentify(boxLogin.Text, boxPassword.Text);
                labelStatus.Text = "Access granted"; //à gérer car il s'affichera toujours 
            }
            catch (Exception)
            {

                labelStatus.Text = "Error !";
            }

        }
    }
}
