﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    public class GridMapperTests
    {
        [TestMethod()]
        public void GridMapperCreationTest()
        {
            GridMapper actual = new GridMapper();
            Assert.IsNotNull(actual, "Сбой создания объекта GridMapper. Ожидается not null объект класса.");
        }

        [TestMethod()]
        public void GridMapper9ToInt()
        {
            int expected = 9;
            int actual = GridMapper.ToInt('9');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapperDotToInt()
        {
            int expected = 0;
            int actual = GridMapper.ToInt('.');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapper1ToInt()
        {
            int expected = 1;
            int actual = GridMapper.ToInt('1');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapperAnyToInt()
        {
            int expected = 0;
            int actual = GridMapper.ToInt('?');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapper9ToChar()
        {
            char expected = GridMapper.mine;
            char actual = GridMapper.ToChar(Grid.mine_value);

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии int в char. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }
    }
}
