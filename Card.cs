using System;
using System.Collections;
using System.Text;

namespace Card_Game
{
    class Card
    {
        private int value { get; set; }
        private string suit { get; set; }
        private char rank { get; set; }

        public Card(char rank, string suit, int value )
        {
            this.value = value;
            this.suit = suit;
            this.rank = rank;
        }
        public override String ToString()
        {
            return this.rank + " of " + this.suit + " " + this.value;
        }


    }


}
