namespace MeteorDodgerssssss
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.exitButton.ForeColor = System.Drawing.Color.Yellow;
            this.exitButton.Location = new System.Drawing.Point(278, 215);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkRed;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.playButton.ForeColor = System.Drawing.Color.Yellow;
            this.playButton.Location = new System.Drawing.Point(79, 215);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(195, 39);
            this.playButton.TabIndex = 1;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(544, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
    }
}
