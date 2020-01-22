namespace MeteorDodgerssssss
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
            this.outputLabel.Location = new System.Drawing.Point(3, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 38);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.outputLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(588, 508);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HowToPlayScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
    }
}
