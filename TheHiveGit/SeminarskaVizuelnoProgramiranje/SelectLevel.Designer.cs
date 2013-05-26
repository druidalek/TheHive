namespace SeminarskaVizuelnoProgramiranje
{
    partial class SelectLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLevel));
            this.pbMenuButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenuButton
            // 
            this.pbMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuButton.Image")));
            this.pbMenuButton.Location = new System.Drawing.Point(632, 12);
            this.pbMenuButton.Name = "pbMenuButton";
            this.pbMenuButton.Size = new System.Drawing.Size(90, 26);
            this.pbMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuButton.TabIndex = 3;
            this.pbMenuButton.TabStop = false;
            this.pbMenuButton.Click += new System.EventHandler(this.pbMenuButton_Click);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(734, 591);
            this.Controls.Add(this.pbMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Level";
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMenuButton;
    }
}