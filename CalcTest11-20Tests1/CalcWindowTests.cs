using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcTest11_20.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest11_20.Windows.Tests
{
    [TestClass()]
    public class CalcWindowTests
    {

        // Addition of two positive numbers
        [TestMethod()]
        public void Check_PositiveSum2And2_Return4()
        {
            int a = 2;
            int b = 2;
            string expected = "4";

            Assert.AreEqual(expected, Windows.CalcWindow.Sum(a, b));
        }
        // Addition of positive and negative numbers
        [TestMethod()]
        public void Check_NegativeSum1AndMinus2_ReturnMinus1()
        {
            int a = 1;
            int b = -2;
            string expected = "-1";

            Assert.AreEqual(expected, CalcWindow.Sum(a, b));
        }

        // Addition of integer and decimal numbers
        [TestMethod()]
        public void Check_PositiveSum1And1Point5_Return2Point5()
        {
            int a = 1;
            double b = 1.5;
            string expected = "2,5";

            Assert.AreEqual(expected, CalcWindow.Sum(a, b));
        }

        // Subtracting two positive numbers
        [TestMethod()]
        public void Check_NegativeSub1And2_ReturnMinus1()
        {
            int a = 1;
            int b = 2;
            string expected = "-1";

            Assert.AreEqual(expected, CalcWindow.Minus(a, b));
        }

        // Subtracting zero and negative numbers
        [TestMethod()]
        public void Check_PositiveSub0AndMinus1_Return1()
        {
            int a = 0;
            int b = -1;
            string expected = "1";

            Assert.AreEqual(expected, CalcWindow.Minus(a, b));
        }

        // Multiplication by 0
        [TestMethod()]
        public void Check_PositiveMultiply0And100_Return0()
        {
            int a = 0;
            int b = 100;
            string expected = "0";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // Multiplying an integer number by a decimal number
        [TestMethod()]
        public void Check_PositiveMultiply45And1Point5_Return67Point5()
        {
            int a = 45;
            double b = 1.5;
            string expected = "67,5";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // Multiplication of a positive number by a negative number
        [TestMethod()]
        public void Check_NegativeMultiply10AndMinus5_ReturnMinus50()
        {
            int a = 10;
            int b = -5;
            string expected = "-50";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // Division by 0
        [TestMethod()]
        public void Check_PositiveDivide1By0_ReturnInfinity()
        {
            int a = 1;
            int b = 0;
            string expected = Convert.ToString(double.PositiveInfinity);

            Assert.AreEqual(expected, CalcWindow.Substract(a, b));
        }

        // Dividing an integer number by a decimal number
        [TestMethod()]
        public void Check_PositiveDivide10By2Point5_Return4()
        {
            int a = 10;
            double b = 2.5;
            string expected = "4";

            Assert.AreEqual(expected, CalcWindow.Substract(a, b));
        }

        // Finding the root of a positive number
        [TestMethod()]
        public void Check_SquareOf36_Return6()
        {
            int a = 144;
            string expected = "12";

            Assert.AreEqual(expected, CalcWindow.Square(a));
        }

        // Finding the root of the negative number
        [TestMethod()]
        public void Check_SquareOfMinus1_ReturnNull()
        {
            int a = -1;
            string expected = Convert.ToString(double.NaN);

            Assert.AreEqual(expected, CalcWindow.Square(a));
        }
    }
}