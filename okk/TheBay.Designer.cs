namespace okk
{
    partial class TheBay
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(133, 234);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(300, 106);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy The Bay?";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Leave";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The bay costs $10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "and makes an estimated profit of $100 dollars a day";
            // 
            // TheBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgThebay;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TheBay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}