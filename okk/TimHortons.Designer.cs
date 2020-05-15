namespace okk
{
    partial class TimHortons
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
            this.leave = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.PictureBox();
            this.btnDonut = new System.Windows.Forms.PictureBox();
            this.btnCroissant = new System.Windows.Forms.PictureBox();
            this.btnSandwich = new System.Windows.Forms.PictureBox();
            this.btnCoffee = new System.Windows.Forms.PictureBox();
            this.foodName = new System.Windows.Forms.Label();
            this.foodInfo = new System.Windows.Forms.Label();
            this.reciept = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDonut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCroissant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSandwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(871, -3);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(101, 52);
            this.leave.TabIndex = 0;
            this.leave.Text = "leave";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // pMenu
            // 
            this.pMenu.Image = global::okk.Properties.Resources.tims_menu;
            this.pMenu.Location = new System.Drawing.Point(60, 242);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(660, 392);
            this.pMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMenu.TabIndex = 1;
            this.pMenu.TabStop = false;
            this.pMenu.Visible = false;
            // 
            // btnDonut
            // 
            this.btnDonut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonut.Image = global::okk.Properties.Resources.tims_items_donut;
            this.btnDonut.Location = new System.Drawing.Point(125, 458);
            this.btnDonut.Name = "btnDonut";
            this.btnDonut.Size = new System.Drawing.Size(99, 100);
            this.btnDonut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDonut.TabIndex = 2;
            this.btnDonut.TabStop = false;
            this.btnDonut.Visible = false;
            this.btnDonut.Click += new System.EventHandler(this.btnDonut_Click);
            this.btnDonut.MouseEnter += new System.EventHandler(this.btnDonut_MouseEnter);
            this.btnDonut.MouseLeave += new System.EventHandler(this.btnDonut_MouseLeave);
            // 
            // btnCroissant
            // 
            this.btnCroissant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCroissant.Image = global::okk.Properties.Resources.tims_items_croissant;
            this.btnCroissant.Location = new System.Drawing.Point(262, 475);
            this.btnCroissant.Name = "btnCroissant";
            this.btnCroissant.Size = new System.Drawing.Size(138, 83);
            this.btnCroissant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCroissant.TabIndex = 3;
            this.btnCroissant.TabStop = false;
            this.btnCroissant.Visible = false;
            this.btnCroissant.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btnCroissant.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.btnCroissant.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.btnCroissant.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // btnSandwich
            // 
            this.btnSandwich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSandwich.Image = global::okk.Properties.Resources.tims_items_sandwich;
            this.btnSandwich.Location = new System.Drawing.Point(422, 470);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(106, 88);
            this.btnSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSandwich.TabIndex = 4;
            this.btnSandwich.TabStop = false;
            this.btnSandwich.Visible = false;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            this.btnSandwich.MouseEnter += new System.EventHandler(this.btnSandwich_MouseEnter);
            this.btnSandwich.MouseLeave += new System.EventHandler(this.btnSandwich_MouseLeave);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.Gray;
            this.btnCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoffee.Image = global::okk.Properties.Resources.tims_items_coffee;
            this.btnCoffee.Location = new System.Drawing.Point(581, 438);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(96, 120);
            this.btnCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCoffee.TabIndex = 5;
            this.btnCoffee.TabStop = false;
            this.btnCoffee.Visible = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            this.btnCoffee.MouseEnter += new System.EventHandler(this.btnCoffee_MouseEnter);
            this.btnCoffee.MouseLeave += new System.EventHandler(this.btnCoffee_MouseLeave);
            // 
            // foodName
            // 
            this.foodName.AutoSize = true;
            this.foodName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.foodName.Font = new System.Drawing.Font("Brush Script Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodName.Location = new System.Drawing.Point(137, 316);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(41, 37);
            this.foodName.TabIndex = 6;
            this.foodName.Text = "  ";
            this.foodName.Visible = false;
            // 
            // foodInfo
            // 
            this.foodInfo.AutoSize = true;
            this.foodInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.foodInfo.Font = new System.Drawing.Font("Brush Script Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodInfo.Location = new System.Drawing.Point(475, 316);
            this.foodInfo.Name = "foodInfo";
            this.foodInfo.Size = new System.Drawing.Size(41, 37);
            this.foodInfo.TabIndex = 7;
            this.foodInfo.Text = "  ";
            this.foodInfo.Visible = false;
            // 
            // reciept
            // 
            this.reciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciept.Font = new System.Drawing.Font("DejaVu Sans Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciept.FormattingEnabled = true;
            this.reciept.ItemHeight = 19;
            this.reciept.Location = new System.Drawing.Point(726, 242);
            this.reciept.Name = "reciept";
            this.reciept.Size = new System.Drawing.Size(207, 401);
            this.reciept.TabIndex = 8;
            this.reciept.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buy something?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(679, -3);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(98, 52);
            this.btnJob.TabIndex = 10;
            this.btnJob.Text = "Apply";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // TimHortons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::okk.Properties.Resources.timhortonsbackground;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reciept);
            this.Controls.Add(this.foodInfo);
            this.Controls.Add(this.foodName);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnSandwich);
            this.Controls.Add(this.btnCroissant);
            this.Controls.Add(this.btnDonut);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.leave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimHortons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimHortons";
            this.Load += new System.EventHandler(this.TimHortons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDonut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCroissant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSandwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.PictureBox pMenu;
        private System.Windows.Forms.PictureBox btnDonut;
        private System.Windows.Forms.PictureBox btnCroissant;
        private System.Windows.Forms.PictureBox btnSandwich;
        private System.Windows.Forms.PictureBox btnCoffee;
        private System.Windows.Forms.Label foodName;
        private System.Windows.Forms.Label foodInfo;
        private System.Windows.Forms.ListBox reciept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJob;
    }
}