﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbers.Tests
{
    [TestClass]
    public class PrimeNumbersTests
    {
        private PrimeNumbers primeNumbers;

        [TestInitialize]
        public void TestInitialize()
        {
            primeNumbers = new PrimeNumbers();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            primeNumbers = null;
        }
        
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
