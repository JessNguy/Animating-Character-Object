 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Animating_Character_Object
{
    
    class Monster
    {
        public int x, y, size, speed;
        public Image[] monster = new Image[4];

        public Monster(int _x, int _y, int _size, int _speed, Image[] _monster)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            monster = _monster;

         

        }
        
    }
}
