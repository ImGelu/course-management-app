using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormLogin : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public FormLogin()
        {
            InitializeComponent();
            Utils.SetButtonImage(buttonLogin, Properties.Resources.icon_login, 15, 15);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email, password;

            CoursesWebServiceReference.User loginUser = new CoursesWebServiceReference.User();

            email = textBoxEmail.Text;
            password = textBoxPassword.Text;

            loginUser = webService.CheckLogin(email, password);

            if (loginUser != null)
            {
                Properties.Settings.Default.rememberMe = checkBoxRememberMe.Checked;
                Properties.Settings.Default.loggedInUserId = loginUser.id;
                Properties.Settings.Default.Save();

                textBoxEmail.Text = String.Empty;
                textBoxPassword.Text = String.Empty;
                checkBoxRememberMe.Checked = false;

                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Show(this);
                this.Hide();
            }
            else MessageBox.Show("Email-ul și parola nu se potrivesc. Încearcă din nou!");
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show(this);
            this.Hide();
        }

        private void linkLabelGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show(this);
            this.Hide();
        }
    }
}
