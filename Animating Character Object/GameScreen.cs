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

        Image[] tempImages = new Image[] { Properties.Resources.IsaacRight,
            Properties.Resources.IsaacLeft,
            Properties.Resources.IsaacUp,
            Properties.Resources.IsaacDown
        };
       
        public GameScreen()
        {
            InitializeComponent();
            player = new PlayerObject(4, 6, 5, 4, tempImages);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
