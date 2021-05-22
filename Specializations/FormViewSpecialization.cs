using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect.Specializations
{
    public partial class FormViewSpecialization : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewSpecializations parent;
        private Specialization specialization;
        private Domain domain;
        private Faculty faculty;
        private DataTable dataTable = new DataTable();
        private int id;
        private string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormViewSpecialization()
        {
            InitializeComponent();
        }

        public FormViewSpecialization(FormViewSpecializations parent, int id)
        {
            InitializeComponent();
            this.id = id;
            this.parent = parent;

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataGridView.DataSource = dataTable;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonEditSpecialization_Click(object sender, EventArgs e)
        {
            FormEditSpecialization formEditSpecialization = new FormEditSpecialization(this, specialization.id);
            formEditSpecialization.Show();
            this.Hide();
        }

        private void toolStripButtonDeleteSpecialization_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi această specializare?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteSpecialization(specialization.id);
                MessageBox.Show("Specializarea a fost ștearsă cu succes!");
                this.Close();
            }
        }

        private void FormViewSpecialization_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void FormViewSpecialization_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void UpdateData()
        {
            specialization = webService.GetSpecialization(id);
            domain = webService.GetDomain(specialization.domain_id);
            faculty = webService.GetFaculty(domain.faculty_id);

            labelSpecializationName.Text = specialization.name;
            labelFacultyDomainName.Text = String.Format("{0} • {1}", faculty.name, domain.name);
            if (faculty.logo != "")
            {
                pictureBoxFacultyLogo.ImageLocation = path + "\\Logos\\" + faculty.logo;
            }

            dataTable.Clear();

            webService.GetCourses().ToList().ForEach((course) =>
            {
                if (course.specialization_id == specialization.id)
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["ID"] = course.id;
                    newRow["Nume"] = course.name;

                    dataTable.Rows.Add(newRow);
                }
            });

            this.Text = String.Format("Vizualizare specializare • {0}", specialization.name);
        }
    }
}
