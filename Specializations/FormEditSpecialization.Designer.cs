
namespace Proiect.Specializations
{
    partial class FormEditSpecialization
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.buttonEditSpecialization = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.groupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxDomain);
            this.groupBox.Controls.Add(this.labelDomain);
            this.groupBox.Controls.Add(this.comboBoxFaculty);
            this.groupBox.Controls.Add(this.buttonEditSpecialization);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.labelFaculty);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.Location = new System.Drawing.Point(12, 45);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(378, 193);
            this.groupBox.TabIndex = 42;
            this.groupBox.TabStop = false;
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(84, 101);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(288, 29);
            this.comboBoxDomain.TabIndex = 30;
            this.comboBoxDomain.SelectedIndexChanged += new System.EventHandler(this.comboBoxDomain_SelectedIndexChanged);
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(7, 105);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(74, 21);
            this.labelDomain.TabIndex = 31;
            this.labelDomain.Text = "Domeniu";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(84, 66);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(288, 29);
            this.comboBoxFaculty.TabIndex = 2;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // buttonEditSpecialization
            // 
            this.buttonEditSpecialization.Location = new System.Drawing.Point(84, 136);
            this.buttonEditSpecialization.Name = "buttonEditSpecialization";
            this.buttonEditSpecialization.Size = new System.Drawing.Size(288, 37);
            this.buttonEditSpecialization.TabIndex = 3;
            this.buttonEditSpecialization.Text = "Salvează modificările";
            this.buttonEditSpecialization.UseVisualStyleBackColor = true;
            this.buttonEditSpecialization.Click += new System.EventHandler(this.buttonEditSpecialization_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(288, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nume";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(7, 70);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(71, 21);
            this.labelFaculty.TabIndex = 29;
            this.labelFaculty.Text = "Facultate";
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
            this.toolStrip.TabIndex = 41;
            this.toolStrip.Text = "toolStrip";
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
            // FormEditSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(402, 250);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.toolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditSpecialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editare specializare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditSpecialization_FormClosed);
            this.Load += new System.EventHandler(this.FormEditSpecialization_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Button buttonEditSpecialization;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
    }
}