namespace TimeTrackerPjan
{
    partial class frmPopupPjan
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxActivityPjan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDetailsPjan = new System.Windows.Forms.RichTextBox();
            this.btnSavePjan = new System.Windows.Forms.Button();
            this.btnDismissPjan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProjectsPjan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudDismissCounterPjan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDismissMultiplePjan = new System.Windows.Forms.Button();
            this.btnRepeatPjan = new System.Windows.Forms.Button();
            this.cbxCategoryPjan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFilterProjectsPjan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFilterCategoriesPjan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDismissCounterPjan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What are you doing?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "I am:";
            // 
            // tbxActivityPjan
            // 
            this.tbxActivityPjan.Location = new System.Drawing.Point(12, 70);
            this.tbxActivityPjan.Name = "tbxActivityPjan";
            this.tbxActivityPjan.Size = new System.Drawing.Size(209, 20);
            this.tbxActivityPjan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Want to elaborate?";
            // 
            // rtbDetailsPjan
            // 
            this.rtbDetailsPjan.Location = new System.Drawing.Point(12, 221);
            this.rtbDetailsPjan.Name = "rtbDetailsPjan";
            this.rtbDetailsPjan.Size = new System.Drawing.Size(209, 96);
            this.rtbDetailsPjan.TabIndex = 4;
            this.rtbDetailsPjan.Text = "";
            // 
            // btnSavePjan
            // 
            this.btnSavePjan.Location = new System.Drawing.Point(14, 13);
            this.btnSavePjan.Name = "btnSavePjan";
            this.btnSavePjan.Size = new System.Drawing.Size(98, 34);
            this.btnSavePjan.TabIndex = 5;
            this.btnSavePjan.Text = "Save";
            this.btnSavePjan.UseVisualStyleBackColor = true;
            this.btnSavePjan.Click += new System.EventHandler(this.btnSavePjan_Click);
            // 
            // btnDismissPjan
            // 
            this.btnDismissPjan.Location = new System.Drawing.Point(14, 53);
            this.btnDismissPjan.Name = "btnDismissPjan";
            this.btnDismissPjan.Size = new System.Drawing.Size(98, 34);
            this.btnDismissPjan.TabIndex = 6;
            this.btnDismissPjan.Text = "Dismiss";
            this.btnDismissPjan.UseVisualStyleBackColor = true;
            this.btnDismissPjan.Click += new System.EventHandler(this.btnDismissPjan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "For the Project:";
            // 
            // cbxProjectsPjan
            // 
            this.cbxProjectsPjan.FormattingEnabled = true;
            this.cbxProjectsPjan.Location = new System.Drawing.Point(12, 123);
            this.cbxProjectsPjan.Name = "cbxProjectsPjan";
            this.cbxProjectsPjan.Size = new System.Drawing.Size(209, 21);
            this.cbxProjectsPjan.TabIndex = 8;
            this.cbxProjectsPjan.SelectedIndexChanged += new System.EventHandler(this.cbxProjectsPjan_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.nudDismissCounterPjan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDismissMultiplePjan);
            this.panel1.Controls.Add(this.btnRepeatPjan);
            this.panel1.Controls.Add(this.btnSavePjan);
            this.panel1.Controls.Add(this.btnDismissPjan);
            this.panel1.Location = new System.Drawing.Point(-1, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 137);
            this.panel1.TabIndex = 9;
            // 
            // nudDismissCounterPjan
            // 
            this.nudDismissCounterPjan.Location = new System.Drawing.Point(189, 106);
            this.nudDismissCounterPjan.Name = "nudDismissCounterPjan";
            this.nudDismissCounterPjan.Size = new System.Drawing.Size(34, 20);
            this.nudDismissCounterPjan.TabIndex = 10;
            this.nudDismissCounterPjan.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dismiss how many times?";
            // 
            // btnDismissMultiplePjan
            // 
            this.btnDismissMultiplePjan.Location = new System.Drawing.Point(125, 53);
            this.btnDismissMultiplePjan.Name = "btnDismissMultiplePjan";
            this.btnDismissMultiplePjan.Size = new System.Drawing.Size(98, 34);
            this.btnDismissMultiplePjan.TabIndex = 8;
            this.btnDismissMultiplePjan.Text = "Dismiss Multiple";
            this.btnDismissMultiplePjan.UseVisualStyleBackColor = true;
            this.btnDismissMultiplePjan.Click += new System.EventHandler(this.btnDismissMultiplePjan_Click);
            // 
            // btnRepeatPjan
            // 
            this.btnRepeatPjan.Location = new System.Drawing.Point(125, 13);
            this.btnRepeatPjan.Name = "btnRepeatPjan";
            this.btnRepeatPjan.Size = new System.Drawing.Size(98, 34);
            this.btnRepeatPjan.TabIndex = 7;
            this.btnRepeatPjan.Text = "Repeat Last";
            this.btnRepeatPjan.UseVisualStyleBackColor = true;
            this.btnRepeatPjan.Click += new System.EventHandler(this.btnRepeatPjan_Click);
            // 
            // cbxCategoryPjan
            // 
            this.cbxCategoryPjan.FormattingEnabled = true;
            this.cbxCategoryPjan.Location = new System.Drawing.Point(12, 162);
            this.cbxCategoryPjan.Name = "cbxCategoryPjan";
            this.cbxCategoryPjan.Size = new System.Drawing.Size(209, 21);
            this.cbxCategoryPjan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specifically, the category:";
            // 
            // tbxFilterProjectsPjan
            // 
            this.tbxFilterProjectsPjan.Location = new System.Drawing.Point(227, 123);
            this.tbxFilterProjectsPjan.Name = "tbxFilterProjectsPjan";
            this.tbxFilterProjectsPjan.Size = new System.Drawing.Size(184, 20);
            this.tbxFilterProjectsPjan.TabIndex = 12;
            this.tbxFilterProjectsPjan.TextChanged += new System.EventHandler(this.tbxFilterProjectsPjan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filter";
            // 
            // tbxFilterCategoriesPjan
            // 
            this.tbxFilterCategoriesPjan.Location = new System.Drawing.Point(227, 162);
            this.tbxFilterCategoriesPjan.Name = "tbxFilterCategoriesPjan";
            this.tbxFilterCategoriesPjan.Size = new System.Drawing.Size(184, 20);
            this.tbxFilterCategoriesPjan.TabIndex = 14;
            this.tbxFilterCategoriesPjan.TextChanged += new System.EventHandler(this.tbxFilterCategoriesPjan_TextChanged);
            // 
            // frmPopupPjan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 469);
            this.Controls.Add(this.tbxFilterCategoriesPjan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxFilterProjectsPjan);
            this.Controls.Add(this.cbxCategoryPjan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxProjectsPjan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDetailsPjan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxActivityPjan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPopupPjan";
            this.Text = "Timetracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDismissCounterPjan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxActivityPjan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDetailsPjan;
        private System.Windows.Forms.Button btnSavePjan;
        private System.Windows.Forms.Button btnDismissPjan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProjectsPjan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudDismissCounterPjan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDismissMultiplePjan;
        private System.Windows.Forms.Button btnRepeatPjan;
        private System.Windows.Forms.ComboBox cbxCategoryPjan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFilterProjectsPjan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFilterCategoriesPjan;
    }
}

