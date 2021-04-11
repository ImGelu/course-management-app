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
    public partial class FormLogin : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoursesWebServiceReference.User newUser = new CoursesWebServiceReference.User();
            newUser.name = textBox1.Text;
            newUser.email = textBox2.Text;
            newUser.password = textBox3.Text;

            webService.AddUser(newUser);
        }
    }
}
