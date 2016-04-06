using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyPressAnimations
{
    public partial class GameScreen : UserControl
    {

        
        #region old code
        /*
                //create graphic objects
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                

                private void gameTimer_Tick(object sender, EventArgs e)
                {
                    //checks to see if any keys have been pressed and adjusts the X or Y value
                    //for the rectangle appropriately
                    if (leftArrowDown == true)
                    {
                        drawX--;
                        direction = 0;
                    }
                    if (downArrowDown == true)
                    {
                        drawY++;
                        direction = 3;
                    }
                    if (rightArrowDown == true)
                    {
                        drawX++;
                        direction = 1;
                    }
                    if (upArrowDown == true)
                    {
                        drawY--;
                        direction = 2;
                    }

                    //refresh the screen, which causes the Form1_Paint method to run
                    Refresh();

                }

                private void Form1_Paint(object sender, PaintEventArgs e)
                {
                    e.Graphics.DrawImage(character[direction], drawX, drawY);
                }
                */
        #endregion

        public GameScreen()
        {
            InitializeComponent();

            //start the timer when the program starts
            gameTimer.Enabled = true;
            gameTimer.Start();
        }



        //determines whether a key is being pressed or not
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        //TODO Create global player object, monsters List, and bulletsList
        Player P;
        List<Monster> monsters = new List<Monster>();
        List<Bullet> bullets = new List<Bullet>();
        Image[] character = {Properties.Resources.left, Properties.Resources.right,
            Properties.Resources.up, Properties.Resources.down};

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO set the hero object with the initial start values that you want.
            P = new Player(100, 200, 10, 10, character);

            //TODO Create a monster object and add it to the monsters List.
            //monsters.Add();
            //Animating Character Objects ICS4C/4U


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            #region Check button presses for player movement.
            //checks to see if any keys have been pressed and adjusts the X or Y value appropriately
            if (leftArrowDown == true)
            {
                P.move(P, "left");
            }
            if (downArrowDown == true)
            {
                P.move(P, "down");
            }
            if (rightArrowDown == true)
            {
                P.move(P, "right");
            }
            if (upArrowDown == true)
            {
                P.move(P, "up");
            }

            //refresh the screen, which causes the Form1_Paint method to run
            Refresh();
            #endregion

            //TODO Check button press(s) for bullet fire. If the user selects to fire a bullet create a new
            //bullet object and place it in the bullet List.Remember the direction variable indicates
            //which direction the bullet will constantly move in.

            //TODO Check to see if it is time to generate a new monster.This can be done on a regular
            //interval or upon some other event.

            //TODO Check collision between all monsters and the player character. If a monster touches
            //the player display a game over screen.

            //TODO Check collision between bullets and monsters. If a bullet hits a monster the bullet
            //and the monster are removed from their respective lists.
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //TODO draw everything on the screen
            e.Graphics.DrawImage(character[0], P.x, P.y);
        }

    }
}
