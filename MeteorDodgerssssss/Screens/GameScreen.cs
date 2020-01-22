using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;
using System.Media;

namespace MeteorDodgerssssss
{
    public partial class GameScreen : UserControl
    {
        //player button control keys 
        Boolean leftArrowDown, rightArrowDown;

        //TODO create your global game variables here

        int playerX, playerY, playerSize, playerSpeed, playerHealth, playerScore, playerLevel; //player variables
        int meteorSize, meteorSpeed, meteorDraw; //meteor variables
        int boostSize, boostSpeed, boostDraw; //boost variables
        List<int> meteorsX = new List<int>();
        List<int> meteorsY = new List<int>();
        List<int> boostsX = new List<int>();
        List<int> boostsY = new List<int>();
        SolidBrush playerBrush = new SolidBrush(Color.Blue); //player brush
        SolidBrush meteorBrush = new SolidBrush(Color.DarkRed); //meteor brush
        SolidBrush boostBrush = new SolidBrush(Color.Yellow); //boost brush
        Random randGen = new Random(); //random generator for all random values 
        SoundPlayer boostPlayer = new SoundPlayer(Properties.Resources.Boost);
        SoundPlayer hitPlayer = new SoundPlayer(Properties.Resources.Hit);
        SoundPlayer deathPlayer = new SoundPlayer(Properties.Resources.Death);

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
            ScoreboardValues();
        }

        public void InitializeGameValues()
        {
            //Initial player values 
            playerX = this.Width / 2;
            playerY = this.Height - 30;
            playerSize = 30;
            playerSpeed = 5;
            playerHealth = 100;

            //Initial meteor values 
            meteorsX.Add(randGen.Next(1, this.Width - meteorSize));
            meteorsY.Add(0);
            meteorSize = 30;
            meteorSpeed = 10;

            //Initial boost values
            boostsX.Add(randGen.Next(1, this.Width - meteorSize));
            boostsY.Add(0);
            boostSize = 30;
            boostSpeed = 10;
        }

        public void ScoreboardValues()
        {
            //Scoreboard values at the start of each level
            healthLabel.Text = "Health: " + playerHealth;
            scoreLabel.Text = "Score: " + playerScore;
        }

        public void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Opens a pause screen if escape is pressed. 
            //Depending on what is pressed on pause screen the program will either continue or exit to main menu.
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        public void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move main character 
            if (leftArrowDown == true && playerX > 0)
            {
                playerX = playerX - playerSpeed;
            }
            if (rightArrowDown == true && playerX < this.Width - playerSize)
            {
                playerX = playerX + playerSpeed;
            }

            //add new meteor x and y to meteor lists
            meteorDraw = randGen.Next(1, 10);
            if (meteorDraw == 1)
            {
                meteorsX.Add(randGen.Next(1, this.Width - meteorSize));
                meteorsY.Add(0);
            }

            //move meteors
            for (int i = 0; i < meteorsY.Count(); i++)
            {
                meteorsY[i] = meteorsY[i] + meteorSpeed;
            }

            //make meteors faster if player score surpases a multiple of 100
            if (playerScore / 100 == 0)
            {
                meteorSpeed++;
                break;
            }

            //add new health boost x and y to health boost lists
            boostDraw = randGen.Next(1, 100);
            if (boostDraw == 1)
            {
                boostsX.Add(randGen.Next(1, this.Width - meteorSize));
                boostsY.Add(0);
            }

            //move health boosts
            for (int i = 0; i < boostsY.Count(); i++)
            {
                boostsY[i] = boostsY[i] + boostSpeed;
            }

            //player rectangle to check collisions
            Rectangle playerRec = new Rectangle(playerX, playerY, playerSize, playerSize); 

            //checking to see if the player gets hit by a meteor
            for (int i = 0; i < meteorsX.Count; i++)
            {
                Rectangle meteorRec = new Rectangle(meteorsX[i], meteorsY[i], meteorSize, meteorSize);

                if (playerRec.IntersectsWith(meteorRec))
                {
                    hitPlayer.Play();
                    playerBrush = new SolidBrush(Color.Red);
                    playerHealth = playerHealth - 1;
                    healthLabel.Text = "Health: " + playerHealth;
                    break;
                }
                else
                {
                    playerBrush = new SolidBrush(Color.Blue);
                    playerHealth = playerHealth * 1;
                }
            }

            //checking to see if the player gets hit by a health boost
            for (int i = 0; i < boostsX.Count; i++)
            {
                Rectangle boostRec = new Rectangle(boostsX[i], boostsY[i], boostSize, boostSize);

                if (playerRec.IntersectsWith(boostRec))
                {
                    boostPlayer.Play();
                    playerBrush = new SolidBrush(Color.Yellow);
                    playerHealth = playerHealth + 1;
                    healthLabel.Text = "Health: " + playerHealth;
                    break;
                }
                else
                {
                    playerBrush = new SolidBrush(Color.Blue);
                    playerHealth = playerHealth * 1;
                }
            }

            //remove meteor from list if it goes off the screen
            if (meteorsY[0] > this.Height)
            {
                meteorsX.RemoveAt(0);
                meteorsY.RemoveAt(0);

                //player gets a point because they have not been hit by that meteor
                playerScore = playerScore + 1;
                scoreLabel.Text = "Score: " + playerScore;
            }

            /*remove boost from list if it goes off the screen
            if (boostsY[0] > this.Height && boostsY[1] > this.Height)
            {
                boostsX.RemoveAt(0);
                boostsY.RemoveAt(0);
            }*/

            //stop the game if player health is zero
            if (playerHealth == 0)
            {
                deathPlayer.Play();
                gameTimer.Enabled = false;
            }            

            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw player to screen
            e.Graphics.FillRectangle(playerBrush, playerX, playerY, playerSize, playerSize);

            //draw boost to screen
            for (int i = 0; i < boostsX.Count; i++)
            {
                e.Graphics.FillRectangle(boostBrush, boostsX[i], boostsY[i], boostSize, boostSize);
            }

            //draw meteor to screen
            for (int i = 0; i < meteorsX.Count; i++)
            {
                e.Graphics.FillEllipse(meteorBrush, meteorsX[i], meteorsY[i], meteorSize, meteorSize);
            }
        }
    }

}
