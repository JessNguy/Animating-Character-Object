using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animating_Character_Object
{
    class PlayerObject
    {
        public int x, y, size, speed;
        public PlayerObject(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;

        }
    }
}
