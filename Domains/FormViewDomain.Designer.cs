
namespace Proiect.Domains
{
    partial class FormViewDomain
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
            this.pictureBoxFacultyLogo = new System.Windows.Forms.PictureBox();
            this.labelDomainName = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditDomain = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteDomain = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelFacultyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFacultyLogo
            // 
            this.pictureBoxFacultyLogo.ErrorImage = global::Proiect.Properties.Resources.utcn_logo_simple1;
            this.pictureBoxFacultyLogo.Image = global::Proiect.Properties.Resources.utcn_logo_simple;
            this.pictureBoxFacultyLogo.Location = new System.Drawing.Point(13, 39);
            this.pictureBoxFacultyLogo.Name = "pictureBoxFacultyLogo";
            this.pictureBoxFacultyLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFacultyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFacultyLogo.TabIndex = 37;
            this.pictureBoxFacultyLogo.TabStop = false;
            // 
            // labelDomainName
            // 
            this.labelDomainName.AutoSize = true;
            this.labelDomainName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomainName.Location = new System.Drawing.Point(69, 40);
            this.labelDomainName.Name = "labelDomainName";
            this.labelDomainName.Size = new System.Drawing.Size(154, 30);
            this.labelDomainName.TabIndex = 36;
            this.labelDomainName.Text = "Domain Name";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripSeparator1,
            this.toolStripButtonEditDomain,
            this.toolStripButtonDeleteDomain});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(851, 33);
            this.toolStrip.TabIndex = 35;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.Image = global::Proiect.Properties.Resources.icon_back;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(60, 23);
            this.toolStripButtonBack.Text = "Înapoi";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonEditDomain
            // 
            this.toolStripButtonEditDomain.Image = global::Proiect.Properties.Resources.icon_pencil;
            this.toolStripButtonEditDomain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditDomain.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonEditDomain.Name = "toolStripButtonEditDomain";
            this.toolStripButtonEditDomain.Size = new System.Drawing.Size(122, 23);
            this.toolStripButtonEditDomain.Text = "Editează domeniul";
            this.toolStripButtonEditDomain.Click += new System.EventHandler(this.toolStripButtonEditDomain_Click);
            // 
            // toolStripButtonDeleteDomain
            // 
            this.toolStripButtonDeleteDomain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteDomain.Image = global::Proiect.Properties.Resources.icon_trash;
            this.toolStripButtonDeleteDomain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteDomain.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButtonDeleteDomain.Name = "toolStripButtonDeleteDomain";
            this.toolStripButtonDeleteDomain.Size = new System.Drawing.Size(112, 23);
            this.toolStripButtonDeleteDomain.Text = "Șterge domeniul";
            this.toolStripButtonDeleteDomain.Click += new System.EventHandler(this.toolStripButtonDeleteDomain_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(815, 202);
            this.dataGridView.TabIndex = 33;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox.Location = new System.Drawing.Point(12, 95);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(827, 234);
            this.groupBox.TabIndex = 39;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Specializări";
            // 
            // labelFacultyName
            // 
            this.labelFacultyName.AutoSize = true;
            this.labelFacultyName.Location = new System.Drawing.Point(70, 68);
            this.labelFacultyName.Name = "labelFacultyName";
            this.labelFacultyName.Size = new System.Drawing.Size(104, 21);
            this.labelFacultyName.TabIndex = 40;
            this.labelFacultyName.Text = "Faculty Name";
            // 
            // FormViewDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 335);
            this.Controls.Add(this.labelFacultyName);
            this.Controls.Add(this.pictureBoxFacultyLogo);
            this.Controls.Add(this.labelDomainName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare domeniu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewDomain_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.FormViewDomain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFacultyLogo;
        private System.Windows.Forms.Label labelDomainName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditDomain;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteDomain;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelFacultyName;
    }
}