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
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizatorul a fost editat cu succes!");
            this.Close();
        }
    }
}
