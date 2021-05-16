
namespace Proiect.Roles
{
    partial class FormEditRole
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDeleteRole = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(13, 84);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(413, 31);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Salvează modificările";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nume";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 47);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(357, 29);
            this.textBoxName.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDeleteRole,
            this.toolStripButtonBack});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(435, 30);
            this.toolStrip.TabIndex = 26;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonDeleteRole
            // 
            this.toolStripButtonDeleteRole.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteRole.Image = global::Proiect.Properties.Resources.icon_trash;
            this.toolStripButtonDeleteRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteRole.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButtonDeleteRole.Name = "toolStripButtonDeleteRole";
            this.toolStripButtonDeleteRole.Size = new System.Drawing.Size(87, 20);
            this.toolStripButtonDeleteRole.Text = "Șterge rolul";
            this.toolStripButtonDeleteRole.Click += new System.EventHandler(this.toolStripButtonDeleteRole_Click);
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
            // FormEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(435, 130);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editare rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditRole_FormClosed);
            this.Load += new System.EventHandler(this.FormEditRole_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteRole;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
    }
}