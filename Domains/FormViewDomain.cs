using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect.Domains
{
    public partial class FormViewDomain : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewDomains parent;
        private Domain domain;
        private Faculty faculty;
        private DataTable dataTable = new DataTable();
        private int id;
        private string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormViewDomain()
        {
            InitializeComponent();
        }

        public FormViewDomain(FormViewDomains parent, int id)
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

        private void toolStripButtonEditDomain_Click(object sender, EventArgs e)
        {
            FormEditDomain formEditDomain = new FormEditDomain(this, domain.id);
            formEditDomain.Show();
            this.Hide();
        }

        private void toolStripButtonDeleteDomain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să ștergi acest domeniu?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                webService.DeleteDomain(domain.id);
                MessageBox.Show("Domeniul a fost șters cu succes!");
                this.Close();
            }
        }

        private void FormViewDomain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void FormViewDomain_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void UpdateData()
        {
            domain = webService.GetDomain(id);
            faculty = webService.GetFaculty(domain.faculty_id);

            labelDomainName.Text = domain.name;
            labelFacultyName.Text = faculty.name;
            if (faculty.logo != "")
            {
                pictureBoxFacultyLogo.ImageLocation = path + "\\Logos\\" + faculty.logo;
            }

            dataTable.Clear();

            webService.GetSpecializations().ToList().ForEach((specialization) =>
            {
                if (specialization.domain_id == domain.id)
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["ID"] = specialization.id;
                    newRow["Nume"] = specialization.name;

                    dataTable.Rows.Add(newRow);
                }
            });

            this.Text = String.Format("Vizualizare domeniu • {0}", domain.name);
        }
    }
}
