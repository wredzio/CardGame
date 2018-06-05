using CardGameApp.Areas.Cards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Decks.ViewModels
{
    public class DeckViewModel
    {
        public int Id { get; set; }
        public List<CardViewModel> Cards { get; set; }
    }
}
