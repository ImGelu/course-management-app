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
    public partial class Adaugare_materie : Form
    {
        public Adaugare_materie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Anulare
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // Adaugare
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Câmpurile trebuie completate!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Cautare
        {

        }
    }
}
