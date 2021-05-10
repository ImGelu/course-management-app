using Proiect.CoursesWebServiceReference;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewUsers : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();

        public FormViewUsers()
        {
            InitializeComponent();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Rolul principal", typeof(string));
            dataGridViewUsers.DataSource = dataTable;
            dataGridViewUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
            viewBtn.UseColumnTextForButtonValue = true;
            viewBtn.Text = "Vizualizare";
            viewBtn.Name = "Vizualizare";
            dataGridViewUsers.Columns.Add(viewBtn);

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Text = "Editează";
            editBtn.Name = "Editează";
            dataGridViewUsers.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Text = "Șterge";
            deleteBtn.Name = "Șterge";
            dataGridViewUsers.Columns.Add(deleteBtn);
        }

        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
            labelNotFound.Visible = false;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {
            FormCreateUser newForm = new FormCreateUser();
            newForm.Show(this);
            this.Hide();
        }

        private async void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = toolStripTextBoxSearch.Text;

            ToolStripTextBox tb = (ToolStripTextBox)sender;
            int startLength = tb.Text.Length;

            await Task.Delay(1000);

            if (startLength == tb.Text.Length && tb.Text.Length > 0)
            {
                try
                {
                    var results = webService.GetUsersByName(searchValue);

                    dataTable.Rows.Clear();

                    results.ToList().ForEach((result) =>
                    {
                        //Role role = webService.GetRole(result.specialization_id);
                        DataRow newRow = dataTable.NewRow();
                        newRow["ID"] = result.id;
                        newRow["Nume"] = result.name;
                        newRow["Email"] = result.email;

                        dataTable.Rows.Add(newRow);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormViewUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormViewUsers_VisibleChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["ID"].Value);

            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Vizualizare")
            {
                FormViewUser formViewUser = new FormViewUser(userId);
                formViewUser.Show();
            }
            else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Șterge")
            {
                if (MessageBox.Show("Ești sigur că vrei să ștergi acest utilizator?\n\nAcțiunea este ireversibilă.", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    webService.DeleteUser(userId);
                    dataGridViewUsers.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Editează")
            {
                FormEditUser formEditUser = new FormEditUser(userId);
                formEditUser.Show();
            }
        }

        private void updateDataGridView()
        {
            dataTable.Clear();

            webService.GetUsers().ToList().ForEach((user) =>
            {
                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = user.id;
                newRow["Nume"] = user.name;
                newRow["Email"] = user.email;

                dataTable.Rows.Add(newRow);
            });
        }
    }
}
