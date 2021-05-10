using System;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;

namespace Proiect
{
    public partial class FormViewUser : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewUsers parent;
        private User user;

        public FormViewUser()
        {
            InitializeComponent();
        }

        public FormViewUser(int id)
        {
            InitializeComponent();
            user = webService.GetUser(id);
        }

        private void FormViewUser_Load(object sender, EventArgs e)
        {
            parent = new FormViewUsers();
            textBoxName.Text = user.name;
            textBoxEmail.Text = user.email;
        }

        private void toolStripButtonEditUser_Click(object sender, EventArgs e)
        {
            FormEditUser newForm = new FormEditUser(user.id);
            newForm.Show(this);
            this.Hide();
        }

        private void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi acest utilizator?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteUser(user.id);
                MessageBox.Show("Utilizatorul a fost șters cu succes!");
                parent.Show();
                this.Close();
            }  
        }
    }
}
