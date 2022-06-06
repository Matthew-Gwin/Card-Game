using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    internal class Hand : Deck // Hand extends Deck
    {
        //private List<Card> hand; //might not need this 
        
        public Hand() : base(false) { }        //call deck constructor (hand is basically the same thing as a deck) to create blank Hand
    

    }
}
