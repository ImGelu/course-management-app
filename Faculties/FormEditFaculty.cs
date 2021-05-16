using Proiect.CoursesWebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Faculties
{
    public partial class FormEditFaculty : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewFaculty parent;
        private Faculty faculty;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private int id;
        private string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormEditFaculty()
        {
            InitializeComponent();
        }

        public FormEditFaculty(FormViewFaculty parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
        }

        private void FormEditFaculty_Load(object sender, EventArgs e)
        {
            faculty = webService.GetFaculty(id);

            textBoxName.Text = faculty.name;
            textBoxWebsite.Text = faculty.website;
            pictureBoxLogo.ImageLocation = path + "\\Logos\\" + faculty.logo;
            pictureBoxLogo.Tag = path + "\\Logos\\" + faculty.logo;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonEditFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                Faculty existingFaculty = new Faculty();

                string filename = openFileDialog.FileName != null ? System.IO.Path.GetFileName(openFileDialog.FileName) : null;

                if (filename != null)
                {
                    if (openFileDialog.FileName != null && openFileDialog.FileName != "")
                    {
                        System.IO.File.Copy(openFileDialog.FileName, path + "\\Logos\\" + filename);
                        existingFaculty.logo = System.IO.Path.GetFileName(pictureBoxLogo.Tag.ToString());
                    } else
                    {
                        existingFaculty.logo = faculty.logo;
                    }

                    existingFaculty.id = faculty.id;
                    existingFaculty.name = textBoxName.Text;
                    existingFaculty.website = textBoxWebsite.Text;

                    webService.EditFaculty(existingFaculty);

                    MessageBox.Show("Facultatea a fost editată cu succes!");

                    this.Close();
                    parent.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormEditFaculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void buttonChooseLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        pictureBoxLogo.Image = new Bitmap(openFileDialog.FileName);
                        pictureBoxLogo.Tag = path + "\\Logos\\" + openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteLogo_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            pictureBoxLogo.Image = null;

            if (faculty.logo != "" && faculty.logo != null)
            {
                System.IO.File.Delete(path + "\\Logos\\" + faculty.logo);
            }
        }
    }
}
