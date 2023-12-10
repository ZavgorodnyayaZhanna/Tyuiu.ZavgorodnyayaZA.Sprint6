using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"D:\Project's C#\Tyuiu.ZavgorodnyayaZA.Sprint6\Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            string res = dataService.CollectTextFromFile(path).Trim();
            string wait = "GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU";
            Assert.AreEqual(wait, res);
        }
    }
}
