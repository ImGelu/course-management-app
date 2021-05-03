using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewUsers : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        private FormDashboard parent;
        private DataTable dataTable = new DataTable();

        public FormViewUsers()
        {
            InitializeComponent();
            dataTable.Columns.Add("Nume", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Parolă", typeof(string));
            dataTable.Columns.Add("Rolul principal", typeof(string));
            dataGridViewUsers.DataSource = dataTable;
            dataGridViewUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormCreateUser newForm = new FormCreateUser();
            newForm.Show(this);
            this.Hide();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            FormEditUser newForm = new FormEditUser(user.id);
            newForm.Show(this);
            this.Hide();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);

            webService.DeleteUser(user.id);
            dataGridViewUsers.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Utilizatorul a fost sters cu succes!");
        }

        private void buttonViewUser_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);

            FormViewUser newForm = new FormViewUser();
            newForm.dataGridViewVizualizare.Rows.Add();
            newForm.dataGridViewVizualizare.Rows[0].Cells[0].Value = user.name;
            newForm.dataGridViewVizualizare.Rows[0].Cells[1].Value = user.email;
            newForm.dataGridViewVizualizare.Rows[0].Cells[2].Value = user.password;
            newForm.Show();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = toolStripTextBoxSearch.Text;

            try
            {
                var results = from row in dataTable.AsEnumerable()
                              where row[1].ToString().Contains(searchValue)
                              select row;

                if (results.Count() == 0)
                {
                    MessageBox.Show("No row");
                }
                else
                {
                    dataGridViewUsers.DataSource = results.CopyToDataTable();
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

        private void FormViewUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormViewUsers_VisibleChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void updateDataGridView()
        {
            dataTable.Clear();

            for (int i = 0; i < webService.GetUsers().Length; i++)
            {
                dataTable.Rows.Add(webService.GetUsers()[i].name, webService.GetUsers()[i].email, webService.GetUsers()[i].password);
            }
        }
    }
}
