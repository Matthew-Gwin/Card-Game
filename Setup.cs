using System;

namespace Card_Game
{
    class Setup
    {
        static void Main(string[] args)
        {
            Deck d = new Deck(52);
            Card ace_of_spades = new Card('A', "Spades", 10);
            Console.WriteLine(ace_of_spades);
            Console.WriteLine("Hello World!");
        }
    }
}
