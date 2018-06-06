using CardGameApp.Areas.Cards.Models;
using CardGameApp.Areas.Cards.ViewModels;
using CardGameApp.Areas.Decks.Models;
using CardGameApp.Areas.Decks.ViewModels;
using CardGameApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Decks.Mappers
{
    public class DeckMapper : IMapper<Deck, DeckViewModel>
    {
        public Deck Map(DeckViewModel mapFrom)
        {
            return new Deck(mapFrom.Id, mapFrom.Cards.Select(card => new Card(card.Rank, card.Color)).ToList());
        }

        public DeckViewModel Map(Deck mapFrom)
        {
            return new DeckViewModel()
            {
                Id = mapFrom.Id,
                Cards = mapFrom.Cards.Select(card => card.IsShown ? new CardViewModel() { Rank = card.Rank, Color = card.Color } : null).ToList()
            };
        }
    }
}
