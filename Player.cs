using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Player
    {
        private int UID;
        private bool isPlaying;
        private Hand h;

        public Player()
        {
            Random rnd = new Random();
            UID = rnd.Next(0, 9999);
            this.isPlaying = true;
            h = new Hand();
        }
    }
}
