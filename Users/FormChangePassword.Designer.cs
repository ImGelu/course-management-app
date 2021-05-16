
namespace Proiect.Users
{
    partial class FormChangePassword
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
            this.textBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirmation = new System.Windows.Forms.Label();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.groupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxPasswordConfirmation);
            this.groupBox.Controls.Add(this.labelPasswordConfirmation);
            this.groupBox.Controls.Add(this.buttonEditUser);
            this.groupBox.Controls.Add(this.labelPassword);
            this.groupBox.Controls.Add(this.textBoxPassword);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 41);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(623, 125);
            this.groupBox.TabIndex = 18;
            this.groupBox.TabStop = false;
            // 
            // textBoxPasswordConfirmation
            // 
            this.textBoxPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirmation.Location = new System.Drawing.Point(327, 41);
            this.textBoxPasswordConfirmation.Multiline = true;
            this.textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            this.textBoxPasswordConfirmation.PasswordChar = '*';
            this.textBoxPasswordConfirmation.Size = new System.Drawing.Size(290, 29);
            this.textBoxPasswordConfirmation.TabIndex = 13;
            // 
            // labelPasswordConfirmation
            // 
            this.labelPasswordConfirmation.AutoSize = true;
            this.labelPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmation.Location = new System.Drawing.Point(327, 17);
            this.labelPasswordConfirmation.Name = "labelPasswordConfirmation";
            this.labelPasswordConfirmation.Size = new System.Drawing.Size(149, 21);
            this.labelPasswordConfirmation.TabIndex = 14;
            this.labelPasswordConfirmation.Text = "Confirmarea parolei";
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUser.Location = new System.Drawing.Point(14, 76);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(603, 34);
            this.buttonEditUser.TabIndex = 4;
            this.buttonEditUser.Text = "Salvează parola";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(14, 17);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 21);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Parola Noua";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(14, 41);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(290, 29);
            this.textBoxPassword.TabIndex = 10;
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
            this.toolStrip.Size = new System.Drawing.Size(647, 30);
            this.toolStrip.TabIndex = 26;
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
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 181);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schimbare parolă";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChangePassword_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmation;
        private System.Windows.Forms.Label labelPasswordConfirmation;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
    }
}