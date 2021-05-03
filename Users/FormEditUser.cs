using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormEditUser : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormViewUsers parent;
        private int id;

        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            parent = (FormViewUsers)Owner;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            CoursesWebServiceReference.User user = new CoursesWebServiceReference.User();

            if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {
                user.id = id;
                user.name = textBoxName.Text;
                user.email = textBoxEmail.Text;
                user.password = textBoxPassword.Text;

                webService.EditUser(user);
                MessageBox.Show("Utilizatorul a fost editat cu succes!");
                this.Close();
                parent.Show();
            }
            else
            {
                MessageBox.Show("Campurile trebuie completate!");
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormEditUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
