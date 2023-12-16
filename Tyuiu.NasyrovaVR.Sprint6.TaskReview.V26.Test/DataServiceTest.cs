using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 4;
            int c = 4;
            int[,] mas = new int[5, 5] { { 15, -45, 12, 4, 6 },
                                         { -12, 14, -10, 34, 0 },
                                         { 3, 1, 16, -13, 25 },
                                         { -13, -23, 11, -17, 21 },
                                         { -3, 1, -1, 5, 1 } };
            int res = ds.GetMatrix(mas, c, k, l);
            int wait = -5;
            Assert.AreEqual(wait, res);
        }
    }
}
