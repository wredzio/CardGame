using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGameApp.Areas.Cards.Models;

namespace CardGameApp.Servicies
{
    public class Sorter : ISorter
    {
        public List<Card> Sort(List<Card> cards)
        {
            cards.ForEach(card => card.IsShown = true);

            return cards
                .OrderBy(card => card.ColorOrderBy)
                .ThenBy(card => card.RankOrderBy).ToList();
        }
    }
}
