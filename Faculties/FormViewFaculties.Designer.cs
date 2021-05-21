
namespace Proiect.Faculties
{
    partial class FormViewFaculties
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
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddFaculty = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
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
            this.toolStripButtonAddFaculty});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(833, 33);
            this.toolStrip.TabIndex = 14;
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
            // toolStripButtonAddFaculty
            // 
            this.toolStripButtonAddFaculty.Image = global::Proiect.Properties.Resources.icon_plus;
            this.toolStripButtonAddFaculty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFaculty.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonAddFaculty.Name = "toolStripButtonAddFaculty";
            this.toolStripButtonAddFaculty.Size = new System.Drawing.Size(155, 23);
            this.toolStripButtonAddFaculty.Text = "Adaugă o facultate nouă";
            this.toolStripButtonAddFaculty.Click += new System.EventHandler(this.toolStripButtonAddFaculty_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 36);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(809, 416);
            this.panel.TabIndex = 15;
            // 
            // FormViewFaculties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(833, 464);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewFaculties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista facultăților";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewFaculties_FormClosed);
            this.Load += new System.EventHandler(this.FormViewFaculties_Load);
            this.VisibleChanged += new System.EventHandler(this.FormViewFaculties_VisibleChanged);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFaculty;
        private System.Windows.Forms.Panel panel;
    }
}