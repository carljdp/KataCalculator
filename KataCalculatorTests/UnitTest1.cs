using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataCalculator;

namespace KataCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Step1_ShouldTakeAStringAndReturnANumber()
        {
            Assert.AreEqual(0, StringCalculator.Add(""));
        }

        [TestMethod]
        public void Step2_ShouldTakeASingleNumberAndReturnThatNumber()
        {
            
            Assert.AreEqual(1, StringCalculator.Add("1"));
            Assert.AreEqual(3, StringCalculator.Add("3"));
        }

        [TestMethod]
        public void Step3_TwoNumbersReturnSum()
        {
            Assert.AreEqual(3, StringCalculator.Add("1,2"));
            Assert.AreEqual(8, StringCalculator.Add("3,5"));
        }

        [TestMethod]
        public void Step4_AnyAmountOfNumbersReturnsTheSum()
        {
            Assert.AreEqual(6, StringCalculator.Add("1,2,3"));
            Assert.AreEqual(20, StringCalculator.Add("3,5,3,9"));
        }
        
        
        
    }
}