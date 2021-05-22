using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect.Specializations
{
    public partial class FormCreateSpecialization : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewSpecializations parent = new FormViewSpecializations();
        private Faculty selectedFaculty;
        private Domain selectedDomain;

        public FormCreateSpecialization()
        {
            InitializeComponent();
        }

        private void FormCreateSpecialization_Load(object sender, EventArgs e)
        {
            parent = (FormViewSpecializations)Owner;

            comboBoxFaculty.DataSource = webService.GetFaculties().ToList();
            comboBoxFaculty.DisplayMember = "name";

            comboBoxDomain.DataSource = webService.GetDomains().Where(domain => domain.faculty_id == selectedFaculty.id).ToList();
            comboBoxDomain.DisplayMember = "name";
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

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonAddSpecialization_Click(object sender, EventArgs e)
        {
            try
            {
                Specialization newSpecialization = new Specialization();

                newSpecialization.name = textBoxName.Text;
                newSpecialization.domain_id = selectedDomain.id;

                if (textBoxName.Text != String.Empty && comboBoxFaculty.SelectedItem != null && comboBoxDomain.SelectedItem != null)
                {
                    webService.AddSpecialization(newSpecialization);

                    MessageBox.Show("Specializarea a fost adăugată cu succes!");

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
    }
}
