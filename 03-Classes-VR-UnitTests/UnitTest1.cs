using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes_VR_CardConcepts;

namespace Classes_VR_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Card c1 = new Card(Count.Ace, Suit.Hearts);
            Assert.AreEqual(Count.Ace, c1.count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Card c1 = new Card(Count.Ace, Suit.Hearts);
            Assert.AreEqual(Suit.Hearts, c1.suit);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Card c1 = new Card(Count.Ace, Suit.Hearts);
            Assert.AreEqual(1, c1.BJvalue());
            Console.WriteLine(c1.ToString());
        }
        [TestMethod]
        public void deckTest()
        {
            Deck d1 = new Deck();
            for(int i = 0; i < 24; i++)
            {
                Console.WriteLine(d1.deal().ToString());
            }
            
            Assert.AreEqual(24, d1.count);
            Assert.AreEqual(28, d1.left);
        }
        [TestMethod]
        public void handTest()
        {
            Deck d1 = new Deck();
            Hand h1 = new Hand();
            for(int i = 0; i < 5; i++)
            {
                h1.add(d1.deal());
            }
            Console.WriteLine(h1.ToString());
            Assert.AreEqual(5, h1.howManyCards());

        }

        [TestMethod]
        public void BJTest()
        {
            Deck d1 = new Deck();
            Hand h1 = new Hand();
            Card c1 = new Card(Count.Four, Suit.Clubs);
            Card c2 = new Card(Count.Six, Suit.Diamonds);
            Card c3 = new Card(Count.Queen, Suit.Hearts);
            h1.add(c1);
            h1.add(c2);
            h1.add(c3);
            Assert.AreEqual(20, h1.BJscore());
        }
    }
}
