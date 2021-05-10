using System;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;

namespace Proiect
{
    public partial class FormEditUser : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewUsers parent;
        private User user;

        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(int id)
        {
            InitializeComponent();
            user = webService.GetUser(id);
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            parent = new FormViewUsers();
            textBoxEmail.Text = user.email;
            textBoxName.Text = user.name;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
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
                            newUser.id = user.id;
                            newUser.name = name;
                            newUser.email = email;
                            newUser.password = password;

                            try
                            {
                                webService.EditUser(newUser);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occured!\n" + ex.Message.ToString());
                            }

                            MessageBox.Show("The account has been successfully created. You can log in now!");
                            textBoxEmail.Text = String.Empty;
                            textBoxName.Text = String.Empty;
                            textBoxPassword.Text = String.Empty;
                            textBoxPasswordConfirmation.Text = String.Empty;

                            parent.Show();
                            this.Close();
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
    }
}
