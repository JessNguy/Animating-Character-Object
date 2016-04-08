using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animating_Character_Object
{
    public partial class GameScreen : UserControl
    {
        List<Monster> monsterList = new List<Monster>();
        List<Bullet> bulletList = new List<Bullet>();
        //need a limit for shooting bullets
        //create a direction int and add it to the image array 

        PlayerObject player;

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, shiftDown;

        Image[] tempIsaac = new Image[] { Properties.Resources.IsaacRight,
            Properties.Resources.IsaacLeft,
            Properties.Resources.IsaacUp,
            Properties.Resources.IsaacDown
        };

        Image[] tempMonster = new Image[] { Properties.Resources.monsterRight,
            Properties.Resources.monsterLeft,
            Properties.Resources.monsterUp,
            Properties.Resources.monsterDown
        };
        Image fireBullet = Properties.Resources.fireball;

        int currentX = 0;
        int currentY = 0;
        public static int score = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(player.playerImages[0], player.x, player.y, player.size, player.size);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Focus();

            //creating objects: locations, size, speed, and array

            player = new PlayerObject(currentX, currentY, 15, 4, tempIsaac);
            Monster monster = new Monster(10, 12, 15, 3, tempMonster);
            monsterList.Add(monster);


        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (leftArrowDown)
            {
                player.move(player, "left");
                
            }
            else if (rightArrowDown)
            {
                player.move(player, "right");
            }
            else if (upArrowDown)
            {
                player.move(player, "up");
            }
            else if (downArrowDown)
            {
                player.move(player, "down");
            }

           

            foreach (Monster monster in monsterList)
            {
                if (player.collision(player, monster))
                {
                    gameTimer.Stop();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MainScreen ms = new MainScreen();
                    f.Controls.Add(ms);
                    
                }
            }

            if (shiftDown == true)

            { 
                Bullet fireBall = new Bullet(currentX, currentY, 5, 4, "left", fireBullet);
                bulletList.Add(fireBall);
            }

            //foreach loop that looks at each bullet in bulletList
                  // b.Move(b);
            //foreach loop to look at each monster in the monsterlist
                   //

            Refresh();

            //Need : check bullet list for collison with monster
            //add on to score

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
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
                case Keys.Shift:
                    shiftDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
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
                case Keys.Shift:
                    shiftDown = false;
                    break;
                default:
                    break;
            }
        }
    }
}
