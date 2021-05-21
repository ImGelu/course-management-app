using Proiect.CoursesWebServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        private string[] statusList = { "În așteptare", "Aprobată", "Respinsă" };

        public FormViewRequests()
        {
            InitializeComponent();

            dataTable.Columns.Add("id_user", typeof(int));
            dataTable.Columns.Add("id_course", typeof(int));

            dataTable.Columns.Add("Profesor", typeof(string));
            dataTable.Columns.Add("Materie", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            dataGridViewRequests.DataSource = dataTable;
            dataGridViewRequests.Columns[0].Visible = false;
            dataGridViewRequests.Columns[1].Visible = false;
            dataGridViewRequests.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
            viewBtn.UseColumnTextForButtonValue = true;
            viewBtn.Text = "Aprobă";
            viewBtn.Name = "Aprobare cerere";
            dataGridViewRequests.Columns.Add(viewBtn);

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Text = "Respinge";
            editBtn.Name = "Respingere cerere";
            dataGridViewRequests.Columns.Add(editBtn);
        }

        private void FormViewRequests_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void dataGridViewRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int courseId = Convert.ToInt32(dataGridViewRequests.Rows[e.RowIndex].Cells["id_course"].Value);
                int userId = Convert.ToInt32(dataGridViewRequests.Rows[e.RowIndex].Cells["id_user"].Value);

                if (e.ColumnIndex > -1 && dataGridViewRequests.Columns[e.ColumnIndex].Name == "Aprobare cerere")
                {
                    if (MessageBox.Show("Ești sigur că vrei să aprobi această cerere?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        webService.SetCourseRedemptionStatus(courseId, userId, 1);
                        updateDataGridView();
                    }
                }
                else if (e.ColumnIndex > -1 && dataGridViewRequests.Columns[e.ColumnIndex].Name == "Respingere cerere")
                {
                    if (MessageBox.Show("Ești sigur că vrei să respingi această cerere?", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        webService.SetCourseRedemptionStatus(courseId, userId, 2);
                        updateDataGridView();
                    }
                }
            }
        }

        private void FormViewRequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormViewRequests_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                updateDataGridView();
            }
        }

        private void updateDataGridView()
        {
            var results = webService.GetRequests();

            dataTable.Rows.Clear();

            results.ToList().ForEach((result) =>
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id_user"] = result.id_user;
                newRow["id_course"] = result.id_course;
                newRow["Profesor"] = webService.GetUser(result.id_user).name;
                newRow["Materie"] = webService.GetCourse(result.id_course).name;
                newRow["Status"] = statusList.GetValue(result.status);

                dataTable.Rows.Add(newRow);
            });

            foreach(DataGridViewRow row in dataGridViewRequests.Rows)
            {
                if ((string)row.Cells[6].Value == "Aprobată") row.Cells[6].Style.BackColor = Color.LightGreen;
                else if ((string)row.Cells[6].Value == "Respinsă") row.Cells[6].Style.BackColor = Color.Red;
                else row.Cells[6].Style.BackColor = Color.Orange;
            }
        }
    }

}
