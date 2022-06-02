using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Hand
    {
        private List<Card> hand;

        public Hand()
        {
            hand = new List<Card>();
        }
        public void AddTo(Card c)
        {
            hand.Add(c);
        }
    }
}
