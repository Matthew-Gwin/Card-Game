using System;

namespace Card_Game
{
    class Setup
    {
        static void Main(string[] args)
        {


            Deck d = new Deck(true); //creates standard deck of size 52 
            for (int i = 0; i < d.cards.Count; i++)
            {
                Console.WriteLine(d.cards[i]);
            }
            //Card ace_of_spades = new Card('A', "Spades", 11);
            Player matt = new Player("Matt");
            Player yasmeen = new Player("Yasmeen");
            Player feiyang = new Player("Feiyang");
            //Game setup
            Game game = new Game();
            game.AddPlayer(matt);
            game.AddPlayer(yasmeen);
            game.AddPlayer(feiyang);   
           // Console.WriteLine(ace_of_spades);
            Console.WriteLine("Hello World!");
        }
    }
}
