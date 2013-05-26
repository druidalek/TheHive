namespace SeminarskaVizuelnoProgramiranje
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbMenuButton = new System.Windows.Forms.PictureBox();
            this.lblLevelPassed = new System.Windows.Forms.Label();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenuButton
            // 
            this.pbMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuButton.Image")));
            this.pbMenuButton.Location = new System.Drawing.Point(479, 12);
            this.pbMenuButton.Name = "pbMenuButton";
            this.pbMenuButton.Size = new System.Drawing.Size(123, 26);
            this.pbMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuButton.TabIndex = 2;
            this.pbMenuButton.TabStop = false;
            this.pbMenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // lblLevelPassed
            // 
            this.lblLevelPassed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLevelPassed.Font = new System.Drawing.Font("Arial Black", 16F);
            this.lblLevelPassed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.lblLevelPassed.Location = new System.Drawing.Point(0, 541);
            this.lblLevelPassed.Name = "lblLevelPassed";
            this.lblLevelPassed.Size = new System.Drawing.Size(614, 50);
            this.lblLevelPassed.TabIndex = 3;
            this.lblLevelPassed.Text = "Level Passed";
            this.lblLevelPassed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLevelPassed.Visible = false;
            // 
            // pbRestart
            // 
            this.pbRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestart.Image = ((System.Drawing.Image)(resources.GetObject("pbRestart.Image")));
            this.pbRestart.Location = new System.Drawing.Point(462, 44);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(140, 26);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestart.TabIndex = 4;
            this.pbRestart.TabStop = false;
            this.pbRestart.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHint.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.lblHint.Location = new System.Drawing.Point(450, 550);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(152, 31);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "Hint in 0:30";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(614, 591);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.pbRestart);
            this.Controls.Add(this.lblLevelPassed);
            this.Controls.Add(this.pbMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox pbMenuButton;
        private System.Windows.Forms.Label lblLevelPassed;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.Label lblHint;
    }
}