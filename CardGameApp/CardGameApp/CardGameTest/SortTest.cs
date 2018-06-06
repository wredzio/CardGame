using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Cards.ViewModels;
using CardGameApp.Servicies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameTest
{
    [TestClass]
    public class SortTest
    {
        private Board _board;
        private ISorter _sorter;
        private IShuffler _shuffler;

        [TestInitialize]
        public void TestInitialize()
        {
            _board = new Board();
            _sorter = new Sorter();
            _shuffler = new Shuffler();
        }

        [TestMethod]
        public void ShouldSortShuffledDeck()
        {
            var cardsFromInitDeck = _board.Decks[0].Cards;
            var shuffledCards = _shuffler.Shuffle(cardsFromInitDeck);
            var sortedCards = _sorter.Sort(shuffledCards);

            Assert.AreEqual(Rank.Ace, sortedCards[0].Rank);
            Assert.AreEqual(Color.Heart, sortedCards[0].Color);
        }
    }
}
