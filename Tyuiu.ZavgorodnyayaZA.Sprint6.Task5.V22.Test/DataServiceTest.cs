﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project's C#\Tyuiu.ZavgorodnyayaZA.Sprint6\Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
