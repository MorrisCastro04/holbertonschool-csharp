using NUnit.Framework;
using Text;

namespace Text.Tests{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void willItTrue()
        {
            bool result = Str.IsPalindrome("level");
            Assert.That(result == true);
        }
        
        [Test]
        public void willItTrue_cap()
        {
            bool result = Str.IsPalindrome("Level");
            Assert.That(result == true);
        }
        
        [Test]
        public void willItFlase()
        {
            bool result = Str.IsPalindrome("Juan");
            Assert.That(result == false);
        }
        [Test]
        public void willItTrue_empty()
        {
            bool result = Str.IsPalindrome("");
            Assert.That(result == true);
        }
        [Test]
        public void willItTrue_null()
        {
            bool result = Str.IsPalindrome(null);
            Assert.That(result == true);
        }
    }
}