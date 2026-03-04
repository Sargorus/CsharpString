using Microsoft.VisualStudio.TestTools.UnitTesting;
using С_String1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_String1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void PercentageLettersNULLSentence()
        {
            var inputSentence = "";
            var percentage = Logic.PercentageLetters(inputSentence);


            Assert.AreEqual(-1, percentage);
        }
    }
}