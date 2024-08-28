using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Divide()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int num = 2;
            int[,] expected = new int[,] { { 0, 1 }, { 1, 2 } };
            int[,] result = Matrix.Divide(matrix, num);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void DivideByZero()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int num = 0;
            Assert.Throws<System.DivideByZeroException>(() => Matrix.Divide(matrix, num));
        }
        [Test]
        public void NullMatrix()
        {
            int[,] matrix = null;
            int num = 2;
            Assert.That(Matrix.Divide(matrix, num), Is.EqualTo(null));
        }
        [Test]
        public void EmptyMatrix()
        {
            int[,] matrix = new int[,] { };
            int num = 2;
            Assert.That(Matrix.Divide(matrix, num), Is.EqualTo(new int[,] { }));
        }
        [Test]
        public void EmptyMatrixDivideByZero()
        {
            int[,] matrix = new int[,] { };
            int num = 0;
            Assert.Throws<System.DivideByZeroException>(() => Matrix.Divide(matrix, num));
        }
    }
}