using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PomazDS.Sprint0.Task3.V0.Lib;

namespace Tyuiu.PomazDS.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
            Assert.AreEqual(10, DataService.Minus(15, 5));
            Assert.AreEqual(10, DataService.Mult(2, 5));
            Assert.AreEqual(10, DataService.Div(50, 5));
        }
    }
}
