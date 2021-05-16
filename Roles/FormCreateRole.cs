using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;

namespace Proiect.Roles
{
    public partial class FormCreateRole : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewRoles parent;

        public FormCreateRole()
        {
            InitializeComponent();
        }

        private void FormCreateRole_Load(object sender, EventArgs e)
        {
            parent = (FormViewRoles)Owner;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != string.Empty)
            {
                Role newRole = new Role();
                newRole.name = textBoxName.Text;

                webService.AddRole(newRole);
                MessageBox.Show("Rolul a fost adăugat cu succes!");
                this.Close();
            } else
            {
                MessageBox.Show("Completați toate câmpurile.");
            }
        }

        private void FormCreateRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
