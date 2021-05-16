
namespace Proiect.Faculties
{
    partial class FormViewFaculty
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelFacultyName = new System.Windows.Forms.Label();
            this.linkLabelFacultyWebsite = new System.Windows.Forms.LinkLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxFacultyLogo = new System.Windows.Forms.PictureBox();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditFaculty = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteFaculty = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripSeparator1,
            this.toolStripButtonEditFaculty,
            this.toolStripButtonDeleteFaculty});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(851, 33);
            this.toolStrip.TabIndex = 29;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // labelFacultyName
            // 
            this.labelFacultyName.AutoSize = true;
            this.labelFacultyName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultyName.Location = new System.Drawing.Point(69, 34);
            this.labelFacultyName.Name = "labelFacultyName";
            this.labelFacultyName.Size = new System.Drawing.Size(146, 30);
            this.labelFacultyName.TabIndex = 30;
            this.labelFacultyName.Text = "Faculty Name";
            // 
            // linkLabelFacultyWebsite
            // 
            this.linkLabelFacultyWebsite.AutoSize = true;
            this.linkLabelFacultyWebsite.Location = new System.Drawing.Point(70, 62);
            this.linkLabelFacultyWebsite.Name = "linkLabelFacultyWebsite";
            this.linkLabelFacultyWebsite.Size = new System.Drawing.Size(117, 21);
            this.linkLabelFacultyWebsite.TabIndex = 32;
            this.linkLabelFacultyWebsite.TabStop = true;
            this.linkLabelFacultyWebsite.Text = "Faculty Website";
            this.linkLabelFacultyWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFacultyWebsite_LinkClicked);
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
            this.groupBox.Location = new System.Drawing.Point(12, 89);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(827, 234);
            this.groupBox.TabIndex = 34;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Domenii";
            // 
            // pictureBoxFacultyLogo
            // 
            this.pictureBoxFacultyLogo.ErrorImage = global::Proiect.Properties.Resources.utcn_logo_simple1;
            this.pictureBoxFacultyLogo.Image = global::Proiect.Properties.Resources.utcn_logo_simple;
            this.pictureBoxFacultyLogo.Location = new System.Drawing.Point(13, 33);
            this.pictureBoxFacultyLogo.Name = "pictureBoxFacultyLogo";
            this.pictureBoxFacultyLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFacultyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFacultyLogo.TabIndex = 31;
            this.pictureBoxFacultyLogo.TabStop = false;
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
            // toolStripButtonEditFaculty
            // 
            this.toolStripButtonEditFaculty.Image = global::Proiect.Properties.Resources.icon_pencil;
            this.toolStripButtonEditFaculty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditFaculty.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonEditFaculty.Name = "toolStripButtonEditFaculty";
            this.toolStripButtonEditFaculty.Size = new System.Drawing.Size(124, 23);
            this.toolStripButtonEditFaculty.Text = "Editează facultatea";
            this.toolStripButtonEditFaculty.Click += new System.EventHandler(this.toolStripButtonEditFaculty_Click);
            // 
            // toolStripButtonDeleteFaculty
            // 
            this.toolStripButtonDeleteFaculty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteFaculty.Image = global::Proiect.Properties.Resources.icon_trash;
            this.toolStripButtonDeleteFaculty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteFaculty.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButtonDeleteFaculty.Name = "toolStripButtonDeleteFaculty";
            this.toolStripButtonDeleteFaculty.Size = new System.Drawing.Size(114, 23);
            this.toolStripButtonDeleteFaculty.Text = "Șterge facultatea";
            this.toolStripButtonDeleteFaculty.Click += new System.EventHandler(this.toolStripButtonDeleteFaculty_Click);
            // 
            // FormViewFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 335);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.linkLabelFacultyWebsite);
            this.Controls.Add(this.pictureBoxFacultyLogo);
            this.Controls.Add(this.labelFacultyName);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare facultate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewFaculty_FormClosed);
            this.Load += new System.EventHandler(this.FormViewFaculty_Load);
            this.VisibleChanged += new System.EventHandler(this.FormViewFaculty_VisibleChanged);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacultyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.Label labelFacultyName;
        private System.Windows.Forms.PictureBox pictureBoxFacultyLogo;
        private System.Windows.Forms.LinkLabel linkLabelFacultyWebsite;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditFaculty;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteFaculty;
    }
}