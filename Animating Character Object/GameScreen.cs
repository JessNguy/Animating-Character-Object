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
        PlayerObject player;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

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

        public GameScreen()
        {
            InitializeComponent();

            //creating objects: locations, size, speed, and array
            player = new PlayerObject(4, 6, 15, 4, tempIsaac);
            monsterList[0] = new Monster(10, 12, 15, 3, tempMonster);
        }

        private void GameScreen_Load(object sender, EventArgs e)
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
            Refresh();

            foreach (Monster monsterList in monsterList)
            {
                if (player.collision(player, monsterList))
                {
                   

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //PlayAgain pa = new PlayAgain();
                    //f.Controls.Add(pa);

                }
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
                default:
                    break;
            }
        }
    }
}
