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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveExpectedPjan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinutesExpPjan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoursExpPjan = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursSpentPjan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinutesSpentPjan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMinutesDifPjan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHoursDifPjan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesExpPjan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursExpPjan)).BeginInit();
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
            this.lbxCategoriesPjan.SelectedIndexChanged += new System.EventHandler(this.lbxCategoriesPjan_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblMinutesDifPjan);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblHoursDifPjan);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblMinutesSpentPjan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblHoursSpentPjan);
            this.panel1.Controls.Add(this.btnSaveExpectedPjan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudMinutesExpPjan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudHoursExpPjan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(281, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 250);
            this.panel1.TabIndex = 9;
            // 
            // btnSaveExpectedPjan
            // 
            this.btnSaveExpectedPjan.Location = new System.Drawing.Point(6, 78);
            this.btnSaveExpectedPjan.Name = "btnSaveExpectedPjan";
            this.btnSaveExpectedPjan.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExpectedPjan.TabIndex = 6;
            this.btnSaveExpectedPjan.Text = "Save";
            this.btnSaveExpectedPjan.UseVisualStyleBackColor = true;
            this.btnSaveExpectedPjan.Click += new System.EventHandler(this.btnSaveExpectedPjan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Spent time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minutes";
            // 
            // nudMinutesExpPjan
            // 
            this.nudMinutesExpPjan.Location = new System.Drawing.Point(6, 52);
            this.nudMinutesExpPjan.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutesExpPjan.Name = "nudMinutesExpPjan";
            this.nudMinutesExpPjan.Size = new System.Drawing.Size(120, 20);
            this.nudMinutesExpPjan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours";
            // 
            // nudHoursExpPjan
            // 
            this.nudHoursExpPjan.Location = new System.Drawing.Point(6, 26);
            this.nudHoursExpPjan.Name = "nudHoursExpPjan";
            this.nudHoursExpPjan.Size = new System.Drawing.Size(120, 20);
            this.nudHoursExpPjan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expected time for category";
            // 
            // lblHoursSpentPjan
            // 
            this.lblHoursSpentPjan.AutoSize = true;
            this.lblHoursSpentPjan.Location = new System.Drawing.Point(3, 126);
            this.lblHoursSpentPjan.Name = "lblHoursSpentPjan";
            this.lblHoursSpentPjan.Size = new System.Drawing.Size(16, 13);
            this.lblHoursSpentPjan.TabIndex = 7;
            this.lblHoursSpentPjan.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Minutes";
            // 
            // lblMinutesSpentPjan
            // 
            this.lblMinutesSpentPjan.AutoSize = true;
            this.lblMinutesSpentPjan.Location = new System.Drawing.Point(3, 147);
            this.lblMinutesSpentPjan.Name = "lblMinutesSpentPjan";
            this.lblMinutesSpentPjan.Size = new System.Drawing.Size(16, 13);
            this.lblMinutesSpentPjan.TabIndex = 9;
            this.lblMinutesSpentPjan.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Minutes";
            // 
            // lblMinutesDifPjan
            // 
            this.lblMinutesDifPjan.AutoSize = true;
            this.lblMinutesDifPjan.Location = new System.Drawing.Point(3, 209);
            this.lblMinutesDifPjan.Name = "lblMinutesDifPjan";
            this.lblMinutesDifPjan.Size = new System.Drawing.Size(16, 13);
            this.lblMinutesDifPjan.TabIndex = 14;
            this.lblMinutesDifPjan.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Hours";
            // 
            // lblHoursDifPjan
            // 
            this.lblHoursDifPjan.AutoSize = true;
            this.lblHoursDifPjan.Location = new System.Drawing.Point(3, 188);
            this.lblHoursDifPjan.Name = "lblHoursDifPjan";
            this.lblHoursDifPjan.Size = new System.Drawing.Size(16, 13);
            this.lblHoursDifPjan.TabIndex = 12;
            this.lblHoursDifPjan.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Difference";
            // 
            // frmCategoriesPjan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 246);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPjan);
            this.Controls.Add(this.btnDeletePjan);
            this.Controls.Add(this.btnRenamePjan);
            this.Controls.Add(this.tbxNamePjan);
            this.Controls.Add(this.lbxCategoriesPjan);
            this.Controls.Add(this.lblProjectNamePjan);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoriesPjan";
            this.Text = "Categories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesExpPjan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursExpPjan)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveExpectedPjan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinutesExpPjan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoursExpPjan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMinutesSpentPjan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHoursSpentPjan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMinutesDifPjan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHoursDifPjan;
        private System.Windows.Forms.Label label12;
    }
}