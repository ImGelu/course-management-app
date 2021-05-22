using Proiect.CoursesWebServiceReference;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proiect.Specializations
{
    public partial class FormViewSpecializations : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;

        public FormViewSpecializations()
        {
            InitializeComponent();
        }

        private void FormViewSpecializations_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonAddSpecialization_Click(object sender, EventArgs e)
        {
            FormCreateSpecialization formCreateSpecialization = new FormCreateSpecialization();
            formCreateSpecialization.Show(this);
            this.Hide();
        }

        private void FormViewSpecializations_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData(sender, e);
            }
        }

        private void FormViewSpecializations_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void viewSpecialization(object sender, EventArgs e, Specialization specialization)
        {
            FormViewSpecialization formViewSpecialization = new FormViewSpecialization(this, specialization.id);
            this.Hide();
            formViewSpecialization.Show();
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (webService.UserIs(Utils.GetLoggedInUser().id, "Administrator") || webService.UserIs(Utils.GetLoggedInUser().id, "Secretar"))
            {
                toolStripSeparator1.Visible = true;
                toolStripButtonAddSpecialization.Visible = true;
            }
            else
            {
                toolStripSeparator1.Visible = false;
                toolStripButtonAddSpecialization.Visible = false;
            }

            panel.Controls.Clear();

            int width = panel.Size.Width;

            int widthOffset = 10;
            int heightOffset = 10;

            int btnWidth = 200;
            int btnHeight = 100;

            webService.GetSpecializations().ToList().OrderBy(spec => spec.name).ToList().ForEach((specialization) =>
            {

                if ((widthOffset + btnWidth) >= width)
                {
                    widthOffset = 10;
                    heightOffset = heightOffset + btnHeight;
                }

                var button = new Button();
                button.Size = new Size(btnWidth, btnHeight);
                button.Name = "buttonSpecialization" + specialization.id;
                button.Text = specialization.name;
                button.Click += new EventHandler((ss, ee) => viewSpecialization(sender, e, specialization));
                button.Location = new Point(widthOffset, heightOffset);

                panel.Controls.Add(button);

                widthOffset = widthOffset + (btnWidth);
            });
        }
    }
}
