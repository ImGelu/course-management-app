
namespace Proiect
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonViewRoles = new System.Windows.Forms.Button();
            this.buttonViewSpecializations = new System.Windows.Forms.Button();
            this.buttonViewDomains = new System.Windows.Forms.Button();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.buttonViewFaculties = new System.Windows.Forms.Button();
            this.buttonViewCourses = new System.Windows.Forms.Button();
            this.buttonViewRequests = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonLoggedIn = new System.Windows.Forms.ToolStripSplitButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxActions.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonViewRoles);
            this.groupBoxActions.Controls.Add(this.buttonViewSpecializations);
            this.groupBoxActions.Controls.Add(this.buttonViewDomains);
            this.groupBoxActions.Controls.Add(this.buttonViewUsers);
            this.groupBoxActions.Controls.Add(this.buttonViewFaculties);
            this.groupBoxActions.Controls.Add(this.buttonViewCourses);
            this.groupBoxActions.Controls.Add(this.buttonViewRequests);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 32);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(233, 396);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Ce vrei să faci azi?";
            // 
            // buttonViewRoles
            // 
            this.buttonViewRoles.Location = new System.Drawing.Point(9, 337);
            this.buttonViewRoles.Name = "buttonViewRoles";
            this.buttonViewRoles.Size = new System.Drawing.Size(214, 46);
            this.buttonViewRoles.TabIndex = 7;
            this.buttonViewRoles.Text = "Vizualizare roluri";
            this.buttonViewRoles.UseVisualStyleBackColor = true;
            this.buttonViewRoles.Click += new System.EventHandler(this.buttonViewRoles_Click);
            // 
            // buttonViewSpecializations
            // 
            this.buttonViewSpecializations.Location = new System.Drawing.Point(9, 233);
            this.buttonViewSpecializations.Name = "buttonViewSpecializations";
            this.buttonViewSpecializations.Size = new System.Drawing.Size(214, 46);
            this.buttonViewSpecializations.TabIndex = 6;
            this.buttonViewSpecializations.Text = "Vizualizare specializări";
            this.buttonViewSpecializations.UseVisualStyleBackColor = true;
            this.buttonViewSpecializations.Click += new System.EventHandler(this.buttonViewSpecializations_Click);
            // 
            // buttonViewDomains
            // 
            this.buttonViewDomains.Location = new System.Drawing.Point(9, 181);
            this.buttonViewDomains.Name = "buttonViewDomains";
            this.buttonViewDomains.Size = new System.Drawing.Size(214, 46);
            this.buttonViewDomains.TabIndex = 5;
            this.buttonViewDomains.Text = "Vizualizare domenii";
            this.buttonViewDomains.UseVisualStyleBackColor = true;
            this.buttonViewDomains.Click += new System.EventHandler(this.buttonViewDomains_Click);
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.Location = new System.Drawing.Point(9, 285);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(214, 46);
            this.buttonViewUsers.TabIndex = 3;
            this.buttonViewUsers.Text = "Vizualizare utilizatori";
            this.buttonViewUsers.UseVisualStyleBackColor = true;
            this.buttonViewUsers.Click += new System.EventHandler(this.buttonViewUsers_Click);
            // 
            // buttonViewFaculties
            // 
            this.buttonViewFaculties.Location = new System.Drawing.Point(9, 129);
            this.buttonViewFaculties.Name = "buttonViewFaculties";
            this.buttonViewFaculties.Size = new System.Drawing.Size(214, 46);
            this.buttonViewFaculties.TabIndex = 4;
            this.buttonViewFaculties.Text = "Vizualizare facultăți";
            this.buttonViewFaculties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewFaculties.UseVisualStyleBackColor = true;
            this.buttonViewFaculties.Click += new System.EventHandler(this.buttonViewFaculties_Click);
            // 
            // buttonViewCourses
            // 
            this.buttonViewCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonViewCourses.Location = new System.Drawing.Point(9, 25);
            this.buttonViewCourses.Name = "buttonViewCourses";
            this.buttonViewCourses.Size = new System.Drawing.Size(214, 46);
            this.buttonViewCourses.TabIndex = 1;
            this.buttonViewCourses.Text = "Vizualizare materii";
            this.buttonViewCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewCourses.UseVisualStyleBackColor = true;
            this.buttonViewCourses.Click += new System.EventHandler(this.buttonViewCourses_Click);
            // 
            // buttonViewRequests
            // 
            this.buttonViewRequests.Location = new System.Drawing.Point(9, 77);
            this.buttonViewRequests.Name = "buttonViewRequests";
            this.buttonViewRequests.Size = new System.Drawing.Size(214, 46);
            this.buttonViewRequests.TabIndex = 2;
            this.buttonViewRequests.Text = "Vizualizare cereri";
            this.buttonViewRequests.UseVisualStyleBackColor = true;
            this.buttonViewRequests.Click += new System.EventHandler(this.buttonViewRequests_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonLoggedIn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(783, 25);
            this.toolStrip.TabIndex = 1;
            // 
            // toolStripSplitButtonLoggedIn
            // 
            this.toolStripSplitButtonLoggedIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButtonLoggedIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripSplitButtonLoggedIn.Image = global::Proiect.Properties.Resources.icon_user;
            this.toolStripSplitButtonLoggedIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonLoggedIn.Name = "toolStripSplitButtonLoggedIn";
            this.toolStripSplitButtonLoggedIn.Size = new System.Drawing.Size(135, 22);
            this.toolStripSplitButtonLoggedIn.Text = "Conectat ca {0} ({1})";
            this.toolStripSplitButtonLoggedIn.ToolTipText = "Logged in as {user} ({role})";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::Proiect.Properties.Resources.icon_logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.logo_utcn;
            this.pictureBox1.Location = new System.Drawing.Point(259, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(783, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBoxActions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.groupBoxActions.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.Button buttonViewSpecializations;
        private System.Windows.Forms.Button buttonViewDomains;
        private System.Windows.Forms.Button buttonViewFaculties;
        private System.Windows.Forms.Button buttonViewCourses;
        private System.Windows.Forms.Button buttonViewRequests;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonLoggedIn;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button buttonViewRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}