using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Animating_Character_Object
{
    class Bullet
    {
        public int x, y, size, speed;

        public string direction;

        public Bullet(int _x, int _y, int _size, int _speed, string _direction)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;

        }

        public void move(Bullet b)
        {
            if (b.direction == "left")
            {
                b.x -= b.speed;
            }
            else if (direction == "right")
            {
                b.x += b.speed;
            }
            else if (direction == "up")
            {
                b.y -= b.speed;
            }
            else if (direction == "down")
            {
                b.y += b.speed;
            }

        }

        public bool collision(Bullet b, Monster m)
        {
            Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle monsterRec = new Rectangle(m.x, m.y, m.size, m.size);

            if (bulletRec.IntersectsWith(monsterRec))
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
