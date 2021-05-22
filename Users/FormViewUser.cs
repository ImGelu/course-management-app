using System;
using System.Linq;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;

namespace Proiect
{
    public partial class FormViewUser : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewUsers parent;
        private User user;
        private int id;

        public FormViewUser()
        {
            InitializeComponent();
        }

        public FormViewUser(FormViewUsers parent, int id)
        {
            this.parent = parent;
            InitializeComponent();
            this.id = id;
        }

        private void toolStripButtonEditUser_Click(object sender, EventArgs e)
        {
            FormEditUser newForm = new FormEditUser(this, user.id);
            newForm.Show(this);
            this.Hide();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormViewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormViewUser_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            user = webService.GetUser(id);
            textBoxName.Text = user.name;
            textBoxEmail.Text = user.email;
            listBoxRoles.ValueMember = "name";

            this.Text = String.Format("Vizualizare utilizator • {0}", user.name);

            listBoxRoles.Items.Clear();

            webService.GetUserRoles(user.id).ToList().ForEach((userRole) =>
            {
                listBoxRoles.Items.Add(userRole);
            });
        }
    }
}
