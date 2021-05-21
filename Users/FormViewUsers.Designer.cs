
namespace Proiect
{
    partial class FormViewUsers
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelSearch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.labelNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.Size = new System.Drawing.Size(960, 384);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripTextBoxSearch,
            this.toolStripLabelSearch,
            this.toolStripSeparator1,
            this.toolStripButtonAddUser});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(984, 33);
            this.toolStrip.TabIndex = 13;
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
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Margin = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSearch.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_TextChanged);
            // 
            // toolStripLabelSearch
            // 
            this.toolStripLabelSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSearch.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripLabelSearch.Name = "toolStripLabelSearch";
            this.toolStripLabelSearch.Size = new System.Drawing.Size(92, 23);
            this.toolStripLabelSearch.Text = "Caută utilizatori:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.Image = global::Proiect.Properties.Resources.icon_plus;
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(157, 23);
            this.toolStripButtonAddUser.Text = "Adaugă un utilizator nou";
            this.toolStripButtonAddUser.Click += new System.EventHandler(this.toolStripButtonAddUser_Click);
            // 
            // labelNotFound
            // 
            this.labelNotFound.AutoSize = true;
            this.labelNotFound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotFound.Location = new System.Drawing.Point(355, 45);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(275, 21);
            this.labelNotFound.TabIndex = 15;
            this.labelNotFound.Text = "Nu s-au găsit utilizatori cu acest nume";
            // 
            // FormViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.labelNotFound);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGridViewUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista utilizatorilor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewUsers_FormClosed);
            this.Load += new System.EventHandler(this.FormViewUsers_Load);
            this.VisibleChanged += new System.EventHandler(this.FormViewUsers_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.Label labelNotFound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
    }
}