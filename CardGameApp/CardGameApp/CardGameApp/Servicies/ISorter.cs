using CardGameApp.Areas.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Servicies
{
    public interface ISorter
    {
        List<Card> Sort(List<Card> cards);
    }
}
