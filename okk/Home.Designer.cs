namespace okk
{
    partial class badHome
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
            this.btnSleep = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(222, 287);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(224, 102);
            this.btnSleep.TabIndex = 0;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "Leave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // badHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.apartmenthome;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSleep);
            this.Name = "badHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button button2;
    }
}