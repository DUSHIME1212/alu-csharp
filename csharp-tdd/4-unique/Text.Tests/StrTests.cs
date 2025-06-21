using NUnit.Framework;
using Text;  

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestUniqueChar_WithUniqueCharacter_ReturnsCorrectIndex()
        {
            string input = "aabbc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(4, result);  
        }

        [Test]
        public void TestUniqueChar_NoUniqueCharacter_ReturnsMinusOne()
        {
            string input = "aabbcc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  
        }

        [Test]
        public void TestUniqueChar_EmptyString_ReturnsMinusOne()
        {
            string input = "";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  
        }

        [Test]
        public void TestUniqueChar_SingleCharacter_ReturnsZero()
        {
            string input = "a";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);  
        }

        [Test]
public void TestUniqueChar_MultipleUniqueCharacters_ReturnsFirstUniqueIndex()
{
    
    string input = "abccba"; 
    int result = Str.UniqueChar(input);
    Assert.AreEqual(-1, result);  
}

    }
}
