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

namespace Proiect.Roles
{
    public partial class FormViewRoles : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();

        public FormViewRoles()
        {
            InitializeComponent();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataGridViewRoles.DataSource = dataTable;
            dataGridViewRoles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Text = "Editează";
            editBtn.Name = "Editează";
            dataGridViewRoles.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Text = "Șterge";
            deleteBtn.Name = "Șterge";
            dataGridViewRoles.Columns.Add(deleteBtn);
        }

        private void FormViewRoles_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
            labelNotFound.Visible = false;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonAddRole_Click(object sender, EventArgs e)
        {
            FormCreateRole newForm = new FormCreateRole();
            newForm.Show(this);
            this.Hide();
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
                    var results = webService.GetRolesByName(searchValue);

                    dataTable.Rows.Clear();

                    results.ToList().ForEach((result) =>
                    {
                        DataRow newRow = dataTable.NewRow();
                        newRow["ID"] = result.id;
                        newRow["Nume"] = result.name;

                        dataTable.Rows.Add(newRow);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormViewRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormViewRoles_VisibleChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int roleId = Convert.ToInt32(dataGridViewRoles.Rows[e.RowIndex].Cells["ID"].Value);

                if (e.ColumnIndex > -1 && dataGridViewRoles.Columns[e.ColumnIndex].Name == "Șterge")
                {
                    if (MessageBox.Show("Ești sigur că vrei să ștergi acest rol?\n\nAcțiunea este ireversibilă.", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (webService.GetUsersWithRole(roleId).Length > 0)
                        {
                            MessageBox.Show("Acest rol nu poate fi șters deoarece există utilizatori cu acest rol");
                        }
                        else
                        {
                            webService.DeleteRole(roleId);
                            dataGridViewRoles.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
                else if (e.ColumnIndex > -1 && dataGridViewRoles.Columns[e.ColumnIndex].Name == "Editează")
                {
                    FormEditRole formEdit = new FormEditRole(this, roleId);
                    this.Hide();
                    formEdit.Show();
                }
            }
        }

        private void updateDataGridView()
        {
            dataTable.Clear();

            webService.GetRoles().ToList().ForEach((role) =>
            {
                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = role.id;
                newRow["Nume"] = role.name;

                dataTable.Rows.Add(newRow);
            });
        }
    }
}
