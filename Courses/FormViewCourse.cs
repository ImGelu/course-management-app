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
    public partial class FormViewCourse : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();

        public FormViewCourse()
        {
            InitializeComponent();
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBoxID.Text);
            CoursesWebServiceReference.Course course = webService.GetCourse(index);
            labelMaterie2.Text = course.name;
            // labelFacultate2.Text = course.
            labelDomeniu2.Text = course.content;
            labelSpecializare2.Text = Convert.ToString(course.Specialization);


        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormViewCourse_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            FormEditCourse formEdit = new FormEditCourse(int.Parse(textBoxID.Text));
            formEdit.Show(this);
            this.Hide();
        }
    }
}
