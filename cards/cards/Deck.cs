using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Deck
    {
        private Dictionary<CardSuit, List<Card>> deck; // новая колода
        Random gen = new Random();

        public void CreateDeck()                       // создать колоду
        {
            this.deck = new Dictionary<CardSuit, List<Card>>();
            for (CardSuit suit = CardSuit.Clubs; suit <= CardSuit.Spades; suit++)
            {
                List<Card> setOfCards = new List<Card>();
                for (CardValue value = CardValue.Two; value <= CardValue.A; value++)
                {
                    setOfCards.Add(new Card(suit, value));
                }
                deck.Add(suit, setOfCards);
            }
        }

        public Card SelectСard()
        {
            CardSuit suit = (CardSuit)gen.Next(4);     // выбрать масть
            while (check(suit))
            {                      // проверить на непустое
                suit = (CardSuit)gen.Next(4);          // иначе повторить выбор
                continue;
            }
            CardValue value = (CardValue)gen.Next(13); // выбрать карту
            while (check(suit, value))
            {               // проверить на непустое
                value = (CardValue)gen.Next(13);       // иначе повторить выбор
                continue;
            }

            List<Card> item = this.deck[suit];
            Card card = item.Find(c => c.suit == suit && c.value == value); // извлечь карту
            item.Remove(card);                                              // удалить из колоды
            return card;
        }

        private bool check(CardSuit suit)
        {
            bool flag = true;
            for (CardValue value = CardValue.Two; value <= CardValue.A; value++)
            {
                if (!check(suit, value))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        private bool check(CardSuit suit, CardValue value)
        {
            List<Card> items = this.deck[suit];
            return !items.Exists(c => c.suit == suit && c.value == value);
        }
    }
}
