﻿using System;
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
            //Console.WriteLine(gamecards);
        }

        public void PlayGame()
        {
            //int numDone = 0; 
            gamecards.Shuffle();
            //while (numDone < this.players.Count - 1)
            //while (this.players.Count >= 1) 
            while (true) // While there's more players than the dealer
            {
                if (this.players.Count == 1) //only dealer left
                {
                    Dealer_Play();
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
                            if (p.hand.Score() == 21)
                            {
                                Console.WriteLine(p.name + " has BlackJack!");
                                this.players.Remove(p.UID);
                                //numDone++;
                                break;
                            }
                            if (p.hand.Score() > 21)
                            {
                                Console.WriteLine(p.name + " busts!");
                                this.players.Remove(p.UID);
                                //numDone++;
                                break;
                            }
                            bool ask = AskPlayer();
                            if (ask)
                            {
                                p.hand.AddTo(gamecards.Deal());
                            }
                            else {
                                this.players.Remove(p.UID);
                                break;
                                //numDone++;
                            }
                     }
                }
            }
        }

        public void Dealer_Play()
        {
            Console.WriteLine("To be implemented...");
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
