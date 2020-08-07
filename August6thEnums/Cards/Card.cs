using System;
using System.Collections.Generic;
using System.Text;

namespace August6thEnums.Cards
{
    public class Card
    {
        public string Rank { get; set; }

        public string Suit { get; set; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;            
        }

        public string PrintCard()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
