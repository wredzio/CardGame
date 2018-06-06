using CardGameApp.Areas.Cards.Models;
using CardGameApp.Areas.Cards.ViewModels;
using CardGameApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CardGameApp.Areas.Decks.Models
{
    public class Deck
    {
        public const int DeckSize = 52;
        private static readonly List<Card> sortedDeck;

        public int Id { get; }
        public List<Card> Cards { get; set; }

        static Deck()
        {
            sortedDeck = new List<Card>();
            var colorValues = Util.GetValues<Color>();
            var rankValues = Util.GetValues<Rank>();

            foreach (var colorValue in colorValues)
            {
                foreach (var rankValue in rankValues)
                {

                    sortedDeck.Add(new Card(rankValue, colorValue));
                }
            }

        }

        public Deck(int id): this(id, null)
        {
            Cards = sortedDeck;
        }

        public Deck(int id, List<Card> cards)
        {
            Id = id;
            Cards = cards;
        }
    }
}
