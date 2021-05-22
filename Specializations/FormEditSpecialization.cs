using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect.Specializations
{
    public partial class FormEditSpecialization : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private Specialization specialization;
        private Faculty selectedFaculty;
        private Domain selectedDomain;
        private FormViewSpecialization parent;

        public FormEditSpecialization()
        {
            InitializeComponent();
        }

        public FormEditSpecialization(FormViewSpecialization parent, int id)
        {
            InitializeComponent();
            specialization = webService.GetSpecialization(id);
            this.parent = parent;
        }

        private void FormEditSpecialization_Load(object sender, EventArgs e)
        {
            textBoxName.Text = specialization.name;

            comboBoxFaculty.DataSource = webService.GetFaculties().ToList();
            comboBoxFaculty.DisplayMember = "name";

            comboBoxDomain.DataSource = webService.GetDomains().Where(domain => domain.faculty_id == selectedFaculty.id).ToList();
            comboBoxDomain.DisplayMember = "name";

            Domain specializationDomain = webService.GetDomain(specialization.domain_id);
            Faculty specializationFaculty = webService.GetFaculty(specializationDomain.faculty_id);

            comboBoxFaculty.SelectedItem = specializationFaculty;
            comboBoxDomain.SelectedItem = specializationDomain;

            for (int i = 0; i < comboBoxFaculty.Items.Count; i++)
            {
                Faculty currentFaculty = (Faculty)comboBoxFaculty.Items[i];
                if (currentFaculty.id == specializationFaculty.id) comboBoxFaculty.SelectedIndex = i;
            }

            for (int i = 0; i < comboBoxDomain.Items.Count; i++)
            {
                Domain currentDomain = (Domain)comboBoxDomain.Items[i];
                if (currentDomain.id == specializationDomain.id) comboBoxDomain.SelectedIndex = i;
            }

            this.Text = String.Format("Editare specializare • {0}", specialization.name);
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFaculty = (Faculty)comboBoxFaculty.SelectedItem;

            comboBoxDomain.DataSource = webService.GetDomains().Where(domain => domain.faculty_id == selectedFaculty.id).ToList();
        }

        private void comboBoxDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDomain = (Domain)comboBoxDomain.SelectedItem;
        }

        private void buttonEditSpecialization_Click(object sender, EventArgs e)
        {
            try
            {
                Specialization newSpecialization = new Specialization();

                newSpecialization.id = specialization.id;
                newSpecialization.name = textBoxName.Text;
                newSpecialization.domain_id = selectedDomain.id;

                if (textBoxName.Text != String.Empty && comboBoxFaculty.SelectedItem != null && comboBoxDomain.SelectedItem != null)
                {
                    webService.EditSpecialization(newSpecialization);

                    MessageBox.Show("Specializarea a fost actualizată cu succes!");

                    this.Close();
                    parent.Show();
                }
                else MessageBox.Show("Toate câmpurile sunt obligatorii!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormEditSpecialization_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
