using System;
using System.Linq;
using System.Collections.Generic;

namespace Card_Game
{
    class Setup
    {
        static void Main(string[] args)
        {

            Deck d = new Deck(true); //creates standard deck of size 52 

            foreach (Card c in d.cards)
            {
                Console.WriteLine(c);
            }

            //LINQ
            /*
            Console.WriteLine("Daimond cards exclusively selected with LINQ");
            IEnumerable<Card> dmds = from c in d.cards where c.ToString().Contains("Diamonds") select c;

            foreach (Card card in dmds)
            {
                Console.WriteLine(card);
            }*/ 

            //Card ace_of_spades = new Card('A', "Spades", 11);
            /*Player matt = new Player("Matt");
            Player yasmeen = new Player("Yasmeen");
            Player feiyang = new Player("Feiyang");
            //Game setup
            Game game = new Game();
            game.AddPlayer(matt);
            game.AddPlayer(yasmeen);
            game.AddPlayer(feiyang);*/   
          //Console.WriteLine(ace_of_spades);
            Console.WriteLine("Hello World!");
        }
    }
}
