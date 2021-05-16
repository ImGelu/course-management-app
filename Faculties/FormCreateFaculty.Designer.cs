
namespace Proiect.Faculties
{
    partial class FormCreateFaculty
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
            this.labelName = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonCreateFaculty = new System.Windows.Forms.Button();
            this.buttonDeleteLogo = new System.Windows.Forms.Button();
            this.buttonChooseLogo = new System.Windows.Forms.Button();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nume";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(402, 30);
            this.toolStrip.TabIndex = 28;
            this.toolStrip.Text = "toolStrip";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(7, 64);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(65, 21);
            this.labelWebsite.TabIndex = 29;
            this.labelWebsite.Text = "Website";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(7, 98);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(45, 21);
            this.labelLogo.TabIndex = 30;
            this.labelLogo.Text = "Logo";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 29);
            this.textBoxName.TabIndex = 31;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonCreateFaculty);
            this.groupBox.Controls.Add(this.buttonDeleteLogo);
            this.groupBox.Controls.Add(this.pictureBoxLogo);
            this.groupBox.Controls.Add(this.buttonChooseLogo);
            this.groupBox.Controls.Add(this.textBoxWebsite);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.labelLogo);
            this.groupBox.Controls.Add(this.labelWebsite);
            this.groupBox.Location = new System.Drawing.Point(12, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(378, 256);
            this.groupBox.TabIndex = 32;
            this.groupBox.TabStop = false;
            // 
            // buttonCreateFaculty
            // 
            this.buttonCreateFaculty.Location = new System.Drawing.Point(78, 205);
            this.buttonCreateFaculty.Name = "buttonCreateFaculty";
            this.buttonCreateFaculty.Size = new System.Drawing.Size(294, 37);
            this.buttonCreateFaculty.TabIndex = 36;
            this.buttonCreateFaculty.Text = "Adaugă facultatea";
            this.buttonCreateFaculty.UseVisualStyleBackColor = true;
            this.buttonCreateFaculty.Click += new System.EventHandler(this.buttonCreateFaculty_Click);
            // 
            // buttonDeleteLogo
            // 
            this.buttonDeleteLogo.Location = new System.Drawing.Point(184, 149);
            this.buttonDeleteLogo.Name = "buttonDeleteLogo";
            this.buttonDeleteLogo.Size = new System.Drawing.Size(188, 50);
            this.buttonDeleteLogo.TabIndex = 35;
            this.buttonDeleteLogo.Text = "Șterge logo-ul";
            this.buttonDeleteLogo.UseVisualStyleBackColor = true;
            this.buttonDeleteLogo.Click += new System.EventHandler(this.buttonDeleteLogo_Click);
            // 
            // buttonChooseLogo
            // 
            this.buttonChooseLogo.Location = new System.Drawing.Point(184, 99);
            this.buttonChooseLogo.Name = "buttonChooseLogo";
            this.buttonChooseLogo.Size = new System.Drawing.Size(188, 50);
            this.buttonChooseLogo.TabIndex = 33;
            this.buttonChooseLogo.Text = "Alege o imagine";
            this.buttonChooseLogo.UseVisualStyleBackColor = true;
            this.buttonChooseLogo.Click += new System.EventHandler(this.buttonChooseLogo_Click);
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(78, 64);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(294, 29);
            this.textBoxWebsite.TabIndex = 32;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.ErrorImage = global::Proiect.Properties.Resources.utcn_logo_simple1;
            this.pictureBoxLogo.Image = global::Proiect.Properties.Resources.utcn_logo_simple;
            this.pictureBoxLogo.Location = new System.Drawing.Point(78, 99);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 34;
            this.pictureBoxLogo.TabStop = false;
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.Image = global::Proiect.Properties.Resources.icon_back;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(60, 20);
            this.toolStripButtonBack.Text = "Înapoi";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // FormCreateFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(402, 303);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creare facultate nouă";
            this.Load += new System.EventHandler(this.FormCreateFaculty_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonDeleteLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonChooseLogo;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.Button buttonCreateFaculty;
    }
}