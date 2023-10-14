using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint2.Task5.V6.Lib;

namespace Tyuiu.KomarovMI.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            

            Assert.AreEqual("Пики Дама" , ds.FindCardNameAndValue(12,1));

        }
    }
}
