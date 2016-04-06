using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Animating_Character_Object
{
    class PlayerObject
    {
        public int x, y, size, speed;
        public Image[] player = new Image[4];

        public PlayerObject(int _x, int _y, int _size, int _speed, Image[] _player)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            player = _player;

        }

        public void move(PlayerObject po, string direction)
        {
            if (direction == "left")
            {
                po.x -= po.speed;
            }
            else if (direction == "right")
            {
                po.x += po.speed;
            }
            else if (direction == "up")
            {
                po.y -= po.speed;
            }
            else if (direction == "down")
            {
                po.y += po.speed;
            }

        }

        public bool collision(PlayerObject po, Monster m)
        {
            Rectangle playerRec = new Rectangle(po.x, po.y, po.size, po.size);
            Rectangle monsterRec = new Rectangle(m.x, m.y, m.size, m.size);

            if (playerRec.IntersectsWith(monsterRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
