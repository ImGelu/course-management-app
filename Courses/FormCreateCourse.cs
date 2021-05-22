using System;
using Proiect.CoursesWebServiceReference;
using System.Windows.Forms;
using System.Linq;

namespace Proiect
{
    public partial class FormCreateCourse : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewCourses parent = new FormViewCourses();
        private Faculty selectedFaculty;
        private Domain selectedDomain;
        private Specialization selectedSpecialization;

        public FormCreateCourse()
        {
            InitializeComponent();
            comboBoxSemester.Items.Add("Semestrul 1");
            comboBoxSemester.Items.Add("Semestrul 2");
            comboBoxStudyLevel.Items.Add("Licență");
            comboBoxSemester.Items.Add("Master");
            comboBoxYear.Items.Add("Anul 1");
            comboBoxYear.Items.Add("Anul 2");
            comboBoxYear.Items.Add("Anul 3");
            comboBoxYear.Items.Add("Anul 4");
            comboBoxYear.Items.Add("Anul 5");
            comboBoxYear.Items.Add("Anul 6");
        }

        private void FormCreateCourse_Load(object sender, EventArgs e)
        {
            parent = (FormViewCourses)Owner;

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
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course();

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
                MessageBox.Show("Materia a fost adăugată cu succes!");
                this.Close();
                parent.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCourseTutors_Click(object sender, EventArgs e)
        {
            if (textBoxCourseTutors.Text != String.Empty)
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
                if (selectedIndex > -1) listBoxCourseTutors.Items.RemoveAt(selectedIndex);
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

        private void FormCreateCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
