using Proiect.CoursesWebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    MessageBox.Show("The password was changed succesfully!");
                    this.Close();
                }
                else MessageBox.Show("The passwords don't maatch");
            }
            else MessageBox.Show("Please fill all the fields");
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
