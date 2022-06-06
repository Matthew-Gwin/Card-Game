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
            gamecards = new Deck(true);
            //base.players.AddPlayer(dealer);
        }

        public void PlayGame()
        {
            gamecards.Shuffle();
            while (this.players.Count > 1) // While there's more players than the dealer
            {
                foreach (Player p in this.players.Values)
                {
                    for (int dealcount = 1; dealcount <= 2; dealcount++) //deal two cards to each player
                    {
                        p.hand.AddTo(gamecards.Deal());
                    }
                }
            }
        }

    }
}
