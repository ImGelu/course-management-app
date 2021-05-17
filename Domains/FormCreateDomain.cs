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
    public partial class FormCreateDomain : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormViewDomains parent;

        public FormCreateDomain()
        {
            InitializeComponent();
        }

        private void FormCreateDomain_Load(object sender, EventArgs e)
        {
            parent = (FormViewDomains)Owner;
            UpdateData();
        }
        
        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            try
            {
                Domain newDomain = new Domain();

                newDomain.name = textBoxName.Text;
                Faculty selectedFaculty = (Faculty)comboBoxFaculty.SelectedItem;
                newDomain.faculty_id = selectedFaculty.id;

                if (textBoxName.Text != String.Empty && comboBoxFaculty.SelectedItem != null)
                {
                    webService.AddDomain(newDomain);

                    MessageBox.Show("Domeniul a fost adăugat cu succes!");

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

        private void FormCreateDomain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData();
            }
        }

        private void FormCreateDomain_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void UpdateData()
        {
            comboBoxFaculty.DataSource = webService.GetFaculties().ToList();
            comboBoxFaculty.DisplayMember = "name";
        }

    }
}
