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
    public partial class Vizualizare_revendicari : Form
    {
        public Vizualizare_revendicari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Aprobare
        {

        }

        private void button2_Click(object sender, EventArgs e) //Respingere
        {

        }

        private void button3_Click(object sender, EventArgs e) //Anulare
        {
            this.Close();
        }
    }
}
