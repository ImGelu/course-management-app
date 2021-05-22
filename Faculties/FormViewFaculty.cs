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
    public partial class FormViewFaculty : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewFaculties parent;
        private Faculty faculty;
        private DataTable dataTable = new DataTable();
        private int id;
        private string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormViewFaculty()
        {
            InitializeComponent();
        }

        public FormViewFaculty(FormViewFaculties parent, int id)
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

        private void linkLabelFacultyWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelFacultyWebsite.Text);
        }

        private void toolStripButtonEditFaculty_Click(object sender, EventArgs e)
        {
            FormEditFaculty formEditFaculty = new FormEditFaculty(this, faculty.id);
            formEditFaculty.Show();
            this.Hide();
        }

        private void FormViewFaculty_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void toolStripButtonDeleteFaculty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi această facultate?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteFaculty(faculty.id);
                MessageBox.Show("Facultatea a fost ștearsă cu succes!");
                this.Close();
            }
        }

        private void FormViewFaculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void UpdateData()
        {
            if (webService.UserIs(Utils.GetLoggedInUser().id, "Administrator") || webService.UserIs(Utils.GetLoggedInUser().id, "Secretar"))
            {
                toolStripSeparator1.Visible = true;
                toolStripButtonEditFaculty.Visible = true;
                toolStripButtonDeleteFaculty.Visible = true;
            }
            else
            {
                toolStripSeparator1.Visible = false;
                toolStripButtonEditFaculty.Visible = false;
                toolStripButtonDeleteFaculty.Visible = false;
            }

            faculty = webService.GetFaculty(id);

            labelFacultyName.Text = faculty.name;
            linkLabelFacultyWebsite.Text = faculty.website;
            if (faculty.logo != "")
            {
                pictureBoxFacultyLogo.ImageLocation = path + "\\Logos\\" + faculty.logo;
            }

            dataTable.Clear();

            webService.GetDomains().ToList().ForEach((domain) =>
            {
                if (domain.faculty_id == faculty.id)
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["ID"] = domain.id;
                    newRow["Nume"] = domain.name;

                    dataTable.Rows.Add(newRow);
                }
            });

            this.Text = String.Format("Vizualizare facultate • {0}", faculty.name);
        }
    }
}
