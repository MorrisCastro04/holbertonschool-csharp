using NUnit.Framework;
using System;
using Text;

namespace Text.Tests
{

    public class Tests
    {
        [Test]
        public void ReturnUnique()
        {
            string s = "Hello";
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void NoUnique()
        {
            string s = "aaaaa";
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void EmptyString()
        {
            string s = "";
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void NullString()
        {
            string s = null;
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void ReturnUniqueChar()
        {
            string s = "a";
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ReturnUniqueCharInMiddle()
        {
            string s = "abcba";
            int result = Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}