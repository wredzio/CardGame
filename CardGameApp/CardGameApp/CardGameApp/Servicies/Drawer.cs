using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGameApp.Areas.Cards.Models;

namespace CardGameApp.Servicies
{
    public class Drawer : IDrawer
    {
        public Card Draw(ref List<Card> cards)
        {
            var drawedCard = cards.FirstOrDefault(card => !card.IsShown);
            if(drawedCard != null)
            {
                drawedCard.IsShown = true;
            }
            else
            {
                throw new ApplicationException("there is no card to draw");
            }

            return drawedCard;
        }
    }
}
