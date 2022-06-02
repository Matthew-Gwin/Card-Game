using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Player
    {
        private string name { get; set; }
        private int UID { get; set; }
        private bool isPlaying { get; set; }
        private Hand hand { get; set; }

        public Player(string playerName)
        {
            Random rnd = new Random();
            this.UID = rnd.Next(0, 99999);
            this.isPlaying = true;
            this.hand = new Hand();
            this.name = playerName;
        }
    }
}
