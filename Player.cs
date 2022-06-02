using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Player
    {
        private int UID { get; set; }
        private bool isPlaying { get; set; }
        private Hand hand { get; set; }

        public Player()
        {
            Random rnd = new Random();
            this.UID = rnd.Next(0, 9999);
            this.isPlaying = true;
            this.hand = new Hand();
        }
    }
}
