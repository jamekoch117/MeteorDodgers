﻿using System.Drawing;
using System.Windows.Forms;

namespace MeteorDodgerssssss
{
    public partial class MainForm : Form
    {
        bool fullScreen = true;  // true: program runs fullscreen || false: program runs in window

        public MainForm()
        {
            InitializeComponent();

            Cursor.Hide();

            // open the main menu for the game
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            this.WindowState = FormWindowState.Maximized;
            #region open in full screen or not
            if (fullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                int screenWidthh = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                // centre the new screen in the middle of the form
                ms.Location = new Point((screenWidthh - ms.Width) / 2, (screenHeight - ms.Height) / 2);
            }
            else
            {
                // centre the new screen in the middle of the form
                ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            }
            #endregion
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

        }

        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            //all main screens
            switch (next)
            {
                case "MenuScreen":
                    ns = new MenuScreen();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
               
            }

            //centres the control on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}
