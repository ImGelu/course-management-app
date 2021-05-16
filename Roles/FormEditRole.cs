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

namespace Proiect.Roles
{
    public partial class FormEditRole : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private Role role;
        private FormViewRoles parent;

        public FormEditRole()
        {
            InitializeComponent();
        }

        public FormEditRole(FormViewRoles parent, int id)
        {
            InitializeComponent();
            role = webService.GetRole(id);
            this.parent = parent;
        }

        private void FormEditRole_Load(object sender, EventArgs e)
        {
            textBoxName.Text = role.name;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
            {
                Role existingRole = new Role();
                existingRole.id = role.id;
                existingRole.name = textBoxName.Text;

                webService.EditRole(existingRole);
                MessageBox.Show("Rolul a fost salvat cu succes!");
                this.Close();
                parent.Show();
            }
            else
            {
                MessageBox.Show("Completați toate câmpurile.");
            }
        }

        private void toolStripButtonDeleteRole_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi acest rol?\n\nAcțiunea este ireversibilă.", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (webService.GetUsersWithRole(role.id).Length > 0)
                {
                    MessageBox.Show("Acest rol nu poate fi șters deoarece există utilizatori cu acest rol");
                }
                else
                {
                    webService.DeleteRole(role.id);
                    MessageBox.Show("Rolul a fost șters cu succes!");
                    this.Close();
                    parent.Show();
                }
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormEditRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
