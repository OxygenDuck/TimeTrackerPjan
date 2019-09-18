namespace TimeTrackerPjan
{
    partial class frmCategoriesPjan
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectNamePjan = new System.Windows.Forms.Label();
            this.lbxCategoriesPjan = new System.Windows.Forms.ListBox();
            this.btnAddPjan = new System.Windows.Forms.Button();
            this.btnDeletePjan = new System.Windows.Forms.Button();
            this.btnRenamePjan = new System.Windows.Forms.Button();
            this.tbxNamePjan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories in:";
            // 
            // lblProjectNamePjan
            // 
            this.lblProjectNamePjan.AutoSize = true;
            this.lblProjectNamePjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectNamePjan.Location = new System.Drawing.Point(75, 9);
            this.lblProjectNamePjan.Name = "lblProjectNamePjan";
            this.lblProjectNamePjan.Size = new System.Drawing.Size(19, 13);
            this.lblProjectNamePjan.TabIndex = 1;
            this.lblProjectNamePjan.Text = "...";
            // 
            // lbxCategoriesPjan
            // 
            this.lbxCategoriesPjan.FormattingEnabled = true;
            this.lbxCategoriesPjan.Location = new System.Drawing.Point(8, 25);
            this.lbxCategoriesPjan.Name = "lbxCategoriesPjan";
            this.lbxCategoriesPjan.Size = new System.Drawing.Size(264, 160);
            this.lbxCategoriesPjan.TabIndex = 2;
            // 
            // btnAddPjan
            // 
            this.btnAddPjan.Location = new System.Drawing.Point(8, 217);
            this.btnAddPjan.Name = "btnAddPjan";
            this.btnAddPjan.Size = new System.Drawing.Size(52, 20);
            this.btnAddPjan.TabIndex = 8;
            this.btnAddPjan.Text = "Add";
            this.btnAddPjan.UseVisualStyleBackColor = true;
            this.btnAddPjan.Click += new System.EventHandler(this.btnAddPjan_Click);
            // 
            // btnDeletePjan
            // 
            this.btnDeletePjan.Location = new System.Drawing.Point(197, 217);
            this.btnDeletePjan.Name = "btnDeletePjan";
            this.btnDeletePjan.Size = new System.Drawing.Size(75, 20);
            this.btnDeletePjan.TabIndex = 7;
            this.btnDeletePjan.Text = "Delete";
            this.btnDeletePjan.UseVisualStyleBackColor = true;
            this.btnDeletePjan.Click += new System.EventHandler(this.btnDeletePjan_Click);
            // 
            // btnRenamePjan
            // 
            this.btnRenamePjan.Location = new System.Drawing.Point(66, 217);
            this.btnRenamePjan.Name = "btnRenamePjan";
            this.btnRenamePjan.Size = new System.Drawing.Size(75, 20);
            this.btnRenamePjan.TabIndex = 6;
            this.btnRenamePjan.Text = "Rename";
            this.btnRenamePjan.UseVisualStyleBackColor = true;
            this.btnRenamePjan.Click += new System.EventHandler(this.btnRenamePjan_Click);
            // 
            // tbxNamePjan
            // 
            this.tbxNamePjan.Location = new System.Drawing.Point(8, 191);
            this.tbxNamePjan.Name = "tbxNamePjan";
            this.tbxNamePjan.Size = new System.Drawing.Size(264, 20);
            this.tbxNamePjan.TabIndex = 5;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 246);
            this.Controls.Add(this.btnAddPjan);
            this.Controls.Add(this.btnDeletePjan);
            this.Controls.Add(this.btnRenamePjan);
            this.Controls.Add(this.tbxNamePjan);
            this.Controls.Add(this.lbxCategoriesPjan);
            this.Controls.Add(this.lblProjectNamePjan);
            this.Controls.Add(this.label1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectNamePjan;
        private System.Windows.Forms.ListBox lbxCategoriesPjan;
        private System.Windows.Forms.Button btnAddPjan;
        private System.Windows.Forms.Button btnDeletePjan;
        private System.Windows.Forms.Button btnRenamePjan;
        private System.Windows.Forms.TextBox tbxNamePjan;
    }
}