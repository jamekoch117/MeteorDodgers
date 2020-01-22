namespace MeteorDodgerssssss
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.LightGray;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.scoreLabel.Location = new System.Drawing.Point(313, 49);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(341, 49);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.Color.LightGray;
            this.healthLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.healthLabel.Location = new System.Drawing.Point(0, 49);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(322, 49);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health:";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.titleLabel.Location = new System.Drawing.Point(0, -10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(653, 59);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Meteor Dodgers";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.DarkRed;
            this.retryButton.Enabled = false;
            this.retryButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.retryButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.retryButton.ForeColor = System.Drawing.Color.Yellow;
            this.retryButton.Location = new System.Drawing.Point(223, 272);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(176, 60);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "Play Again";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.RetryButton_Click);
            this.retryButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DarkRed;
            this.quitButton.Enabled = false;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.quitButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.quitButton.ForeColor = System.Drawing.Color.Yellow;
            this.quitButton.Location = new System.Drawing.Point(223, 378);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(176, 60);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(653, 617);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button quitButton;
    }
}
