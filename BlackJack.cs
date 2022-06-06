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
            this.AddPlayer(dealer);
            gamecards = new Deck(true);
            Console.WriteLine(gamecards);
        }

        public void PlayGame()
        {
            gamecards.Shuffle();
            while (this.players.Count > 1) // While there's more players than the dealer
            {
                foreach (Player p in this.players.Values)
                {
                    if (p.name == "Dealer")
                    {
                        continue;
                    }
                    for (int dealcount = 1; dealcount <= 2; dealcount++) //deal two cards to each player
                    {
                        p.hand.AddTo(gamecards.Deal());
                    }
                    Console.WriteLine("------------------- " + p.name + " -------------------");
                    Console.WriteLine(p);
                    bool ask = AskPlayer();
                    if (ask)
                    {
                        p.hand.AddTo(gamecards.Deal());
                    }
                }
            }
        }
        public bool AskPlayer() //Returns true for hit, false for stay
        {
            bool result = false;
            Boolean noResponse = true;
            while (noResponse)
            {
                Console.WriteLine("Would you like to hit or stand? (h/s):");

                // Create a string variable and get user input from the keyboard and store it in the variable
                string takeIn = Console.ReadLine();
                
                if (takeIn.ToLower() == "h")
                {
                    result = true;
                    noResponse = false;
                }
                else if(takeIn.ToLower() == "s"){
                    result = false;
                    noResponse = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
            return result;
            
        }

    }
}
