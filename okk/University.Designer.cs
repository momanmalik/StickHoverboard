namespace okk
{
    partial class University
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
            this.btnLecture = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnJobApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(374, 269);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(75, 53);
            this.btnLecture.TabIndex = 0;
            this.btnLecture.Text = "Attend a lecture";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Location = new System.Drawing.Point(213, 269);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(75, 53);
            this.btnTutor.TabIndex = 1;
            this.btnTutor.Text = "Get tutored";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(662, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnJobApply
            // 
            this.btnJobApply.Location = new System.Drawing.Point(513, 269);
            this.btnJobApply.Name = "btnJobApply";
            this.btnJobApply.Size = new System.Drawing.Size(75, 53);
            this.btnJobApply.TabIndex = 3;
            this.btnJobApply.Text = "Apply to be a professor";
            this.btnJobApply.UseVisualStyleBackColor = true;
            this.btnJobApply.Click += new System.EventHandler(this.btnJobApply_Click);
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgUot;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnJobApply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.btnLecture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "University";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "University";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnTutor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnJobApply;
    }
}