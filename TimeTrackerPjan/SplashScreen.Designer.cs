namespace TimeTrackerPjan
{
    partial class SplashScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersionPjan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrDissapearPjan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Tracker";
            // 
            // lblVersionPjan
            // 
            this.lblVersionPjan.AutoSize = true;
            this.lblVersionPjan.Location = new System.Drawing.Point(459, 251);
            this.lblVersionPjan.Name = "lblVersionPjan";
            this.lblVersionPjan.Size = new System.Drawing.Size(49, 13);
            this.lblVersionPjan.TabIndex = 1;
            this.lblVersionPjan.Text = "Version#";
            this.lblVersionPjan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A tool by Peter Janssen";
            // 
            // tmrDissapearPjan
            // 
            this.tmrDissapearPjan.Enabled = true;
            this.tmrDissapearPjan.Interval = 5000;
            this.tmrDissapearPjan.Tick += new System.EventHandler(this.tmrDissapearPjan_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVersionPjan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersionPjan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrDissapearPjan;
    }
}