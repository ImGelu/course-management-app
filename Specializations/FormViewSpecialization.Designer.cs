
namespace Proiect.Specializations
{
    partial class FormViewSpecialization
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
            this.labelFacultyDomainName = new System.Windows.Forms.Label();
            this.pictureBoxFacultyLogo = new System.Windows.Forms.PictureBox();
            this.labelSpecializationName = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditSpecialization = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSpecialization = new System.Windows.Forms.ToolStripButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFacultyDomainName
            // 
            this.labelFacultyDomainName.AutoSize = true;
            this.labelFacultyDomainName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFacultyDomainName.Location = new System.Drawing.Point(70, 68);
            this.labelFacultyDomainName.Name = "labelFacultyDomainName";
            this.labelFacultyDomainName.Size = new System.Drawing.Size(219, 21);
            this.labelFacultyDomainName.TabIndex = 45;
            this.labelFacultyDomainName.Text = "Faculty Name / Domain Name";
            // 
            // pictureBoxFacultyLogo
            // 
            this.pictureBoxFacultyLogo.ErrorImage = global::Proiect.Properties.Resources.utcn_logo_simple1;
            this.pictureBoxFacultyLogo.Image = global::Proiect.Properties.Resources.utcn_logo_simple;
            this.pictureBoxFacultyLogo.Location = new System.Drawing.Point(13, 42);
            this.pictureBoxFacultyLogo.Name = "pictureBoxFacultyLogo";
            this.pictureBoxFacultyLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFacultyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFacultyLogo.TabIndex = 43;
            this.pictureBoxFacultyLogo.TabStop = false;
            // 
            // labelSpecializationName
            // 
            this.labelSpecializationName.AutoSize = true;
            this.labelSpecializationName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializationName.Location = new System.Drawing.Point(69, 40);
            this.labelSpecializationName.Name = "labelSpecializationName";
            this.labelSpecializationName.Size = new System.Drawing.Size(213, 30);
            this.labelSpecializationName.TabIndex = 42;
            this.labelSpecializationName.Text = "Specialization Name";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripSeparator1,
            this.toolStripButtonEditSpecialization,
            this.toolStripButtonDeleteSpecialization});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(851, 33);
            this.toolStrip.TabIndex = 41;
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
            // toolStripButtonEditSpecialization
            // 
            this.toolStripButtonEditSpecialization.Image = global::Proiect.Properties.Resources.icon_pencil;
            this.toolStripButtonEditSpecialization.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditSpecialization.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonEditSpecialization.Name = "toolStripButtonEditSpecialization";
            this.toolStripButtonEditSpecialization.Size = new System.Drawing.Size(138, 23);
            this.toolStripButtonEditSpecialization.Text = "Editează specializarea";
            this.toolStripButtonEditSpecialization.Click += new System.EventHandler(this.toolStripButtonEditSpecialization_Click);
            // 
            // toolStripButtonDeleteSpecialization
            // 
            this.toolStripButtonDeleteSpecialization.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteSpecialization.Image = global::Proiect.Properties.Resources.icon_trash;
            this.toolStripButtonDeleteSpecialization.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteSpecialization.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButtonDeleteSpecialization.Name = "toolStripButtonDeleteSpecialization";
            this.toolStripButtonDeleteSpecialization.Size = new System.Drawing.Size(128, 23);
            this.toolStripButtonDeleteSpecialization.Text = "Șterge specializarea";
            this.toolStripButtonDeleteSpecialization.Click += new System.EventHandler(this.toolStripButtonDeleteSpecialization_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox.Location = new System.Drawing.Point(12, 98);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(827, 234);
            this.groupBox.TabIndex = 44;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cursuri";
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
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(815, 202);
            this.dataGridView.TabIndex = 33;
            // 
            // FormViewSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 335);
            this.Controls.Add(this.labelFacultyDomainName);
            this.Controls.Add(this.pictureBoxFacultyLogo);
            this.Controls.Add(this.labelSpecializationName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewSpecialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare specializare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewSpecialization_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.FormViewSpecialization_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacultyDomainName;
        private System.Windows.Forms.PictureBox pictureBoxFacultyLogo;
        private System.Windows.Forms.Label labelSpecializationName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSpecialization;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSpecialization;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}