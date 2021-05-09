using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewUser : Form
    {
        private FormViewUsers parent;
        private int id;
        private string name;
        private string email;
        private string pass;
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        public FormViewUser()
        {
            InitializeComponent();
        }
        public FormViewUser(int id, string name, string email, string pass)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.email = email;
            this.pass = pass;
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxPassword.Text = pass;
            textBoxPasswordConfirmation.Text = pass;

        }
        private void FormViewUser_Load(object sender, EventArgs e)
        {
            parent = (FormViewUsers)Owner;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonEditUser_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            FormEditUser newForm = new FormEditUser(user.id, user.name, user.email, user.password);

            newForm.Show(this);
            this.Hide();
        }

        private void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            if (MessageBox.Show("Are you sure tou want to delete thi user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteUser(user.id);
                MessageBox.Show("Utilizatorul a fost sters cu succes!");
                parent.Show();
                this.Hide();
            }
            

        }
    }
}
