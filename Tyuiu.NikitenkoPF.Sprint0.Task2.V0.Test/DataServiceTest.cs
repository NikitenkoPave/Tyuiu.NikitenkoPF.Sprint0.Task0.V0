using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikitenkoPF.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NikitenkoPF.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Павел";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Павел! ", res);
        }
    }
}
