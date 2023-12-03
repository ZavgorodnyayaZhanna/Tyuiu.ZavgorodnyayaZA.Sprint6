using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZavgorodnyayaZA.Sprint6.Task0.V26.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 0.286;
            Assert.AreEqual(wait, res);
        }
    }
}