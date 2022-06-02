using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Hand : Deck // Hand extends Deck
    {
        private List<Card> hand;

        public Hand(int size) //need to use super constructor from deck 
        {
            hand = new List<Card>();
        }

    }
}
