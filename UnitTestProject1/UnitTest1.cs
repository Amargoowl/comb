using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using combination;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calibration_someintArray_ArrayArray()
        {
            //arrage
            int[][] numbersOut;
            int[] numbersIn0 = new int[] { 1 , 3};
            int[] numbersIn1 = new int[] { 2 , 2};
            int[] numbersIn2 = new int[] { 3 , 1};
            //act
            numbersOut = Program.Combination(numbersIn0, numbersIn1, numbersIn2);
            //assert
            Assert.AreEqual(numbersOut.Length, 8);
            Assert.AreEqual(numbersOut[0][0], 1);
            Assert.AreEqual(numbersOut[0][1], 2);
            Assert.AreEqual(numbersOut[0][2], 3);
        }
    }
}
