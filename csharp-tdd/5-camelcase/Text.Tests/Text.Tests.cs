using System;
using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestCamelCase()
        {
            Assert.That(Str.CamelCase("helloWorld"), Is.EqualTo(2));
        }

        [Test]
        public void TestCamelCaseEmptyString()
        {
            Assert.That(Str.CamelCase(""), Is.EqualTo(0));
        }

        [Test]
        public void TestCamelCaseNullString()
        {
            Assert.That(Str.CamelCase(null), Is.EqualTo(0));
        }

        [Test]
        public void FullStatementCase()
        {
            Assert.That(Str.CamelCase("helloWhoAreYou"), Is.EqualTo(4));
        }

        [Test]
        public void TestCamelCaseSingleWord()
        {
            Assert.That(Str.CamelCase("hello"), Is.EqualTo(1));
        }

        [Test]
        public void FullStatementWithSpacesCase()
        {
            Assert.That(Str.CamelCase("hello Who Are You"), Is.EqualTo(4));
        }
    }
}