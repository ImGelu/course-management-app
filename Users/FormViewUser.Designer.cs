
namespace Proiect
{
    partial class FormViewUser
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
            this.toolStripButtonEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
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
            this.toolStripButtonEditUser,
            this.toolStripButtonDeleteUser});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(651, 33);
            this.toolStrip.TabIndex = 24;
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
            // toolStripButtonEditUser
            // 
            this.toolStripButtonEditUser.Image = global::Proiect.Properties.Resources.icon_pencil;
            this.toolStripButtonEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUser.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonEditUser.Name = "toolStripButtonEditUser";
            this.toolStripButtonEditUser.Size = new System.Drawing.Size(129, 23);
            this.toolStripButtonEditUser.Text = "Editează utilizatorul";
            this.toolStripButtonEditUser.Click += new System.EventHandler(this.toolStripButtonEditUser_Click);
            // 
            // toolStripButtonDeleteUser
            // 
            this.toolStripButtonDeleteUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteUser.Image = global::Proiect.Properties.Resources.icon_trash;
            this.toolStripButtonDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteUser.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButtonDeleteUser.Name = "toolStripButtonDeleteUser";
            this.toolStripButtonDeleteUser.Size = new System.Drawing.Size(119, 23);
            this.toolStripButtonDeleteUser.Text = "Șterge utilizatorul";
            this.toolStripButtonDeleteUser.Click += new System.EventHandler(this.toolStripButtonDeleteUser_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listBoxRoles);
            this.groupBox.Controls.Add(this.textBoxEmail);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.labelEmail);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.labelRole);
            this.groupBox.Location = new System.Drawing.Point(11, 45);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(628, 251);
            this.groupBox.TabIndex = 25;
            this.groupBox.TabStop = false;
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.Enabled = false;
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(14, 124);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(608, 95);
            this.listBoxRoles.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(14, 52);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(290, 29);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxName.Location = new System.Drawing.Point(332, 52);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(290, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(14, 28);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 21);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(332, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 21);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Nume";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(14, 100);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(52, 21);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Roluri";
            // 
            // FormViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 309);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.toolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare Utilizator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewUser_FormClosed);
            this.Load += new System.EventHandler(this.FormViewUser_Load);
            this.VisibleChanged += new System.EventHandler(this.FormViewUser_VisibleChanged);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteUser;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}