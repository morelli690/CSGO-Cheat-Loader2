using Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_Loader
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            Handler.Initialize("219454", "qAKWGFymsBsCZx5ogoFstwwS943PrOxrwaL", "1.0"); //user admin id, program secret, version of it
        }

        private void OpenRegister_Click(object sender, EventArgs e)
        {
            Register form = new Register(); //creates new form
            form.Show(); //show this form
        }

        private void llogin_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //bugs sometimes
            bool response = Handler.Login(Username.Text, Password.Text); //login using the first and the second textbox, there is a third argument that disables the auth.gg login messages
            if (response)
            {
                //log the user that logged in kys
                Handler.Log(Username.Text, "logged in");

                Main form = new Main(); //create a new main form
                this.Hide(); //hide this form
                form.Show(); //open the new main form

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //close the app if the form is closed
        }

    }
}
