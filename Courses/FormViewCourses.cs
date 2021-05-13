﻿using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewCourses : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();

        public FormViewCourses()
        {
            InitializeComponent();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Materie", typeof(string));
            dataTable.Columns.Add("Facultate", typeof(string));
            dataTable.Columns.Add("Domeniu", typeof(string));
            dataTable.Columns.Add("Specializare", typeof(string));
            dataGridViewCourses.DataSource = dataTable;
            dataGridViewCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
            viewBtn.UseColumnTextForButtonValue = true;
            viewBtn.Text = "Vizualizare";
            viewBtn.Name = "Vizualizare";
            dataGridViewCourses.Columns.Add(viewBtn);

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Text = "Editează";
            editBtn.Name = "Editează";
            dataGridViewCourses.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Text = "Șterge";
            deleteBtn.Name = "Șterge";
            dataGridViewCourses.Columns.Add(deleteBtn);
        }

        private void FormViewCourses_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
            labelNotFound.Visible = false;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private async void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = toolStripTextBoxSearch.Text;

            ToolStripTextBox tb = (ToolStripTextBox)sender;
            int startLength = tb.Text.Length;

            await Task.Delay(1000);

            if (startLength == tb.Text.Length && tb.Text.Length > 2)
            {
                try
                {
                    var results = webService.GetCourseByName(searchValue);

                    dataTable.Rows.Clear();

                    results.ToList().ForEach((result) =>
                    {
                        Specialization specialization = webService.GetSpecialization(result.specialization_id);
                        Domain domain = webService.GetDomain(specialization.domain_id);
                        Faculty faculty = webService.GetFaculty(domain.faculty_id);
                        DataRow newRow = dataTable.NewRow();
                        newRow["ID"] = result.id;
                        newRow["Materie"] = result.name;
                        newRow["Specializare"] = specialization.name;
                        newRow["Domeniu"] = domain.name;
                        newRow["Facultate"] = faculty.name;

                        dataTable.Rows.Add(newRow);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewCourses.CurrentCell.RowIndex;
            string nume = dataGridViewCourses.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int courseId = Convert.ToInt32(dataGridViewCourses.Rows[e.RowIndex].Cells["ID"].Value);

            if (dataGridViewCourses.Columns[e.ColumnIndex].Name == "Vizualizare")
            {
                FormViewCourse formViewCourse = new FormViewCourse(courseId);
                formViewCourse.Show();
            }
            else if (dataGridViewCourses.Columns[e.ColumnIndex].Name == "Șterge")
            {
                if (MessageBox.Show("Ești sigur că vrei să ștergi acest curs?\n\nAcțiunea este ireversibilă.", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    webService.DeleteCourse(courseId);
                    dataGridViewCourses.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (dataGridViewCourses.Columns[e.ColumnIndex].Name == "Editează")
            {
                FormEditCourse formEditCourse = new FormEditCourse(courseId);
                formEditCourse.Show();
            }
        }
    }
}
