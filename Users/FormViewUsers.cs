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
    public partial class FormViewUsers : Form
    {
        
        public FormViewUsers()
        {
            InitializeComponent();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateUser newForm = new FormCreateUser();
            newForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditUser newForm = new FormEditUser();
            newForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizatorul a fost sters cu succes!");
        }

        private void Check_Click(object sender, EventArgs e)
        {
            FormViewUser newForm = new FormViewUser();
            newForm.Show();
        }
    }
}
