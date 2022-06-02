using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Hand : Deck // Hand extends Deck
    {
        private List<Card> hand; //might not need this 

        public Hand(int size) 
        {
            base(size); //call deck constructor (hand is basically the same thing as a deck)
        }

    }
}
