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

        public BoardsController(Game game, IMapper<Board, BoardViewModel> boardMapper)
        {
            _game = game;
            _boardMapper = boardMapper;
        }

        [HttpGet]
        public async Task<IActionResult> Start()
        {
            return Ok(_game.Board);
        }

        [HttpPost]
        public IActionResult StartNewGame()
        {
            _game.Board = new Board();

            return Ok(_boardMapper.Map(_game.Board));
        }
    }
}