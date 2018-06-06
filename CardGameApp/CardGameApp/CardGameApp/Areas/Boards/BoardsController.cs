using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Boards.ViewModels;
using CardGameApp.Areas.Decks.ViewModels;
using CardGameApp.Servicies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CardGameApp.Utils;

namespace CardGameApp.Controllers
{
    [Route("api/[controller]")]
    public class BoardsController : Controller
    {
        private Game _game;
        private IMapper<Board, BoardViewModel> _boardMapper;
        private ISorter _sorter;

        public BoardsController(Game game, IMapper<Board, BoardViewModel> boardMapper, ISorter sorter)
        {
            _game = game;
            _boardMapper = boardMapper;
            _sorter = sorter;
        }

        [HttpGet]
        public IActionResult GetBoard()
        {
            if(_game.Board != null)
            {
                return Ok(_boardMapper.Map(_game.Board));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult StartNewGame()
        {
            _game.Board = new Board();

            return Ok(_boardMapper.Map(_game.Board));
        }

        [HttpPost("{boardId}/sort")]
        public IActionResult SortAllDecks(int boardId)
        {
            foreach(var deck in _game.Board.Decks)
            {
                deck.Cards = _sorter.Sort(deck.Cards);
            }

            return Ok(_boardMapper.Map(_game.Board));
        }
    }
}