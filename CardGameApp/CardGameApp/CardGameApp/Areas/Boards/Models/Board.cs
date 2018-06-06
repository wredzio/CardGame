using CardGameApp.Areas.Decks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Boards.Models
{
    public class Board
    {
        public int Id => 1;
        public string Name => "My Board";
        public List<Deck> Decks { get; set; }

        public Board()
        {
            Decks = new List<Deck>();
            Decks.Add(new Deck(1));
        }
    }
}

