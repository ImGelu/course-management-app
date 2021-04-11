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
    public partial class FormUtilizatori : Form
    {
        
        public FormUtilizatori()
        {
            InitializeComponent();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adaugare newForm = new Adaugare();
            newForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Editare newForm = new Editare();
            newForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizatorul a fost sters cu succes!");
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Vizualizare newForm = new Vizualizare();
            newForm.Show();
        }
    }
}
