using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        [TestMethod]
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void WordsBetweenBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        /* These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
            "[LaunchCode", "Launch]Code[", "[", "][" */
        [TestMethod]
        public void BracketsWithinWord()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void BracketsFollowedByWords()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void OpenBracketThenWord()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void WordWithBracketOutOfOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void OpenBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void ReverseOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void ManyBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"));
        }
        [TestMethod]
        public void BalancedBracketsThenOpen()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]["));
        }
        [TestMethod]
        public void BalancedBracketsThenClose()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }
        [TestMethod]
        public void BalancedParens()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("()"));
        }
        [TestMethod]
        public void OnlyOpenParens()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("("));
        }
        [TestMethod]
        public void OnlyCloseParens()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(")"));
        }
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
    }
}
