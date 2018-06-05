using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Boards.ViewModels;
using CardGameApp.Areas.Cards.ViewModels;
using CardGameApp.Areas.Decks.Models;
using CardGameApp.Areas.Decks.ViewModels;
using CardGameApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Boards.Mappers
{
    public class BoardMapper : IMapper<Board, BoardViewModel>
    {
        public Board Map(BoardViewModel mapFrom)
        {
            return new Board()
            {
                Decks = mapFrom.Decks.Select(deckViewModel => new Deck(deckViewModel.Id)).ToList()
            };
        }

        public BoardViewModel Map(Board mapFrom)
        {
            return new BoardViewModel()
            {
                Id = mapFrom.Id,
                Name = mapFrom.Name,
                Decks = mapFrom.Decks
                        .Select(deck => 
                            new DeckViewModel()
                            {
                                Id = deck.Id,
                                Cards = deck.Cards
                                        .Select( card =>
                                            new CardViewModel()
                                            {
                                                Color = card.Color,
                                                Rank = card.Rank
                                            }).ToList()
                            }).ToList()
            };
        }
    }
}
