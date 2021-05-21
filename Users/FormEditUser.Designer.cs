
namespace Proiect
{
    partial class FormEditUser
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
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonChangePassword = new System.Windows.Forms.ToolStripButton();
            this.groupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonAddRole);
            this.groupBox.Controls.Add(this.listBoxRoles);
            this.groupBox.Controls.Add(this.comboBoxRoles);
            this.groupBox.Controls.Add(this.textBoxEmail);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.buttonEditUser);
            this.groupBox.Controls.Add(this.labelEmail);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.labelRole);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox.Location = new System.Drawing.Point(12, 28);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(628, 295);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonAddRole.Location = new System.Drawing.Point(446, 213);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(176, 28);
            this.buttonAddRole.TabIndex = 5;
            this.buttonAddRole.Text = "Adaugă rolul";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 20;
            this.listBoxRoles.Location = new System.Drawing.Point(14, 112);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(608, 84);
            this.listBoxRoles.TabIndex = 3;
            this.listBoxRoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxRoles_KeyPress);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(14, 213);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(426, 28);
            this.comboBoxRoles.Sorted = true;
            this.comboBoxRoles.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(14, 52);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 29);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxName.Location = new System.Drawing.Point(332, 52);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(290, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonEditUser.Location = new System.Drawing.Point(14, 247);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(608, 34);
            this.buttonEditUser.TabIndex = 6;
            this.buttonEditUser.Text = "Salvează schimbările";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
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
            this.labelRole.Location = new System.Drawing.Point(14, 88);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(52, 21);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Roluri";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDeleteUser,
            this.toolStripButtonBack,
            this.toolStripSeparator1,
            this.toolStripButtonChangePassword});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(652, 33);
            this.toolStrip.TabIndex = 25;
            this.toolStrip.Text = "toolStrip";
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
            // toolStripButtonChangePassword
            // 
            this.toolStripButtonChangePassword.Image = global::Proiect.Properties.Resources.icon_role;
            this.toolStripButtonChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangePassword.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonChangePassword.Name = "toolStripButtonChangePassword";
            this.toolStripButtonChangePassword.Size = new System.Drawing.Size(106, 23);
            this.toolStripButtonChangePassword.Text = "Schimbă parola";
            this.toolStripButtonChangePassword.ToolTipText = "Schimbă parola";
            this.toolStripButtonChangePassword.Click += new System.EventHandler(this.toolStripButtonChangePassword_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 336);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editare utilizator existent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditUser_FormClosed);
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteUser;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangePassword;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}