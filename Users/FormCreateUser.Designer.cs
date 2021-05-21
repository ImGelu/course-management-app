
namespace Proiect
{
    partial class FormCreateUser
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
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
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(14, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(608, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Adaugă utilizatorul";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.labelRole.Location = new System.Drawing.Point(14, 166);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(52, 21);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Roluri";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(14, 122);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(290, 29);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(14, 98);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 21);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Parola";
            // 
            // textBoxPasswordConfirmation
            // 
            this.textBoxPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxPasswordConfirmation.Location = new System.Drawing.Point(332, 122);
            this.textBoxPasswordConfirmation.Multiline = true;
            this.textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            this.textBoxPasswordConfirmation.PasswordChar = '*';
            this.textBoxPasswordConfirmation.Size = new System.Drawing.Size(290, 29);
            this.textBoxPasswordConfirmation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirmarea parolei";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonAddRole);
            this.groupBox.Controls.Add(this.listBoxRoles);
            this.groupBox.Controls.Add(this.comboBoxRoles);
            this.groupBox.Controls.Add(this.textBoxPasswordConfirmation);
            this.groupBox.Controls.Add(this.textBoxEmail);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.labelEmail);
            this.groupBox.Controls.Add(this.labelPassword);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.textBoxPassword);
            this.groupBox.Controls.Add(this.labelRole);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox.Location = new System.Drawing.Point(12, 28);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(628, 373);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRole.Location = new System.Drawing.Point(446, 291);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(176, 28);
            this.buttonAddRole.TabIndex = 7;
            this.buttonAddRole.Text = "Adaugă rolul";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 20;
            this.listBoxRoles.Location = new System.Drawing.Point(14, 190);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(608, 84);
            this.listBoxRoles.TabIndex = 5;
            this.listBoxRoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxRoles_KeyPress);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(14, 291);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(426, 28);
            this.comboBoxRoles.Sorted = true;
            this.comboBoxRoles.TabIndex = 6;
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
            this.toolStrip.Size = new System.Drawing.Size(652, 30);
            this.toolStrip.TabIndex = 16;
            this.toolStrip.Text = "toolStrip";
            // 
            // FormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 413);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creare utilizator nou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreateUser_FormClosed);
            this.Load += new System.EventHandler(this.FormCreateUser_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.ComboBox comboBoxRoles;
    }
}