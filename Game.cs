using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    internal class Game
    {
        public Dictionary<int,Player> players;

        public Game()
        {
            players = new Dictionary<int,Player>();
        }

        public void AddPlayer(Player p)
        {

            int UID = this.generateID();
            if (players.ContainsKey(UID)){
                while (players.ContainsKey(UID))
                {
                    UID = this.generateID();
                }
            }
            players.Add(UID, p);
        }
        private int generateID()
        {
            Random rnd = new Random();
            return rnd.Next(0, 99999);
        }
    }
}
