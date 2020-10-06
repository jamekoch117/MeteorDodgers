namespace MeteorDodgersssssss
{
    partial class HowToPlayScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.DarkRed;
            this.outputLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.outputLabel.ForeColor = System.Drawing.Color.Yellow;
            this.outputLabel.Location = new System.Drawing.Point(2, 0);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 19);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.outputLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(316, 210);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
    }
}
