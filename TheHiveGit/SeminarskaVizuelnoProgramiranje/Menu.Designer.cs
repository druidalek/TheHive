namespace SeminarskaVizuelnoProgramiranje
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pbPlayButton = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayButton
            // 
            this.pbPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayButton.Image")));
            this.pbPlayButton.Location = new System.Drawing.Point(60, 200);
            this.pbPlayButton.Name = "pbPlayButton";
            this.pbPlayButton.Size = new System.Drawing.Size(160, 50);
            this.pbPlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayButton.TabIndex = 2;
            this.pbPlayButton.TabStop = false;
            this.pbPlayButton.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SeminarskaVizuelnoProgramiranje.Properties.Resources.TheHiveLogo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(260, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbPlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hive";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayButton;
        private System.Windows.Forms.PictureBox pbLogo;

    }
}

