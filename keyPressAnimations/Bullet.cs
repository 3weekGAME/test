using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace keyPressAnimations
{
    class Bullet
    {
        /*
        Create a Bullet class that contains attributes for x, y, size, speed, and direction
        Create a move method that will move the bullet in the direction it is set to travel.
        */
        public int x, y, size, speed;
        Image[] bullet = new Image[4];
        public int direction;

        public Bullet(int _x, int _y, int _size, int _speed, Image[] _bullet, int _direction)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            bullet = _bullet;
            direction = _direction;
        }

        public void move(Bullet b)
        {
            if (b.direction == 0)
            {
                b.x -= b.speed;
            }
            else if (b.direction == 1)
            {
                b.x += b.speed;
            }
            else if (b.direction == 2)
            {
                b.y -= b.speed;
            }
            else
            {
                b.y += b.speed;
            }

        }
    }
}
