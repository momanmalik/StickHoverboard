namespace okk
{
    partial class PoliceStation
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
            this.btnJobApply = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJobApply
            // 
            this.btnJobApply.Location = new System.Drawing.Point(295, 416);
            this.btnJobApply.Name = "btnJobApply";
            this.btnJobApply.Size = new System.Drawing.Size(135, 73);
            this.btnJobApply.TabIndex = 0;
            this.btnJobApply.Text = "Apply";
            this.btnJobApply.UseVisualStyleBackColor = true;
            this.btnJobApply.Click += new System.EventHandler(this.btnJobApply_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(628, 292);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(135, 73);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // PoliceStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgPolice;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJobApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoliceStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PoliceStation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJobApply;
        private System.Windows.Forms.Button btnLeave;
    }
}