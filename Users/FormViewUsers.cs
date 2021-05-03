using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormViewUsers : Form
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();
        DataTable dataTable = new DataTable();
        public FormViewUsers()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Principal Role", typeof(string));
            dataGridViewUsers.DataSource = dataTable;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                string searchValue = textBoxSearch.Text;
                try
                {
                    var re = from row in dataTable.AsEnumerable()
                             where row[1].ToString().Contains(searchValue)
                             select row;
                    if (re.Count() == 0)
                    {
                        MessageBox.Show("No row");
                    }
                    else
                    {
                        dataGridViewUsers.DataSource = re.CopyToDataTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateUser newForm = new FormCreateUser();
            newForm.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            FormEditUser newForm = new FormEditUser(user.id);
            newForm.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            
            webService.DeleteUser(user.id);
            dataGridViewUsers.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Utilizatorul a fost sters cu succes!");
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            string email = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            CoursesWebServiceReference.User user = webService.GetUserByEmail(email);
            
            FormViewUser newForm = new FormViewUser();
            newForm.dataGridViewVizualizare.Rows.Add();
            newForm.dataGridViewVizualizare.Rows[0].Cells[0].Value = user.name;
            newForm.dataGridViewVizualizare.Rows[0].Cells[1].Value = user.email;
            newForm.dataGridViewVizualizare.Rows[0].Cells[2].Value =user.password;
            newForm.Show();
        }

        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < webService.GetUsers().Length; i++)
            {
                dataTable.Rows.Add(webService.GetUsers()[i].name, webService.GetUsers()[i].email, webService.GetUsers()[i].password);
                
            }
        }
    }
}
