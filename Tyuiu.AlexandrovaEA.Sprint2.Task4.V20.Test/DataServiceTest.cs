using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint2.Task4.V20.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(8, Math.Round(res, 3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 20;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(3.95, Math.Round(res, 3));
        }
    }
}
