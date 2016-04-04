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
        List<PlayerObject> player = new List<PlayerObject>();
       
        public GameScreen()
        {
            InitializeComponent();
        }
    }
}
