using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckClac()
        {
            int FirstNum = 5;
            int SecondNum = 10;
            int ThirdNum = 20;

            int res = DataService.Clac(FirstNum, SecondNum, ThirdNum);

            Assert.AreEqual(60, res);
        }
    }
}
