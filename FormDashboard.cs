using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            toolStripSplitButtonLoggedIn.Text = String.Format("Logged in as {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
            toolStripSplitButtonLoggedIn.ToolTipText = String.Format("Logged in as {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
            Utils.SetButtonImage(buttonViewCourses, Properties.Resources.icon_course);
            Utils.SetButtonImage(buttonViewRequests, Properties.Resources.icon_request);
            Utils.SetButtonImage(buttonViewDomains, Properties.Resources.icon_domain);
            Utils.SetButtonImage(buttonViewSpecializations, Properties.Resources.icon_specialization);
            Utils.SetButtonImage(buttonViewRoles, Properties.Resources.icon_role);
            Utils.SetButtonImage(buttonViewFaculties, Properties.Resources.icon_faculty);
            Utils.SetButtonImage(buttonViewUsers, Properties.Resources.icon_users);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.rememberMe = false;
            Properties.Settings.Default.loggedInUserId = 0;
            Properties.Settings.Default.Save();

            FormLogin parent = (FormLogin)Owner;

            if(parent != null)
            {
                parent.Show();
            } else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }

            this.Hide();
        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            FormViewCourses formViewCourses = new FormViewCourses();
            formViewCourses.Show();
            this.Hide();
        }

        private void buttonViewRequests_Click(object sender, EventArgs e)
        {
            FormViewRequests formViewRequests = new FormViewRequests();
            formViewRequests.Show(this);
            this.Hide();
        }

        private void buttonViewFaculties_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void buttonViewDomains_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void buttonViewSpecializations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            FormViewUsers formViewUsers = new FormViewUsers();
            formViewUsers.Show(this);
            this.Hide();
        }

        private void buttonViewRoles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
    }
}
