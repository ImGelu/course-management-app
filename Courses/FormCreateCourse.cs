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
    public partial class FormCreateCourse : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormDashboard parent;
        public FormCreateCourse()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Anulare
        {
            this.Close();
            parent.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Adaugare
        {
            CoursesWebServiceReference.Course newCourse = new CoursesWebServiceReference.Course();

            if (textBoxNume.Text != String.Empty && textBoxCredite.Text != String.Empty && textBoxProfProj.Text != String.Empty && textBoxProfLab.Text != String.Empty && textBoxProfSemi.Text != String.Empty && textBoxHSemi.Text != String.Empty && textBoxHProj.Text != String.Empty && textBoxHLab.Text != String.Empty && textBoxHCurs.Text != String.Empty && !comboBoxAn.SelectedItem.Equals(String.Empty) && !comboBoxSemestru.SelectedItem.Equals(String.Empty) && !comboBoxNivelStudiu.SelectedItem.Equals(String.Empty))
            {
                newCourse.name = textBoxNume.Text;
                newCourse.semester = byte.Parse(comboBoxSemestru.SelectedText);
                newCourse.study_year = byte.Parse(comboBoxAn.SelectedText);
                newCourse.study_level = byte.Parse(comboBoxNivelStudiu.SelectedText);
                newCourse.credits = byte.Parse(textBoxCredite.Text);
                newCourse.course_hours = int.Parse(textBoxHCurs.Text);
                newCourse.laboratory_hours = int.Parse(textBoxHLab.Text);
                newCourse.laboratory_tutors = textBoxProfLab.Text;
                newCourse.seminary_hours = int.Parse(textBoxHSemi.Text);
                newCourse.seminary_tutors = textBoxProfSemi.Text;
                newCourse.project_hours = int.Parse(textBoxHProj.Text);
                newCourse.project_tutors = textBoxProfProj.Text;
                try
                {
                    webService.AddCourse(newCourse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured!\n" + ex.Message.ToString());
                }

                MessageBox.Show("Cursul a fost creeat cu succes!");
                this.Close();
                parent.Show();
            }
            else
            {
                MessageBox.Show("Campurile trebuie completate!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Cautare
        {

        }

    }
}
