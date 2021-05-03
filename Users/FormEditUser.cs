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
    public partial class FormEditUser : Form { 
        public int id;
        public FormEditUser(int id)
    {
            InitializeComponent();
            this.id = id;
    }
    
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            CoursesWebServiceReference.User user = new CoursesWebServiceReference.User();

            if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {

                user.id = id;
                user.name = textBoxName.Text;
                user.email = textBoxEmail.Text;
                user.password = textBoxPass.Text;


                webService.EditUser(user);
                MessageBox.Show("Utilizatorul a fost editat cu succes!");
                this.Close();
                FormViewUsers newform = new FormViewUsers();
                newform.Show();
            }
            else MessageBox.Show("Campurile trebuie completate!");
        }

    }
}
