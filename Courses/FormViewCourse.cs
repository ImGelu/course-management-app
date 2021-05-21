using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewCourse : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewCourses parent;
        private Course course;
        private Faculty selectedFaculty;
        private Domain selectedDomain;
        private Specialization selectedSpecialization;
        private int id;

        public FormViewCourse()
        {
            InitializeComponent();
        }

        public FormViewCourse(FormViewCourses parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
        }

        private void FormViewCourse_Load(object sender, EventArgs e)
        {
            comboBoxSemester.Items.Add("Semestrul 1");
            comboBoxSemester.Items.Add("Semestrul 2");
            comboBoxStudyLevel.Items.Add("Licență");
            comboBoxStudyLevel.Items.Add("Master");
            comboBoxYear.Items.Add("Anul 1");
            comboBoxYear.Items.Add("Anul 2");
            comboBoxYear.Items.Add("Anul 3");
            comboBoxYear.Items.Add("Anul 4");
            comboBoxYear.Items.Add("Anul 5");
            comboBoxYear.Items.Add("Anul 6");
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFaculty = (Faculty)comboBoxFaculty.SelectedItem;

            comboBoxDomain.DataSource = webService.GetDomains().Where(domain => domain.faculty_id == selectedFaculty.id).ToList();
            comboBoxSpecialization.DataSource = webService.GetSpecializations().Where(specialization => specialization.domain_id == selectedDomain.id).ToList();
        }

        private void comboBoxDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDomain = (Domain)comboBoxDomain.SelectedItem;
            comboBoxSpecialization.DataSource = webService.GetSpecializations().Where(specialization => specialization.domain_id == selectedDomain.id).ToList();
        }

        private void comboBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSpecialization = (Specialization)comboBoxSpecialization.SelectedItem;
        }

        private void toolStripButtonRedeemCourse_Click(object sender, EventArgs e)
        {
            webService.RedeemCourse(course.id, Utils.GetLoggedInUser().id);
            MessageBox.Show("Cererea a fost trimisa!");
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormViewCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void toolStripButtonEditCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditCourse newForm = new FormEditCourse(this, course.id);
            newForm.Show();
        }

        private void FormViewCourse_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            course = webService.GetCourse(id);

            comboBoxFaculty.DataSource = webService.GetFaculties().ToList();
            comboBoxFaculty.DisplayMember = "name";

            comboBoxDomain.DataSource = webService.GetDomains().Where(domain => domain.faculty_id == selectedFaculty.id).ToList();
            comboBoxDomain.DisplayMember = "name";

            comboBoxSpecialization.DataSource = webService.GetSpecializations().Where(specialization => specialization.domain_id == selectedDomain.id).ToList();
            comboBoxSpecialization.DisplayMember = "name";

            Specialization courseSpecialization = webService.GetSpecialization(course.specialization_id);
            Domain courseDomain = webService.GetDomain(courseSpecialization.domain_id);
            Faculty courseFaculty = webService.GetFaculty(courseDomain.faculty_id);

            comboBoxFaculty.SelectedItem = courseFaculty;
            comboBoxDomain.SelectedItem = courseDomain;
            comboBoxSpecialization.SelectedItem = courseSpecialization;

            for (int i = 0; i < comboBoxFaculty.Items.Count; i++)
            {
                Faculty currentFaculty = (Faculty)comboBoxFaculty.Items[i];
                if (currentFaculty.id == courseFaculty.id) comboBoxFaculty.SelectedIndex = i;
            }

            for (int i = 0; i < comboBoxDomain.Items.Count; i++)
            {
                Domain currentDomain = (Domain)comboBoxDomain.Items[i];
                if (currentDomain.id == courseDomain.id) comboBoxDomain.SelectedIndex = i;
            }

            for (int i = 0; i < comboBoxSpecialization.Items.Count; i++)
            {
                Specialization currentSpecialization = (Specialization)comboBoxSpecialization.Items[i];
                if (currentSpecialization.id == courseSpecialization.id) comboBoxSpecialization.SelectedIndex = i;
            }

            textBoxName.Text = course.name;
            comboBoxYear.SelectedIndex = course.study_level - 1;
            comboBoxSemester.SelectedIndex = course.semester - 1;
            comboBoxStudyLevel.SelectedIndex = course.study_level - 1;
            textBoxCredits.Text = course.credits.ToString();

            textBoxCourseHours.Text = course.course_hours.ToString();

            textBoxSeminaryHours.Text = course.seminary_hours.ToString();
            textBoxLabHours.Text = course.laboratory_hours.ToString();
            textBoxProjectHours.Text = course.project_hours.ToString();

            if (course.seminary_tutors.Length > 0)
                course.seminary_tutors.Split(',').ToList().ForEach((tutor) => { listBoxSeminaryTutors.Items.Add(tutor.ToString()); });

            if (course.laboratory_tutors.Length > 0)
                course.laboratory_tutors.Split(',').ToList().ForEach((tutor) => { listBoxLabTutors.Items.Add(tutor.ToString()); });

            if (course.project_tutors.Length > 0)
                course.project_tutors.Split(',').ToList().ForEach((tutor) => { listBoxProjectTutors.Items.Add(tutor.ToString()); });

            richTextBox.Text = course.content;

            this.Text = String.Format("Vizualizare materie • {0}", course.name);
        }
    }
}
