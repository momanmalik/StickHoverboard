namespace okk
{
    partial class Google
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
            this.btnApplyJob = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplyJob
            // 
            this.btnApplyJob.Location = new System.Drawing.Point(172, 384);
            this.btnApplyJob.Name = "btnApplyJob";
            this.btnApplyJob.Size = new System.Drawing.Size(262, 33);
            this.btnApplyJob.TabIndex = 0;
            this.btnApplyJob.Text = "Apply";
            this.btnApplyJob.UseVisualStyleBackColor = true;
            this.btnApplyJob.Click += new System.EventHandler(this.btnApplyJob_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(761, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 69);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Google
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgGoogle;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApplyJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Google";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplyJob;
        private System.Windows.Forms.Button btnExit;
    }
}