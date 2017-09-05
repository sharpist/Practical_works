using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cards
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void buttonNewSet_Click(object sender, EventArgs e)
        {
            Profiles<Layout> cut = new Profiles<Layout>(
            new Layout { CardSuit = "Hearts", CardValue = "A", a = 0, b = 0, c = 72, d = 100 }, // unit sizes 72x100
            new Layout { CardSuit = "Hearts", CardValue = "Two", a = 72, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Three", a = 144, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Four", a = 216, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Five", a = 288, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Six", a = 360, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Seven", a = 432, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Eight", a = 504, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Nine", a = 576, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Ten", a = 648, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "J", a = 720, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "Q", a = 792, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Hearts", CardValue = "K", a = 864, b = 0, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "A", a = 0, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Two", a = 72, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Three", a = 144, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Four", a = 216, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Five", a = 288, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Six", a = 360, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Seven", a = 432, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Eight", a = 504, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Nine", a = 576, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Ten", a = 648, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "J", a = 720, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "Q", a = 792, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Diamonds", CardValue = "K", a = 864, b = 100, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "A", a = 0, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Two", a = 72, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Three", a = 144, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Four", a = 216, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Five", a = 288, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Six", a = 360, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Seven", a = 432, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Eight", a = 504, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Nine", a = 576, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Ten", a = 648, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "J", a = 720, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "Q", a = 792, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Clubs", CardValue = "K", a = 864, b = 200, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "A", a = 0, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Two", a = 72, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Three", a = 144, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Four", a = 216, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Five", a = 288, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Six", a = 360, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Seven", a = 432, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Eight", a = 504, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Nine", a = 576, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Ten", a = 648, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "J", a = 720, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "Q", a = 792, b = 300, c = 72, d = 100 },
            new Layout { CardSuit = "Spades", CardValue = "K", a = 864, b = 300, c = 72, d = 100 });
            // создать новую колоду
            Deck deck = new Deck();
            deck.CreateDeck();
            Card[][] hands = new Card[4][];
            for (byte i = 0; i < 4; i++)
            {
                Card[] hand = new Card[13];
                for (byte j = 0; j < 13; j++)
                {
                    hand[j] = deck.SelectСard(); // выбрать случайную карту
                }
                hands[i] = hand;
            }
            // отобразить результат
            int height = 0;
            for (byte i = 0; i < 4; i++)
            {
                int width = 0;
                for (byte j = 0; j < 13; j++)
                {
                    Card[] cards = hands[i];
                    CardSuit suit = cards[j].suit;
                    CardValue value = cards[j].value;
                    // найти соответствие
                    Layout match = cut.Find((Layout c) => { return c.CardSuit == suit.ToString() && c.CardValue == value.ToString(); });

                    Rectangle rect = new Rectangle(match.a, match.b, match.c, match.d);    // загрузить разметку
                    //Image image = Image.FromFile("deck.gif");                            // загрузить изображение
                    Image image = Properties.Resources.deck;
                    Graphics g = this.CreateGraphics();                                    // объект Graphics для формы
                    g.DrawImage(image, width + 10, height + 10, rect, GraphicsUnit.Pixel); // расположение в окне
                    width += 72;

                    image.Dispose();
                    g.Dispose();
                }
                height += 100;
            }
        }
    }
}
