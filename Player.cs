using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Player
    {
        int UID;
        bool isPlaying;
        Hand h;

        public Player()
        {
            Random rnd = new Random();
            UID = rnd.Next(0, 9999);
        }
    }
}
