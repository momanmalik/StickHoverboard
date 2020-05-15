namespace okk
{
    partial class Bank
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
            this.btnDpst = new System.Windows.Forms.Button();
            this.btnWthdrw = new System.Windows.Forms.Button();
            this.btnApplyJob = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDpst
            // 
            this.btnDpst.Location = new System.Drawing.Point(505, 270);
            this.btnDpst.Name = "btnDpst";
            this.btnDpst.Size = new System.Drawing.Size(184, 34);
            this.btnDpst.TabIndex = 0;
            this.btnDpst.Text = "Deposit Money";
            this.btnDpst.UseVisualStyleBackColor = true;
            this.btnDpst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWthdrw
            // 
            this.btnWthdrw.Location = new System.Drawing.Point(695, 273);
            this.btnWthdrw.Name = "btnWthdrw";
            this.btnWthdrw.Size = new System.Drawing.Size(184, 28);
            this.btnWthdrw.TabIndex = 1;
            this.btnWthdrw.Text = "Withdraw Money";
            this.btnWthdrw.UseVisualStyleBackColor = true;
            this.btnWthdrw.Click += new System.EventHandler(this.btnWthdrw_Click);
            // 
            // btnApplyJob
            // 
            this.btnApplyJob.Location = new System.Drawing.Point(83, 341);
            this.btnApplyJob.Name = "btnApplyJob";
            this.btnApplyJob.Size = new System.Drawing.Size(184, 66);
            this.btnApplyJob.TabIndex = 2;
            this.btnApplyJob.Text = "Apply for banktelling position";
            this.btnApplyJob.UseVisualStyleBackColor = true;
            this.btnApplyJob.Click += new System.EventHandler(this.btnApplyJob_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(695, 358);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(184, 66);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(315, 270);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(184, 38);
            this.numAmount.TabIndex = 4;
            this.numAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Savings Account Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(394, 202);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 29);
            this.lblBalance.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount of Money - $";
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okk.Properties.Resources.bgTtd;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnApplyJob);
            this.Controls.Add(this.btnWthdrw);
            this.Controls.Add(this.btnDpst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDpst;
        private System.Windows.Forms.Button btnWthdrw;
        private System.Windows.Forms.Button btnApplyJob;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
    }
}