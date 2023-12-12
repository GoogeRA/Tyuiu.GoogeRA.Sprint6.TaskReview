using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint6.TaskReview.V13.Lib;

namespace Tyuiu.GoogeRA.Sprint6.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] numsMat = new int[5, 5] { { 9, -4, 17, -1, -20,},
                                          { 19, 18, -4, 2, 14,},
                                          { 12, 16, -2, 7, 18,},
                                          { 16, 15, 4, -12, -13,},
                                          { 15, 4, -16, 1, -14,}, };
            int sum = 36;
            int res = ds.GetMatrix(numsMat, 0, 4, 0);
            Assert.AreEqual(sum, res);
            




        }
    }
}

