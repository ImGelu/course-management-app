using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewUser : Form
    {
        private FormViewUsers parent;

        public FormViewUser()
        {
            InitializeComponent();
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

        }

        private void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
