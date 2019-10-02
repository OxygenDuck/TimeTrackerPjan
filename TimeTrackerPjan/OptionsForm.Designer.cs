namespace TimeTrackerPjan
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnResetPjan = new System.Windows.Forms.Button();
            this.btnSavePjan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudIntervalPjan = new System.Windows.Forms.NumericUpDown();
            this.btnSaveLogPjan = new System.Windows.Forms.Button();
            this.mnsMenuStripPjan = new System.Windows.Forms.MenuStrip();
            this.mniAboutPjan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniManualPjan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniVersionPjan = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalPjan)).BeginInit();
            this.mnsMenuStripPjan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetPjan
            // 
            this.btnResetPjan.Location = new System.Drawing.Point(195, 218);
            this.btnResetPjan.Name = "btnResetPjan";
            this.btnResetPjan.Size = new System.Drawing.Size(81, 31);
            this.btnResetPjan.TabIndex = 0;
            this.btnResetPjan.Text = "Reset Default";
            this.btnResetPjan.UseVisualStyleBackColor = true;
            this.btnResetPjan.Click += new System.EventHandler(this.btnResetPjan_Click);
            // 
            // btnSavePjan
            // 
            this.btnSavePjan.Location = new System.Drawing.Point(111, 218);
            this.btnSavePjan.Name = "btnSavePjan";
            this.btnSavePjan.Size = new System.Drawing.Size(81, 31);
            this.btnSavePjan.TabIndex = 1;
            this.btnSavePjan.Text = "OK and Exit";
            this.btnSavePjan.UseVisualStyleBackColor = true;
            this.btnSavePjan.Click += new System.EventHandler(this.btnSavePjan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval between popups (in minutes)";
            // 
            // nudIntervalPjan
            // 
            this.nudIntervalPjan.Location = new System.Drawing.Point(198, 28);
            this.nudIntervalPjan.Name = "nudIntervalPjan";
            this.nudIntervalPjan.Size = new System.Drawing.Size(78, 20);
            this.nudIntervalPjan.TabIndex = 3;
            this.nudIntervalPjan.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSaveLogPjan
            // 
            this.btnSaveLogPjan.Location = new System.Drawing.Point(12, 218);
            this.btnSaveLogPjan.Name = "btnSaveLogPjan";
            this.btnSaveLogPjan.Size = new System.Drawing.Size(81, 31);
            this.btnSaveLogPjan.TabIndex = 4;
            this.btnSaveLogPjan.Text = "Save Log";
            this.btnSaveLogPjan.UseVisualStyleBackColor = true;
            this.btnSaveLogPjan.Click += new System.EventHandler(this.btnSaveLogPjan_Click);
            // 
            // mnsMenuStripPjan
            // 
            this.mnsMenuStripPjan.BackColor = System.Drawing.SystemColors.Control;
            this.mnsMenuStripPjan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAboutPjan});
            this.mnsMenuStripPjan.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuStripPjan.Name = "mnsMenuStripPjan";
            this.mnsMenuStripPjan.Size = new System.Drawing.Size(284, 24);
            this.mnsMenuStripPjan.TabIndex = 5;
            this.mnsMenuStripPjan.Text = "menuStrip1";
            // 
            // mniAboutPjan
            // 
            this.mniAboutPjan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniManualPjan,
            this.mniVersionPjan});
            this.mniAboutPjan.Name = "mniAboutPjan";
            this.mniAboutPjan.Size = new System.Drawing.Size(52, 20);
            this.mniAboutPjan.Text = "About";
            // 
            // mniManualPjan
            // 
            this.mniManualPjan.Name = "mniManualPjan";
            this.mniManualPjan.Size = new System.Drawing.Size(188, 22);
            this.mniManualPjan.Text = "Manual";
            this.mniManualPjan.Click += new System.EventHandler(this.mniManualPjan_Click);
            // 
            // mniVersionPjan
            // 
            this.mniVersionPjan.Name = "mniVersionPjan";
            this.mniVersionPjan.Size = new System.Drawing.Size(188, 22);
            this.mniVersionPjan.Text = "Version Release Notes";
            this.mniVersionPjan.Click += new System.EventHandler(this.mniVersionPjan_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSaveLogPjan);
            this.Controls.Add(this.nudIntervalPjan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePjan);
            this.Controls.Add(this.btnResetPjan);
            this.Controls.Add(this.mnsMenuStripPjan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenuStripPjan;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalPjan)).EndInit();
            this.mnsMenuStripPjan.ResumeLayout(false);
            this.mnsMenuStripPjan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPjan;
        private System.Windows.Forms.Button btnSavePjan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudIntervalPjan;
        private System.Windows.Forms.Button btnSaveLogPjan;
        private System.Windows.Forms.MenuStrip mnsMenuStripPjan;
        private System.Windows.Forms.ToolStripMenuItem mniAboutPjan;
        private System.Windows.Forms.ToolStripMenuItem mniVersionPjan;
        private System.Windows.Forms.ToolStripMenuItem mniManualPjan;
    }
}