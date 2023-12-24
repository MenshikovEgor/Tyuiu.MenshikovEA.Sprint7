using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V11.Lib;

namespace Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\mensh\source\repos\Tyuiu.MenshikovEA.Sprint7\Project.V11\bin\Debug\Сезонность сотрудников.txt";

            CollectionAssert.AreEqual(new double[] { 4, 12, 14, 15, 9, 7, 5, 4, 7, 9, 10, 1 }, ds.LoadFromDataFile(path));
        }
    }
}
