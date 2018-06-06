using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Cards.ViewModels;
using CardGameApp.Servicies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGameTest
{
    [TestClass]
    public class DrawTest
    {
        private Board _board;
        private IDrawer _drawer;

        [TestInitialize]
        public void TestInitialize()
        {
            _board = new Board();
            _drawer = new Drawer();
        }

        [TestMethod]
        public void ShouldDrawCardFromInitDeck()
        {
            var cardsFromInitDeck = _board.Decks[0].Cards;
            var drawedCard = _drawer.Draw(ref cardsFromInitDeck);

            Assert.AreEqual(Rank.Ace, drawedCard.Rank);
            Assert.AreEqual(Color.Heart, drawedCard.Color);
            Assert.AreEqual(true, drawedCard.IsShown);
        }
    }
}
