
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelUtil = new System.Windows.Forms.Label();
            this.dataGridViewVizualizare = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizualizare)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(297, 382);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 43);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUtil
            // 
            this.labelUtil.AutoSize = true;
            this.labelUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtil.Location = new System.Drawing.Point(126, 25);
            this.labelUtil.Name = "labelUtil";
            this.labelUtil.Size = new System.Drawing.Size(167, 24);
            this.labelUtil.TabIndex = 22;
            this.labelUtil.Text = "Date Utilizator:    ";
            // 
            // dataGridViewVizualizare
            // 
            this.dataGridViewVizualizare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVizualizare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nume,
            this.Email,
            this.RolPrincipal,
            this.ColumEdit});
            this.dataGridViewVizualizare.Location = new System.Drawing.Point(110, 52);
            this.dataGridViewVizualizare.Name = "dataGridViewVizualizare";
            this.dataGridViewVizualizare.Size = new System.Drawing.Size(530, 265);
            this.dataGridViewVizualizare.TabIndex = 23;
            this.dataGridViewVizualizare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVizualizare_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // RolPrincipal
            // 
            this.RolPrincipal.HeaderText = "Rol Principal";
            this.RolPrincipal.Name = "RolPrincipal";
            // 
            // ColumEdit
            // 
            this.ColumEdit.HeaderText = "Edit";
            this.ColumEdit.Name = "ColumEdit";
            // 
            // FormViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.dataGridViewVizualizare);
            this.Controls.Add(this.labelUtil);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormViewUser";
            this.Text = "Vizualizare Utilizator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizualizare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelUtil;
        private System.Windows.Forms.DataGridView dataGridViewVizualizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolPrincipal;
        private System.Windows.Forms.DataGridViewButtonColumn ColumEdit;
    }
}