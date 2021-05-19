namespace Proiect.Courses.Requests
{
    partial class PopupRequests
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
            this.labelTextPopup = new System.Windows.Forms.Label();
            this.buttonDa = new System.Windows.Forms.Button();
            this.buttonNu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextPopup
            // 
            this.labelTextPopup.AutoSize = true;
            this.labelTextPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextPopup.Location = new System.Drawing.Point(135, 27);
            this.labelTextPopup.Name = "labelTextPopup";
            this.labelTextPopup.Size = new System.Drawing.Size(97, 18);
            this.labelTextPopup.TabIndex = 0;
            this.labelTextPopup.Text = "Sunteți sigur?";
            // 
            // buttonDa
            // 
            this.buttonDa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonDa.Location = new System.Drawing.Point(80, 73);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(75, 23);
            this.buttonDa.TabIndex = 1;
            this.buttonDa.Text = "Da";
            this.buttonDa.UseVisualStyleBackColor = true;
            // 
            // buttonNu
            // 
            this.buttonNu.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNu.Location = new System.Drawing.Point(213, 73);
            this.buttonNu.Name = "buttonNu";
            this.buttonNu.Size = new System.Drawing.Size(75, 23);
            this.buttonNu.TabIndex = 2;
            this.buttonNu.Text = "Nu";
            this.buttonNu.UseVisualStyleBackColor = true;
            // 
            // PopupRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 128);
            this.Controls.Add(this.buttonNu);
            this.Controls.Add(this.buttonDa);
            this.Controls.Add(this.labelTextPopup);
            this.Name = "PopupRequests";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextPopup;
        private System.Windows.Forms.Button buttonDa;
        private System.Windows.Forms.Button buttonNu;
    }
}