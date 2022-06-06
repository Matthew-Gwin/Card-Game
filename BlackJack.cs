using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    internal class BlackJack : Game
    {

        private Deck gamecards;

        public BlackJack() : base() //Extends game
        {
            Player dealer = new Player("Dealer"); //Blackjack always has a dealer
            
            //base.players.AddPlayer(dealer);
        } 

    }
}
