using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    internal class BlackJack : Game
    {

        private Deck gamecards;

        private Player dealer;
        public Dictionary<int, Player> standing;
        
        public BlackJack() : base() //Extends game
        {
            standing = new Dictionary<int, Player>();
            dealer = new Player("Dealer"); //Blackjack always has a dealer
            this.AddPlayer(dealer);
            gamecards = new Deck(true);
            //Console.WriteLine(gamecards);
        }

        public void PlayGame()
        {
            //int numDone = 0; 
            for (int i = 0; i < 10; i++)
            {
                gamecards.Shuffle();
            }

            while (true) // While there's more players than the dealer
            {
                if (this.players.Count == 1) //only dealer left
                {
                    Automatic_Play(dealer);
                    break;
                }
                //Console.WriteLine(numDone);
                
                foreach (Player p in this.players.Values)
                {
                    if (p.hand.cards.Count == 0)
                    {
                        for (int dealcount = 1; dealcount <= 2; dealcount++) //deal two cards to each player
                        {
                            p.hand.AddTo(gamecards.Deal());
                        }
                    }
                    if (p.name == "Dealer")
                    {
                        continue;
                    }
                   
                    else while (p.isPlaying)
                        {

                            Console.WriteLine("------------------- " + p.name + " -------------------");
                            Console.WriteLine(p);

                            bool won_or_lost = CheckPlayer(p);
                            if (won_or_lost)
                            {
                                break;
                            }

                            bool ask = AskPlayer();
                            if (ask)
                            {
                                this.PlayerHit(p);
                            }
                            else {
                                this.players.Remove(p.UID);
                                break;
                            }
                     }
                }
            }
            foreach (Player p in standing.Values)
            {
                Console.WriteLine(p.name + " Score: " + p.hand.Score());
            }
        }

        public void Automatic_Play(Player p)
        {
            //Console.WriteLine("To be implemented...");
            while (p.isPlaying)
            {
                if (p.hand.Score() <= 15)
                {
                    Console.WriteLine(p.name + " Hit!");
                    this.PlayerHit(p);
                }
                else
                {
                    standing.Add(p.UID, p);
                    p.isPlaying = false;
                    Console.WriteLine(p.name + " Stands.");
                    break;
                }
            }
        }

        public bool CheckPlayer(Player p) //returns false if a player is removed from the game
        {
            bool result = false;
            if (p.hand.Score() == 21)
            {
                Console.WriteLine(p.name + " has BlackJack!");
                this.players.Remove(p.UID);
                p.isPlaying = false;
                result = true;
            }
            if (p.hand.Score() > 21)
            {
                Console.WriteLine(p.name + " busts!");
                this.players.Remove(p.UID);
                p.isPlaying = false;
                result = true;
            }
            bool ask = AskPlayer();
            if (ask)
            {
                this.PlayerHit(p);
            }
            else
            {
                this.players.Remove(p.UID);
                p.isPlaying = false;
                result = true;
            }
            return result;
        }

        public void PlayerHit(Player p)
        {
            Console.WriteLine(p.name + " Hits!");
            Console.WriteLine(p);
            p.hand.AddTo(gamecards.Deal());
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
