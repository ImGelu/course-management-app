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

namespace Proiect.Domains
{
    public partial class FormEditDomain : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewDomain parent;
        private Domain domain;
        private int id;

        public FormEditDomain()
        {
            InitializeComponent();
        }

        public FormEditDomain(FormViewDomain parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
        }

        private void FormEditDomain_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonEditDomain_Click(object sender, EventArgs e)
        {
            try
            {
                Domain existingDomain = new Domain();

                existingDomain.id = domain.id;
                existingDomain.name = textBoxName.Text;

                Faculty selectedFaculty = (Faculty)comboBoxFaculty.SelectedItem;

                existingDomain.faculty_id = selectedFaculty.id;

                if (textBoxName.Text != String.Empty && comboBoxFaculty.SelectedItem != null)
                {
                    webService.EditDomain(existingDomain);

                    MessageBox.Show("Domeniul a fost editat cu succes!");

                    this.Close();
                    parent.Show();
                }
                else MessageBox.Show("Please fill all the fields to continue!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormEditDomain_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormEditDomain_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                UpdateData();
            }
        }

        private void UpdateData()
        {
            domain = webService.GetDomain(id);

            textBoxName.Text = domain.name;

            comboBoxFaculty.DataSource = webService.GetFaculties().ToList();
            comboBoxFaculty.DisplayMember = "name";

            for (int i = 0; i < comboBoxFaculty.Items.Count; i++)
            {
                Faculty currentFaculty = (Faculty)comboBoxFaculty.Items[i];
                if (currentFaculty.id == domain.faculty_id) comboBoxFaculty.SelectedIndex = i;
            }

            this.Text = String.Format("Editare domeniu • {0}", domain.name);
        }
    }
}
