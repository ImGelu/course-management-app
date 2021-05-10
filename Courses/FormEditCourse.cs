using System;
using Proiect.CoursesWebServiceReference;
using System.Windows.Forms;
using System.Linq;

namespace Proiect
{
    public partial class FormEditCourse : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private Course course;
        private Faculty selectedFaculty;
        private Domain selectedDomain;
        private Specialization selectedSpecialization;

        public FormEditCourse()
        {
            InitializeComponent();
        }
        public FormEditCourse(int id)
        {
            InitializeComponent();
            course = webService.GetCourse(id);
        }

        private void FormEditCourse_Load(object sender, EventArgs e)
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

            for(int i = 0; i < comboBoxFaculty.Items.Count; i++)
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

            if(course.seminary_tutors.Length > 0)
                course.seminary_tutors.Split(',').ToList().ForEach((tutor) => { listBoxSeminaryTutors.Items.Add(tutor.ToString()); });

            if (course.laboratory_tutors.Length > 0)
                course.laboratory_tutors.Split(',').ToList().ForEach((tutor) => { listBoxLabTutors.Items.Add(tutor.ToString()); });

            if (course.project_tutors.Length > 0)
                course.project_tutors.Split(',').ToList().ForEach((tutor) => { listBoxProjectTutors.Items.Add(tutor.ToString()); });

            richTextBox.Text = course.content;
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course();

            newCourse.id = course.id;
            newCourse.name = textBoxName.Text;
            newCourse.study_year = (byte)(comboBoxYear.SelectedIndex + 1);
            newCourse.semester = (byte)(comboBoxSemester.SelectedIndex + 1);
            newCourse.study_level = (byte)(comboBoxStudyLevel.SelectedIndex + 1);
            newCourse.credits = Convert.ToByte(textBoxCredits.Text);
            newCourse.specialization_id = selectedSpecialization.id;
            newCourse.content = richTextBox.Text;

            newCourse.course_hours = Convert.ToByte(textBoxCourseHours.Text);
            newCourse.seminary_hours = Convert.ToByte(textBoxSeminaryHours.Text);
            newCourse.laboratory_hours = Convert.ToByte(textBoxLabHours.Text);
            newCourse.project_hours = Convert.ToByte(textBoxProjectHours.Text);

            newCourse.seminary_tutors = string.Join(",", listBoxSeminaryTutors.Items.Cast<String>().ToList());
            newCourse.laboratory_tutors = string.Join(",", listBoxLabTutors.Items.Cast<String>().ToList());
            newCourse.project_tutors = string.Join(",", listBoxProjectTutors.Items.Cast<String>().ToList());

            try
            {
                webService.EditCourse(newCourse);
                MessageBox.Show("Salvările au fost efectuate cu succes!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCourseTutors_Click(object sender, EventArgs e)
        {
            if(textBoxCourseTutors.Text != String.Empty)
            {
                listBoxCourseTutors.Items.Add(textBoxCourseTutors.Text);
                textBoxCourseTutors.Clear();
            }
        }

        private void buttonLabTutors_Click(object sender, EventArgs e)
        {
            if (textBoxLabTutors.Text != String.Empty)
            {
                listBoxLabTutors.Items.Add(textBoxLabTutors.Text);
                textBoxLabTutors.Clear();
            }
        }

        private void buttonSeminaryTutors_Click(object sender, EventArgs e)
        {
            if (textBoxSeminaryTutors.Text != String.Empty)
            {
                listBoxSeminaryTutors.Items.Add(textBoxSeminaryTutors.Text);
                textBoxSeminaryTutors.Clear();
            }
        }

        private void buttonProjectTutors_Click(object sender, EventArgs e)
        {
            if (textBoxProjectTutors.Text != String.Empty)
            {
                listBoxProjectTutors.Items.Add(textBoxProjectTutors.Text);
                textBoxProjectTutors.Clear();
            }
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

        private void listBoxCourseTutors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                int selectedIndex = listBoxCourseTutors.SelectedIndex;

                e.Handled = true;
                if(selectedIndex > -1) listBoxCourseTutors.Items.RemoveAt(selectedIndex);
            }
        }

        private void listBoxSeminaryTutors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                int selectedIndex = listBoxSeminaryTutors.SelectedIndex;

                e.Handled = true;
                if (selectedIndex > -1) listBoxSeminaryTutors.Items.RemoveAt(selectedIndex);
            }
        }

        private void listBoxLabTutors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                int selectedIndex = listBoxLabTutors.SelectedIndex;

                e.Handled = true;
                if (selectedIndex > -1) listBoxLabTutors.Items.RemoveAt(selectedIndex);
            }
        }

        private void listBoxProjectTutors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                int selectedIndex = listBoxProjectTutors.SelectedIndex;

                e.Handled = true;
                if (selectedIndex > -1) listBoxProjectTutors.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
