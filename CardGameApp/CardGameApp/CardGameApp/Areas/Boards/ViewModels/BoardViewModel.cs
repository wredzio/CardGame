using CardGameApp.Areas.Decks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Boards.ViewModels
{
    public class BoardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DeckViewModel> Decks { get; set; }
    }
}
