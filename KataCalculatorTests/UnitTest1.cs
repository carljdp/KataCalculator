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
            Assert.AreEqual(0, Program.Add(""));
        }
        
        
        
    }
}