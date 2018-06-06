using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGameApp.Areas.Cards.Models;

namespace CardGameApp.Servicies
{
    public class Shuffler : IShuffler
    {
        public List<Card> Shuffle(List<Card> cards)
        {
            cards.ForEach(card => card.IsShown = false);
            var random = new Random();

            var numberOfShuffls = random.Next(100, 150);

            for(int i = 0; i < numberOfShuffls; i++)
            {
                var shuffledDeck = new List<Card>();

                var indexToShuffle = random.Next(0, cards.Count);

                shuffledDeck.AddRange(cards.Skip(indexToShuffle));
                shuffledDeck.AddRange(cards.Take(indexToShuffle));

                cards = shuffledDeck;
            }

            return cards;
        }
    }
}
