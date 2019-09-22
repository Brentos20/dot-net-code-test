using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuture.CodingTest;

namespace Vulture.Coding.Test.Tests
{
    [TestClass]
    public class ProgramTests
    {
        Program program = new Program();
        List<string> mockList = new List<string>(new string[] {"cat", "dog", "large"});
        string mockText = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
        string mockResult = "";

        [TestMethod]
        public void TestCountOccursSuccess()
        {
            Assert.AreEqual(5, program.CountOccurs('e', "eeeee"));
        }

        [TestMethod]
        public void TestCountOccursZero()
        {
            Assert.AreEqual(0, program.CountOccurs('a',""));
        }

        [TestMethod]
        public void TestIsPalinSuccess()
        {
            Assert.IsTrue(program.IsPalindrome("hannah"));
        }

        [TestMethod]
        public void TestIsPallinFail()
        {
            Assert.IsFalse(program.IsPalindrome("abcgicba"));
        }

        [TestMethod]
        public void TestCensoredWordsOccurSuccess()
        {
            Assert.AreEqual("cat: 1, dog: 2, large: 1, total: 4", program.CensoredWordsOccurSum(mockList, mockText));
        }

        [TestMethod]
        public void TestCensorTextSuccess()
        {
            mockText = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
            mockList = new List<string>( new string[] { "meow","woof"});
            mockResult = "I have a cat named M$$w and a dog name W$$f. I love the dog a lot. He is larger than a small horse.";
            Assert.AreEqual(mockResult, program.CensorText(mockList, mockText));
        }

        [TestMethod]
        public void TestCensorPalindrome()
        {
            mockText = "Anna went to vote in the election to fulfil her civic duty";
            mockResult = "A$$a went to vote in the election to fulfil her c$$$c duty";

            Assert.AreEqual(mockResult, program.CensorPalindrones(mockText));
        }
    }
}
