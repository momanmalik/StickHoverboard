namespace okk
{
    partial class CreateCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCharacter));
            this.panCharCreate = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rollBtn = new System.Windows.Forms.Button();
            this.txtChrm = new System.Windows.Forms.TextBox();
            this.txtIntel = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panCharCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panCharCreate
            // 
            this.panCharCreate.Controls.Add(this.label6);
            this.panCharCreate.Controls.Add(this.btnPlay);
            this.panCharCreate.Controls.Add(this.rollBtn);
            this.panCharCreate.Controls.Add(this.txtChrm);
            this.panCharCreate.Controls.Add(this.txtIntel);
            this.panCharCreate.Controls.Add(this.txtStr);
            this.panCharCreate.Controls.Add(this.label5);
            this.panCharCreate.Controls.Add(this.txtName);
            this.panCharCreate.Controls.Add(this.label4);
            this.panCharCreate.Controls.Add(this.label3);
            this.panCharCreate.Controls.Add(this.label2);
            this.panCharCreate.Location = new System.Drawing.Point(12, 99);
            this.panCharCreate.Name = "panCharCreate";
            this.panCharCreate.Size = new System.Drawing.Size(769, 550);
            this.panCharCreate.TabIndex = 0;
            this.panCharCreate.Paint += new System.Windows.Forms.PaintEventHandler(this.panCharCreate_Paint);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlay.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.Location = new System.Drawing.Point(612, 459);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(144, 77);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rollBtn
            // 
            this.rollBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.rollBtn.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.rollBtn.Location = new System.Drawing.Point(413, 459);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(184, 77);
            this.rollBtn.TabIndex = 9;
            this.rollBtn.Text = "ROLL";
            this.rollBtn.UseVisualStyleBackColor = false;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // txtChrm
            // 
            this.txtChrm.Enabled = false;
            this.txtChrm.Font = new System.Drawing.Font("TYPOGRAPH PRO", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtChrm.Location = new System.Drawing.Point(612, 350);
            this.txtChrm.Name = "txtChrm";
            this.txtChrm.Size = new System.Drawing.Size(126, 45);
            this.txtChrm.TabIndex = 8;
            // 
            // txtIntel
            // 
            this.txtIntel.Enabled = false;
            this.txtIntel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtIntel.Location = new System.Drawing.Point(612, 265);
            this.txtIntel.Name = "txtIntel";
            this.txtIntel.Size = new System.Drawing.Size(126, 45);
            this.txtIntel.TabIndex = 7;
            // 
            // txtStr
            // 
            this.txtStr.Enabled = false;
            this.txtStr.Font = new System.Drawing.Font("TYPOGRAPH PRO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStr.Location = new System.Drawing.Point(612, 182);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(126, 45);
            this.txtStr.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(7, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(632, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "CHARISMA:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("TYPOGRAPH PRO", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(539, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 45);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(7, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(632, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "INTELLIGENCE:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(7, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(632, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "STRENGTH";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHARACTER CREATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(986, 74);
            this.label6.TabIndex = 11;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::okk.Properties.Resources.dancing;
            this.pictureBox1.Location = new System.Drawing.Point(778, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panCharCreate);
            this.Controls.Add(this.label1);
            this.Name = "CreateCharacter";
            this.Text = "Create Character";
            this.panCharCreate.ResumeLayout(false);
            this.panCharCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCharCreate;
        private System.Windows.Forms.TextBox txtChrm;
        private System.Windows.Forms.TextBox txtIntel;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}