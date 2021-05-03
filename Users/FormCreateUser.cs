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
    public partial class FormCreateUser : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        public FormCreateUser()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {
                CoursesWebServiceReference.User newUser = new CoursesWebServiceReference.User();

                newUser.name = textBoxName.Text;
                newUser.email = textBoxEmail.Text;
                newUser.password = textBoxPass.Text;


                webService.AddUser(newUser);
                MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                this.Close();
                FormViewUsers newform = new FormViewUsers();
                newform.Show();
            }
            else
            {
              
                MessageBox.Show("Campurile trebuie completate!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
