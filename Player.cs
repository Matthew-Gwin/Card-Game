using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Player
    {
        private string name { get; }
        private int UID { get; set; }
        private bool isPlaying { get; set; }
        private Hand hand { get; set; }
        public Player(string playerName)
        {

            this.isPlaying = true;
            this.hand = new Hand();
            this.name = playerName;
        }
    }
}
