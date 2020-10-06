using System.Windows.Forms;

namespace MeteorDodgersssssss
{
    public partial class HowToPlayScreen : UserControl
    {
        public HowToPlayScreen()
        {
            InitializeComponent();


            outputLabel.Text = "How to Play James Koch Avoider:";
            outputLabel.Text = "\n\nClick left arrow to move character right";
            outputLabel.Text += "\nClick right arrow to move character left";
            outputLabel.Text += "\nMove to avoid the falling James's at all costs";
            outputLabel.Text += "\nIf you get hit by a meteor you lose a heart";
            outputLabel.Text += "\nWhen you have no hearts left you lose";
            outputLabel.Text += "\nTry to get bonus hearts when they fall to get \n an extra heart";
            outputLabel.Text += "\n\nPress escape to return to the main menu";
        }

    }
}

      
