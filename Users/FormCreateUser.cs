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
                if (Utils.IsValidEmail(newUser.email))
                {
                    if (!Utils.EmailAlreadyTaken(newUser.email))
                    {
                        if (newUser.password.Equals(textBoxPasswordConfirmation.Text))
                        {
                            webService.AddUser(newUser);

                            MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
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
                        MessageBox.Show("This email is already taken. Try another one!");
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

        private void FormCreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
