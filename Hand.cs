using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Hand : Deck // Hand extends Deck
    {
        private List<Card> hand;

        public Hand()
        {
            hand = new List<Card>();
        }

    }
}
