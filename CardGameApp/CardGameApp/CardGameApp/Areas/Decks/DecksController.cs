using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Decks.Models;
using CardGameApp.Areas.Decks.ViewModels;
using CardGameApp.Servicies;
using CardGameApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Decks
{
    [Route("api/[controller]")]
    public class DecksController : Controller
    {
        private Game _game;
        private IMapper<Deck, DeckViewModel> _deckMapper;
        private IDrawer _drawer;
        private IShuffler _shuffler;

        public DecksController(Game game, IMapper<Deck, DeckViewModel> deckMapper, IDrawer drawer, IShuffler shuffler)
        {
            _game = game;
            _deckMapper = deckMapper;
            _drawer = drawer;
            _shuffler = shuffler;
        }

        [HttpGet("{id}")]
        public IActionResult GetDeck(int id)
        {
            if (_game.Board != null)
            {
                var deck = _game.Board.Decks.FirstOrDefault(d => d.Id == id);
                return Ok(_deckMapper.Map(deck));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult AddDeck()
        {
            var newDeck = new Deck(_game.Board.Decks.Count + 1);
            _game.Board.Decks.Add(newDeck);
            return Ok(_deckMapper.Map(newDeck));
        }

        [HttpPost("{id}/draw")]
        public IActionResult Draw(int id)
        {
            var deck = _game.Board.Decks.FirstOrDefault(d => d.Id == id);
            var cards = deck.Cards;

            var drawedCard = _drawer.Draw(ref cards);

            return Ok(_deckMapper.Map(deck));
        }

        [HttpPost("{id}/shuffle")]
        public IActionResult Shuffle(int id)
        {
            var deck = _game.Board.Decks.FirstOrDefault(d => d.Id == id);
            var cards = deck.Cards;

            deck.Cards = _shuffler.Shuffle(cards);

            return Ok(_deckMapper.Map(deck));
        }
    }
}
