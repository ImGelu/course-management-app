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
    public partial class FormViewDomains : Form
    {
        public static CoursesWebService webService = new CoursesWebService();
        private FormDashboard parent;

        public FormViewDomains()
        {
            InitializeComponent();
        }

        private void FormViewDomains_Load(object sender, EventArgs e)
        {
            parent = (FormDashboard)Owner;

            UpdateData(sender, e);
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void toolStripButtonAddDomain_Click(object sender, EventArgs e)
        {
            FormCreateDomain formCreateDomain = new FormCreateDomain();
            formCreateDomain.Show(this);
            this.Hide();
        }

        private void FormViewDomains_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                UpdateData(sender, e);
            }
        }

        private void FormViewDomains_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void viewDomain(object sender, EventArgs e, Domain domain)
        {
            FormViewDomain formViewDomain = new FormViewDomain(this, domain.id);
            this.Hide();
            formViewDomain.Show();
        }

        private void UpdateData(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            int width = panel.Size.Width;

            int widthOffset = 10;
            int heightOffset = 10;

            int btnWidth = 200;
            int btnHeight = 100;

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            webService.GetDomains().ToList().ForEach((domain) =>
            {

                if ((widthOffset + btnWidth) >= width)
                {
                    widthOffset = 10;
                    heightOffset = heightOffset + btnHeight;
                }

                var button = new Button();
                button.Size = new Size(btnWidth, btnHeight);
                button.Name = "buttonDomain" + domain.id;
                button.Text = domain.name;
                button.Click += new EventHandler((ss, ee) => viewDomain(sender, e, domain));
                button.Location = new Point(widthOffset, heightOffset);

                panel.Controls.Add(button);

                widthOffset = widthOffset + (btnWidth);
            });

            //this.Height = heightOffset + btnHeight + 90;
            //panel.Height = heightOffset + btnHeight + 90;
        }
    }
}
