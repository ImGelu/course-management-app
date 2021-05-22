using Proiect.CoursesWebServiceReference;
using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormSignUp : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public FormSignUp()
        {
            InitializeComponent();

            toolTipEmail.SetToolTip(textBoxEmail, "Email-ul trebuie să se termine cu *.utcluj.ro");
            Utils.SetButtonImage(buttonCreateAccount, Properties.Resources.icon_login, 15, 15);
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

            name = textBoxName.Text;
            email = textBoxEmail.Text;
            password = textBoxPassword.Text;
            passwordConfirmation = textBoxPasswordConfirmation.Text;

            if (name != String.Empty && email != String.Empty && password != String.Empty && passwordConfirmation != String.Empty)
            {
                if (Utils.IsValidEmail(email))
                {
                    if (!Utils.EmailAlreadyTaken(email))
                    {
                        if (password.Equals(passwordConfirmation))
                        {
                            User newUser = new User();
                            newUser.name = name;
                            newUser.email = email;
                            newUser.password = password;

                            try
                            {
                                webService.AddUser(newUser);

                                User addedUser = webService.GetUserByEmail(newUser.email);

                                Role[] roles = new Role[1];
                                roles[0] = webService.GetRole(3);

                                webService.UpdateUserRoles(addedUser.id, roles);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("A apărut o eroare!\n" + ex.Message.ToString());
                            }

                            MessageBox.Show("Contul a fost creat cu succes. Poți să te conectezi acum!");
                            textBoxEmail.Text = String.Empty;
                            textBoxName.Text = String.Empty;
                            textBoxPassword.Text = String.Empty;
                            textBoxPasswordConfirmation.Text = String.Empty;

                            FormLogin parent = (FormLogin)Owner;
                            parent.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Parolele nu se potrivesc. Încearcă din nou!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Acest email este deja luat. Încearcă altul!");
                    }
                }
                else
                {
                    MessageBox.Show("Acest email nu este unul valid. Încearcă altul!");
                }
            }
            else
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!");
            }
        }
    }
}
