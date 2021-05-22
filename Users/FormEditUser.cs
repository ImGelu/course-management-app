using System;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;
using System.Linq;
using System.Collections.Generic;
using Proiect.Users;

namespace Proiect
{
    public partial class FormEditUser : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewUsers parentUsers = null;
        private FormViewUser parentUser = null;
        private FormDashboard parentDashboard = null;
        private User user;

        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(FormViewUsers parent, int id)
        {
            InitializeComponent();
            user = webService.GetUser(id);
            this.parentUsers = parent;
        }

        public FormEditUser(FormViewUser parent, int id)
        {
            InitializeComponent();
            user = webService.GetUser(id);
            this.parentUser = parent;
        }

        public FormEditUser(FormDashboard parent, int id)
        {
            InitializeComponent();
            user = webService.GetUser(id);
            this.parentDashboard = parent;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            if (!webService.UserIs(Utils.GetLoggedInUser().id, "Administrator"))
            {
                toolStripButtonDeleteUser.Visible = false;
            }
            
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

                foreach (Role role in comboBoxRoles.Items)
                {
                    if (role.id == userRole.id)
                    {
                        rolesToBeRemoved.Add(role);
                    }
                }
            });

            rolesToBeRemoved.ForEach((role) =>
            {
                comboBoxRoles.Items.Remove(role);
            });

            if (!webService.UserIs(Utils.GetLoggedInUser().id, "Administrator"))
            {
                comboBoxRoles.Enabled = false;
                listBoxRoles.Enabled = false;
                buttonAddRole.Enabled = false;
            }

            this.Text = String.Format("Editare utilizator • {0}", user.name);
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();

            if (parentUser != null)
            {
                parentUser.Show();
            }
            else if (parentUsers != null)
            {
                parentUsers.Show();
            }
            else
            {
                parentDashboard.Show();
            }
        }

        private void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi acest utilizator?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Role[] roles = new Role[1];

                webService.UpdateUserRoles(user.id, roles);
                webService.DeleteUser(user.id);
                MessageBox.Show("Utilizatorul a fost șters cu succes!");
                this.Close();
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            string name, email;

            name = textBoxName.Text;
            email = textBoxEmail.Text;

            if (name != String.Empty && email != String.Empty)
            {
                if (Utils.IsValidEmail(email))
                {
                    if (!Utils.EmailAlreadyTaken(email) || email == user.email)
                    {
                        User newUser = new User();
                        newUser.id = user.id;
                        newUser.name = name;
                        newUser.email = email;

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
                            MessageBox.Show("A apărut o eroare!\n" + ex.Message.ToString());
                        }

                        MessageBox.Show("Salvările au fost realizate cu succes!");
                        textBoxEmail.Text = String.Empty;
                        textBoxName.Text = String.Empty;

                        this.Close();
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

        private void FormEditUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentUser != null)
            {
                parentUser.Show();
            }
            else if (parentUsers != null)
            {
                parentUsers.Show();
            }
            else
            {
                parentDashboard.Show();
            }
        }

        private void toolStripButtonChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword newForm = new FormChangePassword(this, user.id);
            newForm.Show();
            this.Hide();
        }
    }
}
