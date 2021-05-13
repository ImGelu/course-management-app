using System;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

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
            listBoxRoles.ValueMember = "name";
            comboBoxRoles.ValueMember = "name";

            List<Role> rolesToBeRemoved = new List<Role>();

            webService.GetRoles().ToList().ForEach((role) =>
            {
                comboBoxRoles.Items.Add(role);
            });

            webService.GetUserRoles(user.id).ToList().ForEach((userRole) =>
            {
                listBoxRoles.Items.Add(userRole);

                foreach(Role role in comboBoxRoles.Items)
                {
                    if(role.id == userRole.id)
                    {
                        rolesToBeRemoved.Add(role);
                    }
                }
            });

            rolesToBeRemoved.ForEach((role) =>
            {
                comboBoxRoles.Items.Remove(role);
            });
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
                    if (!Utils.EmailAlreadyTaken(email) || email == user.email)
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
                                Role[] rolesToBeUpdated = new Role[100];
                                int i = 0;

                                listBoxRoles.Items.Cast<Role>().ToList().ForEach((role) =>
                                {
                                    rolesToBeUpdated[i++] = role;
                                });

                                webService.EditUser(newUser);
                                webService.UpdateUserRoles(user.id, rolesToBeUpdated);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occured!\n" + ex.Message.ToString());
                            }

                            MessageBox.Show("Salvările au fost realizate cu succes!");
                            textBoxEmail.Text = String.Empty;
                            textBoxName.Text = String.Empty;
                            textBoxPassword.Text = String.Empty;
                            textBoxPasswordConfirmation.Text = String.Empty;

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

        private void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi acest utilizator?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteUser(user.id);
                MessageBox.Show("Utilizatorul a fost șters cu succes!");
                this.Close();
            }
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            Role selectedItem = (Role)comboBoxRoles.SelectedItem;

            if (comboBoxRoles.SelectedItem != null)
            {
                listBoxRoles.Items.Add(selectedItem);
            }

            comboBoxRoles.Items.Remove(selectedItem);
        }

        private void listBoxRoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                Role selectedItem = (Role)listBoxRoles.SelectedItem;

                e.Handled = true;
                if (selectedItem != null)
                {
                    listBoxRoles.Items.Remove(selectedItem);
                    comboBoxRoles.Items.Add(selectedItem);
                }
            }
        }
    }
}
