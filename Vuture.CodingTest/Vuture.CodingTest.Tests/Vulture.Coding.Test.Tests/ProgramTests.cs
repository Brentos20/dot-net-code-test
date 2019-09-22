using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuture.CodingTest;

namespace Vulture.Coding.Test.Tests
{
    [TestClass]
    public class ProgramTests
    {
        Program program = new Program();
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
            Assert.IsTrue(program.isPalindrome("hannah"));
        }

        [TestMethod]
        public void TestIsPallinFail()
        {
            Assert.IsFalse(program.isPalindrome("abcgicba"));
        }
    }
}
