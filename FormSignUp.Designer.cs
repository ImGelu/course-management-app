
namespace Proiect
{
    partial class FormSignUp
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPasswordConfirmation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.buttonCreateAccount);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(407, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creează-ți un cont nou!";
            // 
            // textBoxPasswordConfirmation
            // 
            this.textBoxPasswordConfirmation.Location = new System.Drawing.Point(216, 138);
            this.textBoxPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            this.textBoxPasswordConfirmation.PasswordChar = '*';
            this.textBoxPasswordConfirmation.Size = new System.Drawing.Size(179, 27);
            this.textBoxPasswordConfirmation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Confirmarea parolei";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nume și prenume";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 62);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(15, 138);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(187, 27);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(15, 195);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(381, 35);
            this.buttonCreateAccount.TabIndex = 4;
            this.buttonCreateAccount.Text = "Creează contul";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 114);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 20);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Parolă";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(216, 62);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(179, 27);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(212, 37);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(128, 20);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email instituțional";
            // 
            // toolTipEmail
            // 
            this.toolTipEmail.AutomaticDelay = 1;
            this.toolTipEmail.IsBalloon = true;
            this.toolTipEmail.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipEmail.ToolTipTitle = "Hello!";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.Location = new System.Drawing.Point(264, 285);
            this.linkLabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(169, 13);
            this.linkLabelLogin.TabIndex = 5;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Ai deja un cont? Conectează-te!";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 323);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creare cont nou";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmation;
        private System.Windows.Forms.Label label2;
    }
}