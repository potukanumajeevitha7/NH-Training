using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n=0;
            int expected = 1;
            //act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_one_to_seven_Input()
        {
            //Arrange
            int n = 5;
            int expected = 120;

            //Act
            int actual = Algebra.Factorial(n);  

            //assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void FactorialTest_nwgative_Input()
        {
            //Arrange
            int n = -5;
            int expected = -9999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_greater_than_seven_Input()
        {
            //Arrange
            int n = 9;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);  

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }

}