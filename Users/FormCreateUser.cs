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
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != String.Empty && textBoxName.Text != String.Empty && !comboBoxRole.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                this.Close();
            }
            else MessageBox.Show("Campurile trebuie completate!");

        }
    }
}
