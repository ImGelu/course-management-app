using Proiect.CoursesWebServiceReference;
using Proiect.Domains;
using Proiect.Faculties;
using Proiect.Roles;
using Proiect.Specializations;
using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormDashboard : Form
    {
        public static CoursesWebService webService = new CoursesWebService();

        public FormDashboard()
        {
            InitializeComponent();
            toolStripSplitButtonLoggedIn.Text = String.Format("Conectat ca {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
            toolStripSplitButtonLoggedIn.ToolTipText = String.Format("Conectat ca {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
            Utils.SetButtonImage(buttonViewCourses, Properties.Resources.icon_course);
            Utils.SetButtonImage(buttonViewRequests, Properties.Resources.icon_request);
            Utils.SetButtonImage(buttonViewDomains, Properties.Resources.icon_domain);
            Utils.SetButtonImage(buttonViewSpecializations, Properties.Resources.icon_specialization);
            Utils.SetButtonImage(buttonViewRoles, Properties.Resources.icon_role);
            Utils.SetButtonImage(buttonViewFaculties, Properties.Resources.icon_faculty);
            Utils.SetButtonImage(buttonViewUsers, Properties.Resources.icon_users);

            if (webService.UserIs(Utils.GetLoggedInUser().id, "Administrator"))
            {
                buttonViewRequests.Enabled = true;
                buttonViewUsers.Enabled = true;
                buttonViewRoles.Enabled = true;
            }
            else if (webService.UserIs(Utils.GetLoggedInUser().id, "Secretar"))
            {
                buttonViewRequests.Enabled = true;
                buttonViewUsers.Enabled = false;
                buttonViewRoles.Enabled = false;
            }
            else if (webService.UserIs(Utils.GetLoggedInUser().id, "Profesor"))
            {
                buttonViewRequests.Enabled = true;
                buttonViewUsers.Enabled = false;
                buttonViewRoles.Enabled = false;
            }
            else
            {
                buttonViewRequests.Enabled = false;
                buttonViewUsers.Enabled = false;
                buttonViewRoles.Enabled = false;
                toolStripSplitButtonLoggedIn.Visible = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser(this, Utils.GetLoggedInUser().id);
            formEditUser.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.rememberMe = false;
            Properties.Settings.Default.loggedInUserId = 0;
            Properties.Settings.Default.Save();

            FormLogin parent = (FormLogin)Owner;

            if (parent != null)
            {
                parent.Show();
            }
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }

            this.Hide();
        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            FormViewCourses formViewCourses = new FormViewCourses();
            formViewCourses.Show(this);
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
            FormViewFaculties formViewFaculties = new FormViewFaculties();
            formViewFaculties.Show(this);
            this.Hide();
        }

        private void buttonViewDomains_Click(object sender, EventArgs e)
        {
            FormViewDomains formViewDomains = new FormViewDomains();
            formViewDomains.Show(this);
            this.Hide();
        }

        private void buttonViewSpecializations_Click(object sender, EventArgs e)
        {
            FormViewSpecializations formViewSpecializations = new FormViewSpecializations();
            formViewSpecializations.Show(this);
            this.Hide();
        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            FormViewUsers formViewUsers = new FormViewUsers();
            formViewUsers.Show(this);
            this.Hide();
        }

        private void buttonViewRoles_Click(object sender, EventArgs e)
        {
            FormViewRoles formViewRoles = new FormViewRoles();
            formViewRoles.Show(this);
            this.Hide();
        }

        private void FormDashboard_VisibleChanged(object sender, EventArgs e)
        {
            toolStripSplitButtonLoggedIn.Text = String.Format("Conectat ca {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
            toolStripSplitButtonLoggedIn.ToolTipText = String.Format("Conectat ca {0} ({1})", Utils.GetLoggedInUser().name, Utils.GetLoggedInUser().email);
        }
    }
}
