namespace okk
{
    partial class Hospital
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
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnJobApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(192, 247);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(100, 127);
            this.btnDoc.TabIndex = 0;
            this.btnDoc.Text = "See a doctor";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnJobApply
            // 
            this.btnJobApply.Location = new System.Drawing.Point(427, 247);
            this.btnJobApply.Name = "btnJobApply";
            this.btnJobApply.Size = new System.Drawing.Size(98, 127);
            this.btnJobApply.TabIndex = 1;
            this.btnJobApply.Text = "Apply to be a doctor";
            this.btnJobApply.UseVisualStyleBackColor = true;
            this.btnJobApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(659, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 127);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgHospital;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJobApply);
            this.Controls.Add(this.btnDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hospital";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnJobApply;
        private System.Windows.Forms.Button btnExit;
    }
}