using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint2.Task1.V28.Lib;
//==, !=, <, >, <=, >=
//|, &, ||, &&, !, ^
//True, False, True, False, True, False
//a = 247, b = 654, c = 671, d = 671
namespace Tyuiu.AlexandrovaEA.Sprint2.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
