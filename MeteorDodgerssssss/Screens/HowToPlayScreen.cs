using System.Windows.Forms;

namespace MeteorDodgerssssss
{
    public partial class HowToPlayScreen : UserControl
    {
        public HowToPlayScreen()
        {
            InitializeComponent();

            //instructions on how to play are shown
            outputLabel.Text = "How to Play Meteor Dodgers:";
            outputLabel.Text += "\n\nClick left arrow to move character left";
            outputLabel.Text += "\nClick right arrow to move character right";
            outputLabel.Text += "\nMove to avoid the falling meteors at all costs";
            outputLabel.Text += "\nIf you get hit by a meteor you lose a heart";
            outputLabel.Text += "\nWhen you have no hearts left you lose";
            outputLabel.Text += "\nTry to get bonus hearts when they fall to get \n an extra heart";
            outputLabel.Text += "\n\nPress escape to return to the main menu";
        }        

        public void HowToPlayScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //when the escape key is pressed the game ends and goes back to the main menu
            if (e.KeyCode == Keys.Escape)
            {
                MainForm.ChangeScreen(this, "MenuScreen");
            }
        }
    }
}
