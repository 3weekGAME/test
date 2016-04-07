using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace keyPressAnimations
{
    class Player
    {
        /*
         Create a Player class that contains attributes for x, y, size, speed, and an image array that
         can hold 4 images, (one for each direction).
         Create a move method that allows for movement in all 4 directions
         Create a collision method that will check for collision between Player and Monster
        */
        public int x, y, size, speed;
        public string direction;
        Image[] player = new Image[4];

        public Player(int _x, int _y, int _size, int _speed, Image[] _player)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            player = _player;
        }

        public void move(Player p, string _direction)
        {
            direction = _direction;

            if (direction == "left")
            {
                p.x -= p.speed;
            }
            else if (direction == "right")
            {
                p.x += p.speed;
            }
            else if (direction == "up")
            {
                p.y -= p.speed;
            }
            else
            {
                p.y += p.speed;
            }

        }

        public bool collision(Player p, Monster m)
        {
            Rectangle pRec = new Rectangle(p.x, p.y, p.size, p.size);
            Rectangle mRec = new Rectangle(m.x, m.y, m.size, m.size);

            if (pRec.IntersectsWith(mRec))
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