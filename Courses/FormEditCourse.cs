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
    public partial class FormEditCourse : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormViewCourse parent;
        private int id;
        public FormEditCourse()
        {
            InitializeComponent();
            comboBoxSemestru.Items.Add("Semestrul 1");
            comboBoxSemestru.Items.Add("Semestrul 2");
            comboBoxNivelStudiu.Items.Add("Licenta");
            comboBoxSemestru.Items.Add("Master");
            comboBoxAn.Items.Add("Anul 1");
            comboBoxAn.Items.Add("Anul 2");
            comboBoxAn.Items.Add("Anul 3");
            comboBoxAn.Items.Add("Anul 4");
            comboBoxAn.Items.Add("Anul 5");
            comboBoxAn.Items.Add("Anul 6");
        }
        public FormEditCourse(int id)
        {
            InitializeComponent();
            this.id = id;
            textBoxID.Text = id.ToString();
        }


        private void Editare_materie_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditare_Click(object sender, EventArgs e) // Editare
        {
            CoursesWebServiceReference.Course course = new CoursesWebServiceReference.Course();

            if (textBoxNume.Text != String.Empty && textBoxCredite.Text != String.Empty && textBoxProfProj.Text != String.Empty && textBoxProfLab.Text != String.Empty && textBoxProfSemi.Text != String.Empty && textBoxHSemi.Text != String.Empty && textBoxHProj.Text != String.Empty && textBoxHLab.Text != String.Empty && textBoxHCurs.Text != String.Empty && !comboBoxAn.SelectedItem.Equals(String.Empty) && !comboBoxSemestru.SelectedItem.Equals(String.Empty) && !comboBoxNivelStudiu.SelectedItem.Equals(String.Empty))
            {
                course.id = id;
                course.name = textBoxNume.Text;
                course.semester = byte.Parse(comboBoxSemestru.SelectedText);
                course.study_year = byte.Parse(comboBoxAn.SelectedText);
                course.study_level = byte.Parse(comboBoxNivelStudiu.SelectedText);
                course.credits = byte.Parse(textBoxCredite.Text);
                course.course_hours = int.Parse(textBoxHCurs.Text);
                course.laboratory_hours = int.Parse(textBoxHLab.Text);
                course.laboratory_tutors = textBoxProfLab.Text;
                course.seminary_hours = int.Parse(textBoxHSemi.Text);
                course.seminary_tutors = textBoxProfSemi.Text;
                course.project_hours = int.Parse(textBoxHProj.Text);
                course.project_tutors = textBoxProfProj.Text;
                

                webService.EditCourse(course);
                MessageBox.Show("Cursul a fost editat cu succes!");
                this.Close();
                parent.Show();
            }
            else
            {
                MessageBox.Show("Campurile trebuie completate!");
            }
        }

        private void buttonAnulare_Click(object sender, EventArgs e)  //Anulare
        {
            this.Close();
            parent.Show();
        }
    }
}
