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

namespace CardGameApp.Controllers
{
    [Route("api/[controller]")]
    public class BoardsController : Controller
    {
        private Game _game;

        public BoardsController(Game game)
        {
            _game = game;
        }

        [HttpGet]
        public async Task<IActionResult> Start()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [HttpPost]
        public IActionResult StartNewGame()
        {
            _game.Board = new Board();

            return Ok(_game.Board);
        }
    }
}