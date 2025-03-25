using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace lr3_2.Tests
{
    [TestClass()]
    public class ConsoleGameTests
    {
        [TestMethod()]
        public void ConsoleGameCreationTest()
        {
            ConsoleGame actual = new ConsoleGame(new Grid(1, 1));
            Assert.IsNotNull(actual, "Сбой создания объекта ConsoleGame. Ожидается not null объект класса.");
        }
    }
}
