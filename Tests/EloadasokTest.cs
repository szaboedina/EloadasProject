using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EloadasProject.Tests
{
    [TestFixture]
    class EloadasokTest
    {
        Eloadas e;
        [SetUp]
        public void SetUp()
        {
            e = new Eloadas(3, 7);
        }

        [TestCase]
        //új előadás pozitív értékekkel
        public void UjEloadas() {
            Eloadas elsoEloadas = new Eloadas(3, 6);
        }
        [TestCase]
        //új előadás, az egyik érték 0
        public void UjEloadas2() {
            Assert.Throws<ArgumentException>(() => { Eloadas masodikEloadas = new Eloadas(0, 6); });
        }

        [TestCase]
        //új előadás negatív értékekkel
        public void UjEloadas3()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas harmadikEloadas = new Eloadas(-14, -12432); });
        }
        [TestCase]
        public void Foglalas()
        {
            Assert.IsTrue(e.Lefoglal());
        }

        [TestCase]
        public void FoglaltHely() {
            Assert.IsTrue(e.Foglalt(1, 1));
        }
    }
}
