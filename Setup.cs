using System;

namespace Card_Game
{
    class Setup
    {
        static void Main(string[] args)
        {


            Deck d = new Deck(); //creates standard deck of size 52 
            Card ace_of_spades = new Card('A', "Spades", 11);
            Player matt = new Player("Matt");
            Player yasmeen = new Player("Yasmeen");
            Player feiyang = new Player("Feiyang");
            Console.WriteLine(ace_of_spades);
            Console.WriteLine("Hello World!");
        }
    }
}
