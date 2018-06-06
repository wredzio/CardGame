using CardGameApp.Areas.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Servicies
{
    public interface IShuffler
    {
        List<Card> Shuffle(List<Card> cards);
    }
}
