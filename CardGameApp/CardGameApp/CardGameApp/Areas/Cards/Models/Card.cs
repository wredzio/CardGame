using CardGameApp.Areas.Cards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Areas.Cards.Models
{
    public class Card
    {
        public Rank Rank { get; }
        public Color Color { get; }
        public bool IsShown { get; }

        public int RankOrderBy
        {
            get
            {
                return (int)Rank;
            }
        }

        public int ColorOrderBy
        {
            get
            {
                return (int)Color;
            }
        }

        public Card(Rank rank, Color color)
        {
            Rank = rank;
            Color = color;
            IsShown = false;
        }
    }
}
