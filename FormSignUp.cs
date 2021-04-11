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
    public partial class FormSignUp : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public FormSignUp()
        {
            InitializeComponent();

            toolTipEmail.SetToolTip(textBoxEmail, "The email must end with *.utcluj.ro");
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin parent = (FormLogin)Owner;
            parent.Show();
            this.Hide();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string name, email, password, passwordConfirmation;

            name                 = textBoxName.Text;
            email                = textBoxEmail.Text;
            password             = textBoxPassword.Text;
            passwordConfirmation = textBoxPasswordConfirmation.Text;

            if(name != String.Empty && email != String.Empty && password != String.Empty && passwordConfirmation != String.Empty)
            {
                if (IsValidEmail(email))
                {
                    if (password.Equals(passwordConfirmation))
                    {
                        CoursesWebServiceReference.User newUser = new CoursesWebServiceReference.User();
                        newUser.name = name;
                        newUser.email = email;
                        newUser.password = password;

                        try
                        {
                            webService.AddUser(newUser);
                        } catch(Exception ex)
                        {
                            MessageBox.Show("An error occured!\n" + ex.Message.ToString());
                        }

                        MessageBox.Show("The account has been successfully created. You can log in now!");
                        textBoxEmail.Text = String.Empty;
                        textBoxName.Text = String.Empty;
                        textBoxPassword.Text = String.Empty;
                        textBoxPasswordConfirmation.Text = String.Empty;

                        FormLogin parent = (FormLogin)Owner;
                        parent.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("The passwords don't match. Try again!");
                    }
                } else
                {
                    MessageBox.Show("Please enter a valid email address!");
                }
            } else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
