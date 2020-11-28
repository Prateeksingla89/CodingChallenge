using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass()]
    public class RotatingArrayClassTests
    {
        [TestMethod()]
        public void rotateArrayTest_ZeroIndex()
        {
            //Arrange
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(0, 0, null);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_NegitiveIndex()
        {
            //Arrange
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(int.MinValue, int.MinValue, null);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }
        [TestMethod()]
        public void rotateArrayTest_IndexOne()
        {
            //Arrange
            int[,] input = new int[0, 0];
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(1, 1, input);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_OneArrayValueAndNCol()
        {
            //Arrange
            int[,] input = new int[1, 1] { { 511 } };
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(1, 512, input);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_ThreeRows()
        {
            //Arrange
            int[,] input = new int[3, 1] { { 1610612738 }, { 1610612736 }, { 1610612735 } };
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(1, 1610612738, input);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_WithoutInputValue()
        {
            //Arrange
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(1, 0, null);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_OneRowOneColInput()
        {
            //Arrange
            int[,] input = new int[1, 1];
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(2, 1, input);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

        [TestMethod()]
        public void rotateArrayTest_ChangingInput()
        {
            //Arrange
            int[,] input = new int[1, 3];
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            //Act
            var actual = rotatingArrayClass.rotateArray(2, 1, input);

            //Assert
            Assert.IsNotNull(rotatingArrayClass);
            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(2, actual.Rank);
            Assert.AreEqual(0, actual.GetLowerBound(0));
            Assert.AreEqual(0, actual.GetLowerBound(1));
            Assert.AreEqual(0, actual.GetLength(0));
            Assert.AreEqual(0, actual.GetLength(1));
        }

    }
}

