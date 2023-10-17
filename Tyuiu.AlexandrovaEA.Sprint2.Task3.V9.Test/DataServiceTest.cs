using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint2.Task3.V9.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(-2.667, Math.Round(res, 3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(1, Math.Round(res, 3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -11;
            double res = ds.Calculate(x);//
            Assert.AreEqual(1.067, Math.Round(res, 3));
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = 12;
            double res = ds.Calculate(x);
            Assert.AreEqual(7377451514.118, Math.Round(res, 3));
        }
    }
}
