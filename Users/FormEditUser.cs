using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormEditUser : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormViewUsers parent;
        private int id;
        private string name;
        private string email;
        private string pass;
        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(int id,string name, string email,string pass)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.email = email;
            this.pass = pass;
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxPassword.Text = pass;
            textBoxPasswordConfirmation.Text = pass;

        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            parent = new FormViewUsers();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        { 
       if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {
                CoursesWebServiceReference.User newUser = new CoursesWebServiceReference.User();
                newUser.id = id;
                newUser.name = textBoxName.Text;
                newUser.email = textBoxEmail.Text;
                newUser.password = textBoxPassword.Text;
                if (Utils.IsValidEmail(newUser.email))
                {


                    if (newUser.password.Equals(textBoxPasswordConfirmation.Text))
                    {
                        webService.EditUser(newUser);

                        MessageBox.Show("Utilizatorul a fost editat cu succes!");
                        this.Close();
                        parent.Show();
                    }

                    else
                    {
                        MessageBox.Show("The passwords don't match. Try again!");
                    }
                }





                else
                {
                    MessageBox.Show("Please enter a valid email address!");
                }
            }
            else

{
    MessageBox.Show("Please fill all the fields.");
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
