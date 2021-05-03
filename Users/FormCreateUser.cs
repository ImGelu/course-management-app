using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormCreateUser : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormViewUsers parent;

        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            parent = (FormViewUsers)Owner;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {
                CoursesWebServiceReference.User newUser = new CoursesWebServiceReference.User();

                newUser.name = textBoxName.Text;
                newUser.email = textBoxEmail.Text;
                newUser.password = textBoxPassword.Text;

                webService.AddUser(newUser);

                MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
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

        private void FormCreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
