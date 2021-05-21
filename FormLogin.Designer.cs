
namespace Proiect
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(103, 162);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(209, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Conectează-te";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(103, 42);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 27);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 46);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(103, 82);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(208, 27);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 86);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Parolă";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sistem pentru administrarea cursurilor universitare";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.checkBoxRememberMe);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxEmail);
            this.groupBoxLogin.Controls.Add(this.labelEmail);
            this.groupBoxLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxLogin.Location = new System.Drawing.Point(88, 66);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLogin.Size = new System.Drawing.Size(336, 222);
            this.groupBoxLogin.TabIndex = 8;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Conectare";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(103, 125);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(131, 24);
            this.checkBoxRememberMe.TabIndex = 7;
            this.checkBoxRememberMe.Text = "Rămâi conectat";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUp.Location = new System.Drawing.Point(256, 293);
            this.linkLabelSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(168, 13);
            this.linkLabelSignUp.TabIndex = 3;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Nu ai un cont? Înregistrează-te!";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 329);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectare";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}

