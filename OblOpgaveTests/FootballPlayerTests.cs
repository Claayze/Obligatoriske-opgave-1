using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblOpgave.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer player1;

        [TestInitialize()]
        public void StartUp()
        {
            player1 = new FootballPlayer("Pete");
        }

        [TestMethod()]

        public void ConstructorTest()
        {
            Assert.AreEqual("Pete", player1.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => new FootballPlayer("Max")));
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Pete", player1.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => player1.Name = ""));
        }

        [TestMethod()]
        public void PriceTest()
        {
            player1.Price = 100;
            Assert.AreEqual(100, player1.Price);
            player1.Price = 99;
            Assert.AreEqual(99, player1.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => player1.Price = -1));
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            player1.ShirtNumber = 100;
            Assert.AreEqual(100, player1.ShirtNumber);
            player1.ShirtNumber = 1;
            Assert.AreEqual(1, player1.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => player1.ShirtNumber = 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => player1.ShirtNumber = 101));
        }

    }
}