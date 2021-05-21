using Proiect.CoursesWebServiceReference;
using System;
using System.Windows.Forms;

namespace Proiect.Users
{
    public partial class FormChangePassword : Form
    {
        private int id;
        private FormEditUser parent;

        public FormChangePassword()
        {
            InitializeComponent();
        }

        public FormChangePassword(FormEditUser parent, int id)
        {
            InitializeComponent();
            this.id = id;
            this.parent = parent;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            string pass, passConf;
            pass = textBoxPassword.Text;
            passConf = textBoxPasswordConfirmation.Text;

            if (pass != String.Empty && passConf != String.Empty)
            {
                if (pass.Equals(passConf))
                {
                    CoursesWebService webService = new CoursesWebService();
                    webService.UpdatePassword(id, pass);
                    MessageBox.Show("Parola a fost actualizată cu succes!");
                    this.Close();
                }
                else MessageBox.Show("Parolele nu se potrivesc. Încearcă din nou!");
            }
            else MessageBox.Show("Toate câmpurile sunt obligatorii!");
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
