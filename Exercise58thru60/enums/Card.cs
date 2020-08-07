using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise58thru60.enums
{
    class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
        
        public Card(Suit suit,Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }

  
}
