using Proiect.CoursesWebServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewRequests : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();
        int status = 0;

        public FormViewRequests()
        {
            InitializeComponent();
            dataTable.Columns.Add("User", typeof(string));
            dataTable.Columns.Add("Course", typeof(string));

            try
            {
                var results = webService.GetRequests();

                dataTable.Rows.Clear();
                List<String> name = new List<string>();

                results.ToList().ForEach((result) =>
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["User"] = webService.GetUser(result.id_user);
                    newRow["Course"] = webService.GetCourse(result.id_course);

                    dataTable.Rows.Add(newRow);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonAccept_Click(object sender, EventArgs e)
        {
            Courses.Requests.PopupRequests popup = new Courses.Requests.PopupRequests();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Yes)
            {
                status = 1;
                webService.UpdateStatus(status);
            }
            else if (dialogresult == DialogResult.No)
            {
                popup.Dispose();
            }
        }

        private void toolStripButtonDeny_Click(object sender, EventArgs e)
        {
            Courses.Requests.PopupRequests popup = new Courses.Requests.PopupRequests();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Yes)
            {
                status = 2;
                webService.UpdateStatus(status);
            }
            else if (dialogresult == DialogResult.No)
            {
                popup.Dispose();
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void FormViewRequests_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
        }
    }

}
