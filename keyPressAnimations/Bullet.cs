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

        public Bullet(int _x, int _y, int _size, int _speed, Image[] _bullet)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            bullet = _bullet;
        }

        public void move(Bullet b, string direction)
        {
            if (direction == "left")
            {
                b.x -= b.speed;
            }
            else if (direction == "right")
            {
                b.x += b.speed;
            }
            else if (direction == "up")
            {
                b.y += b.speed;
            }
            else
            {
                b.y -= b.speed;
            }

        }
    }
}
