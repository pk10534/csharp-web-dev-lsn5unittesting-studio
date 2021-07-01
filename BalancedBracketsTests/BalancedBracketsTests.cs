using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }


        [TestMethod] // #1. is it true these brackets are correct
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod] //#2. can opposite facing brackets pass the method
        public void BracketsInOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launch["));
        }

        [TestMethod] //#3
        public void NoBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("No brackets to be foud here"));
        }

        [TestMethod] //#4
        public void TwoClosedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        [TestMethod] //#5
        public void OutofOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]]]] Testing this out [[[[["));
        }

        [TestMethod] //#6. does it contain two brackets
        public void ContainsTwoBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch"));
        }

        [TestMethod] //#7
        public void ContainsOnlyClosingBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Hello]"));
        }

        [TestMethod] //#8. asserts the code isnt null
        public void IsNotNull() 
        {
            Assert.IsNotNull(BalancedBrackets.HasBalancedBrackets("[LAUNCHCODE"));
        }


        [TestMethod] //#9. What if my string has multiple brackets?
        public void ContainsMultipleBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Hello Launchcode]]"));
        }

        [TestMethod] //#10. What if there is only a closing bracket?
        public void OnlyCloseBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod] //#11. What if there is only an open bracket?
        public void OnlyOpenBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("["));
        }



        [TestMethod] //#12
        public void TryingALotOfBrackets ()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[Hello World]]]]"));
        }
















    }
}
