namespace TimeTrackerPjan
{
    partial class Projects
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
            this.lbxProjectsPjan = new System.Windows.Forms.ListBox();
            this.tbxNamePjan = new System.Windows.Forms.TextBox();
            this.btnRenamePjan = new System.Windows.Forms.Button();
            this.btnDeletePjan = new System.Windows.Forms.Button();
            this.btnAddPjan = new System.Windows.Forms.Button();
            this.btnCategoriesPjan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProjectsPjan
            // 
            this.lbxProjectsPjan.FormattingEnabled = true;
            this.lbxProjectsPjan.Location = new System.Drawing.Point(9, 8);
            this.lbxProjectsPjan.Name = "lbxProjectsPjan";
            this.lbxProjectsPjan.Size = new System.Drawing.Size(264, 160);
            this.lbxProjectsPjan.TabIndex = 0;
            // 
            // tbxNamePjan
            // 
            this.tbxNamePjan.Location = new System.Drawing.Point(9, 174);
            this.tbxNamePjan.Name = "tbxNamePjan";
            this.tbxNamePjan.Size = new System.Drawing.Size(206, 20);
            this.tbxNamePjan.TabIndex = 1;
            // 
            // btnRenamePjan
            // 
            this.btnRenamePjan.Location = new System.Drawing.Point(279, 174);
            this.btnRenamePjan.Name = "btnRenamePjan";
            this.btnRenamePjan.Size = new System.Drawing.Size(75, 20);
            this.btnRenamePjan.TabIndex = 2;
            this.btnRenamePjan.Text = "Rename";
            this.btnRenamePjan.UseVisualStyleBackColor = true;
            this.btnRenamePjan.Click += new System.EventHandler(this.btnRenamePjan_Click);
            // 
            // btnDeletePjan
            // 
            this.btnDeletePjan.Location = new System.Drawing.Point(279, 145);
            this.btnDeletePjan.Name = "btnDeletePjan";
            this.btnDeletePjan.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePjan.TabIndex = 3;
            this.btnDeletePjan.Text = "Delete";
            this.btnDeletePjan.UseVisualStyleBackColor = true;
            this.btnDeletePjan.Click += new System.EventHandler(this.btnDeletePjan_Click);
            // 
            // btnAddPjan
            // 
            this.btnAddPjan.Location = new System.Drawing.Point(221, 174);
            this.btnAddPjan.Name = "btnAddPjan";
            this.btnAddPjan.Size = new System.Drawing.Size(52, 20);
            this.btnAddPjan.TabIndex = 4;
            this.btnAddPjan.Text = "Add";
            this.btnAddPjan.UseVisualStyleBackColor = true;
            this.btnAddPjan.Click += new System.EventHandler(this.btnAddPjan_Click);
            // 
            // btnCategoriesPjan
            // 
            this.btnCategoriesPjan.Location = new System.Drawing.Point(279, 8);
            this.btnCategoriesPjan.Name = "btnCategoriesPjan";
            this.btnCategoriesPjan.Size = new System.Drawing.Size(75, 56);
            this.btnCategoriesPjan.TabIndex = 5;
            this.btnCategoriesPjan.Text = "Manage Categories";
            this.btnCategoriesPjan.UseVisualStyleBackColor = true;
            this.btnCategoriesPjan.Click += new System.EventHandler(this.btnCategoriesPjan_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 204);
            this.Controls.Add(this.btnCategoriesPjan);
            this.Controls.Add(this.btnAddPjan);
            this.Controls.Add(this.btnDeletePjan);
            this.Controls.Add(this.btnRenamePjan);
            this.Controls.Add(this.tbxNamePjan);
            this.Controls.Add(this.lbxProjectsPjan);
            this.Name = "Projects";
            this.Text = "Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProjectsPjan;
        private System.Windows.Forms.TextBox tbxNamePjan;
        private System.Windows.Forms.Button btnRenamePjan;
        private System.Windows.Forms.Button btnDeletePjan;
        private System.Windows.Forms.Button btnAddPjan;
        private System.Windows.Forms.Button btnCategoriesPjan;
    }
}