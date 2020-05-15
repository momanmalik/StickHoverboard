namespace okk
{
    partial class laGym
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWrkOut = new System.Windows.Forms.Button();
            this.btnApplyJob = new System.Windows.Forms.Button();
            this.btnSpdIncrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(213, 272);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(166, 74);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply for a membership\r\n$100 initiation fee\r\n1$ per day after that\r\nTrainer inclu" +
    "ded to help you gain extra strength";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnWrkOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(561, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 74);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Leave";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWrkOut
            // 
            this.btnWrkOut.Location = new System.Drawing.Point(385, 272);
            this.btnWrkOut.Name = "btnWrkOut";
            this.btnWrkOut.Size = new System.Drawing.Size(166, 74);
            this.btnWrkOut.TabIndex = 2;
            this.btnWrkOut.Text = "Workout for three hours for $5";
            this.btnWrkOut.UseVisualStyleBackColor = true;
            this.btnWrkOut.Click += new System.EventHandler(this.btnWrkOut_Click_1);
            // 
            // btnApplyJob
            // 
            this.btnApplyJob.Location = new System.Drawing.Point(385, 352);
            this.btnApplyJob.Name = "btnApplyJob";
            this.btnApplyJob.Size = new System.Drawing.Size(166, 74);
            this.btnApplyJob.TabIndex = 3;
            this.btnApplyJob.Text = "Apply for Personal Training Position";
            this.btnApplyJob.UseVisualStyleBackColor = true;
            this.btnApplyJob.Click += new System.EventHandler(this.btnApplyJob_Click);
            // 
            // btnSpdIncrease
            // 
            this.btnSpdIncrease.Location = new System.Drawing.Point(385, 192);
            this.btnSpdIncrease.Name = "btnSpdIncrease";
            this.btnSpdIncrease.Size = new System.Drawing.Size(166, 74);
            this.btnSpdIncrease.TabIndex = 4;
            this.btnSpdIncrease.Text = "Increase player speed";
            this.btnSpdIncrease.UseVisualStyleBackColor = true;
            this.btnSpdIncrease.Click += new System.EventHandler(this.btnSpdIncrease_Click);
            // 
            // laGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgGym;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnSpdIncrease);
            this.Controls.Add(this.btnApplyJob);
            this.Controls.Add(this.btnWrkOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laGym";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "laGym";
            this.Load += new System.EventHandler(this.laGym_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWrkOut;
        private System.Windows.Forms.Button btnApplyJob;
        private System.Windows.Forms.Button btnSpdIncrease;
    }
}