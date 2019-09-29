using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuture.CodingTest;

namespace Vulture.Coding.Test.Tests
{
    [TestClass]
    public class CountOccursTests
    {

        Program MockP;

        public CountOccursTests() {
            MockP = new Program();
        }

        [TestMethod]
        public void TestCountOccurrOfCharInString()
        {
            Assert.AreEqual(5, MockP.CountOccurs('e', "eeeee"));
        }

        [TestMethod]
        public void TestCountOccursOfCharInStringWithDiffCase()
        {
            Assert.AreEqual(2, MockP.CountOccurs('E', "eE"));
        }

        [TestMethod]
        public void TestCountOccursOfCharNotInString()
        {
            Assert.AreEqual(0, MockP.CountOccurs('a', ""));
        }

        [TestMethod]
        public void TestCountOccursOfCharInStringWithDiffChars()
        {
            Assert.AreEqual(3, MockP.CountOccurs('a', "abdpaa"));
        }

        [TestMethod]
        public void TestCountOccursOfString()
        {
            Assert.AreEqual(1, MockP.CountOccurs("cat", "dogcat"));
        }

        [TestMethod]
        public void TestCountOccursOfStringWithDiffCaps()
        {
            Assert.AreEqual(2, MockP.CountOccurs("cAt", "CatjCAT"));
        }

        [TestMethod]
        public void TestCountOccursOfStringNotOccuring()
        {
            Assert.AreEqual(0, MockP.CountOccurs("Cat", ""));
        }
    }

    [TestClass]
    public class TestPalindrome
    {
        Program MockP;
        public TestPalindrome()
        {
            MockP = new Program();
        }
        [TestMethod]
        public void TestIsPalinSuccess()
        {
            Assert.IsTrue(MockP.IsPalindrome("hannah"));
        }

        [TestMethod]
        public void TestIsPalinFail()
        {
            Assert.IsFalse(MockP.IsPalindrome("abcgicba"));
        }

        [TestMethod]
        public void TestIsPalinWithCaps()
        {
            Assert.IsTrue(MockP.IsPalindrome("Abba"));
        }

        [TestMethod]
        public void TestIsPalinWithPunc()
        {
            Assert.IsTrue(MockP.IsPalindrome("a,b.b[a"));
        }
    }

    [TestClass]
    public class TestCensorWords
    {

        Program MockP;
        List<string> MockList;
        string MockText;
        string MockResult;
        public TestCensorWords()
        {
            MockP = new Program();
            MockList = new List<string>(new string[] { "meow", "woof" });
            MockText = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
        }

        [TestMethod]
        public void TestCensorWordsOccur()
        {
            Assert.AreEqual("cat: 1, dog: 2, large: 1, total: 4", MockP.CensoredWordsOccurSum(MockList, MockText));
        }
        [TestMethod]
        public void TestCensorTextSuccess()
        {
            MockResult = "I have a cat named M$$w and a dog name W$$f. I love the dog a lot. He is larger than a small horse.";
            Assert.AreEqual(MockResult, MockP.CensorText(MockList, MockText));
        }

        [TestMethod]
        public void TestCensorPalindrome()
        {
            MockResult = "A$$a went to vote in the election to fulfil her c$$$c duty";

            Assert.AreEqual(MockResult, MockP.CensorPalindrones(MockText));
        }
    }
}
