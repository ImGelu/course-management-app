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
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();
        public FormViewCourses()
        {
            InitializeComponent();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Materie", typeof(string));
            dataTable.Columns.Add("Facultate", typeof(string));
            dataTable.Columns.Add("Domeniu", typeof(string));
            dataTable.Columns.Add("Specializare", typeof(string));
            dataGridViewCourses.DataSource = dataTable;
            dataGridViewCourses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)  // Cautare
        {
            string materie = textBox1.Text;
            dataTable.Clear();

            for (int i = 0; i < webService.GetCourseByName(materie).Length; i++)
            {
                dataTable.Rows.Add(webService.GetCourseByName(materie)[i].id, webService.GetCourseByName(materie)[i].name, webService.GetCourseByName(materie)[i].Specialization, webService.GetCourseByName(materie)[i].semester);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Anulare
        {
            this.Close();
        }

        private void FormViewCourses_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewCourses.CurrentCell.RowIndex;
            string nume = dataGridViewCourses.Rows[rowIndex].Cells[1].Value.ToString();
           // CoursesWebServiceReference.Course course = webService.GetCourseByName(nume);
           // FormEditCourse newForm = new FormEditCourse(course.id);
            //newForm.Show(this);
            //this.Hide();
        }
    }
}
