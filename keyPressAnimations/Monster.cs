using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace keyPressAnimations
{
    class Monster
    {
        /*
        Create a Monster class that contains attributes for x, y, size, speed, and an image array
        that can hold 4 images, (one for each direction).
        Create a move method that allows for movement in all 4 directions
        Create a collision method that will check for collision between Monster and Bullets
        */
        public int x, y, size, speed;
        public string direction;
        Image[] monster = new Image[4];

        public Monster(int _x, int _y, int _size, int _speed, Image[] _monster)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            monster = _monster;
        }

        public void move(Monster m, string _direction)
        {
            direction = _direction;

            if (direction == "left")
            {
                m.x -= m.speed;
            }
            else if (direction == "right")
            {
                m.x += m.speed;
            }
            else if (direction == "up")
            {
                m.y += m.speed;
            }
            else
            {
                m.y -= m.speed;
            }

        }

        public bool collision(Monster m, Bullet b)
        {
            Rectangle bRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle mRec = new Rectangle(m.x, m.y, m.size, m.size);

            if (bRec.IntersectsWith(mRec))
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
