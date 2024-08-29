using MyMath;
using System;
using NUnit.Framework;
using System.IO; 

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestDivide()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(new int[,] { { 0, 1, 1 }, { 2, 2, 3 }, { 3, 4, 4 } }));
        }
        [TestCase(0)]
        public void TestDivideByZero(int divisor)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] result = Matrix.Divide(matrix, divisor);
            Assert.That(result, Is.Null);
        }
        [TestCase(0)]
public void TestDivideByZeroConsole(int divisor)
{
    StringWriter stringWriter = new StringWriter();
    Console.SetOut(stringWriter);

    int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int[,] result = Matrix.Divide(matrix, divisor);

    Assert.That(stringWriter.ToString().Trim(), Is.EqualTo("Num cannot be 0"));
}
        [Test]
        public void TestDivideNull()
        {
            int[,] matrix = null;
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result == null);
        }
        [Test]
        public void TestDivideEmpty()
        {
            int[,] matrix = new int[,] { };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(new int[,] { }));
        }
        [Test]
        public void TestDivideNegative()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int num = -2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(new int[,] { { 0, -1, -1 }, { -2, -2, -3 }, { -3, -4, -4 } }));
        }

        [Test]
        public void TestDivideMatrixWithZeroElements()
        {
            int[,] matrix = new int[,] { { 0, 2, 0 }, { 4, 0, 6 }, { 0, 8, 0 } };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(new int[,] { { 0, 1, 0 }, { 2, 0, 3 }, { 0, 4, 0 } }));
        }

        [Test]
        public void TestDivideSingleElementMatrix()
        {
            int[,] matrix = new int[,] { { 10 } };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(new int[,] { { 5 } }));
        }
    }
}