using System;
using System.Collections;
using System.Collections.Generic;
using Card_Game;
using System.Text;

namespace Card_Game
{
    class Deck {

        public List<Card> cards { get; }
        private int size { get; set; }

        public Deck(bool init, bool ace_val = false)
        {
            this.cards = new List<Card>();
            if (init)
            {
                this.create(ace_val);
            }
            this.size = this.cards.Count;
        }
        public Deck() { }

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

        //Not sure if this belongs here
        private void create(bool ace) //if ace is true, it gets set to 1
        {
            char[] facecards = { 'A', 'J', 'Q', 'K' };
            String[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            Card c = null;
            int faceCardValue = 10; //default
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    this.AddTo(new Card(Convert.ToChar(Convert.ToString(j)[0]), suits[i], j));
                }
                for (int k = 0; k < facecards.Length; k++)
                {
                    if (facecards[k] == 'A')
                    {
                        if (ace) this.AddTo(new Card(facecards[k], suits[i], 1));
                        else this.AddTo(new Card(facecards[k], suits[i], 11));
                    }
                    else
                    {
                        this.AddTo(new Card(facecards[k], suits[i], faceCardValue)); //assign facecards with 0 value to start
                    }

                }
            }
        }

        public void AddTo(Card c)
        {
            this.cards.Add(c);
        }

    }
}
