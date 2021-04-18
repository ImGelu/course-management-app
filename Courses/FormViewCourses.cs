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
    public partial class FormViewCourses : Form
    {
        public FormViewCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Cautare
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Câmpurile trebuie completate!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Anulare
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acțiuni"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("Button on row {0} clicked", e.RowIndex); // DE SCHIMBAT, AM TESTAT
            }
        }
    }
}
