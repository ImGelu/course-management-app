using Proiect.CoursesWebServiceReference;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect.Faculties
{
    public partial class FormCreateFaculty : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewFaculties parent;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormCreateFaculty()
        {
            InitializeComponent();
            openFileDialog.Filter = "Imagini (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            openFileDialog.Multiselect = false;
        }

        private void FormCreateFaculty_Load(object sender, EventArgs e)
        {
            parent = (FormViewFaculties)Owner;
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

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonCreateFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                Faculty newFaculty = new Faculty();
                string filename = openFileDialog.FileName != null ? System.IO.Path.GetFileName(openFileDialog.FileName) : null;

                if (filename != null)
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                    if (pictureBoxLogo.Tag != null)
                    {
                        System.IO.File.Copy(openFileDialog.FileName, pictureBoxLogo.Tag.ToString());
                        newFaculty.logo = System.IO.Path.GetFileName(pictureBoxLogo.Tag.ToString());
                    }
                    else
                    {
                        newFaculty.logo = "";
                    }
                    if (textBoxName.Text != String.Empty && textBoxWebsite.Text != String.Empty)
                    {

                        if (Utils.IsValidURL(textBoxWebsite.Text))
                        {
                            newFaculty.name = textBoxName.Text;
                            newFaculty.website = textBoxWebsite.Text;

                            webService.AddFaculty(newFaculty);

                            MessageBox.Show("Facultatea a fost adăugată cu succes!");

                            this.Close();
                            parent.Show();
                        }
                        else MessageBox.Show("Adresa website nu este una validă!");
                    }
                    else MessageBox.Show("Toate câmpurile sunt obligatorii!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonDeleteLogo_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            pictureBoxLogo.Image = null;
        }
    }
}
