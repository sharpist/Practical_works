using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Card
    {
        public CardSuit suit { get; set; }
        public CardValue value { get; set; }
        public Card(CardSuit suit, CardValue value) {
            this.suit = suit;
            this.value = value;
        }
        public override string ToString() => $"{value} of {suit}";
    }
}
