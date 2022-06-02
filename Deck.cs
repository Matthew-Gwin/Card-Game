using System;
using System.Collections;
using System.Collections.Generic;
using Card_Game;
using System.Text;

namespace Card_Game
{
    class Deck {

        private List<Card> cards { get; set; }
        private int size { get; set; }

        public Deck() { }
        
        public Deck(int size)
        {
            this.size = size;
            this.cards = new List<Card>();
        }

        private void Shuffle()
        {
            Random rand = new Random();
            int r = rand.Next() % size;
            for (int i = 0; i < 10; i++)
            {
                Card temp = this.cards[i];
                this.cards[i] = this.cards[r]; //swap with random card
                this.cards[r] = temp;
            }
        }
        private Card Deal()
        {
            int last = cards.Count - 1;
            Card ret = cards[last];
            this.cards.RemoveAt(last);
            return ret;

        }
        public void AddTo(Card c)
        {
            this.cards.Add(c);
        }

    }
}
