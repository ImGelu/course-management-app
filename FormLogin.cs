using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormLogin : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email, password;

            CoursesWebServiceReference.User loginUser = new CoursesWebServiceReference.User();

            email    = textBoxEmail.Text;
            password = textBoxPassword.Text;

            loginUser = webService.CheckLogin(email, password);

            if (loginUser != null) MessageBox.Show("Login successful!");
            else MessageBox.Show("Wrong email/password combination. Try again.");
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show(this);
            this.Hide();
        }
    }
}
