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

        [TestMethod()]
        public void PercentageLetters33perc()
        {
            var inputSentence = "333fff333";
            var percentage = Logic.PercentageLetters(inputSentence);


            Assert.AreEqual(33.33, percentage);
        }

        [TestMethod()]
        public void PercentageLetters100perc()
        {
            var inputSentence = "lllfffaaa";
            var percentage = Logic.PercentageLetters(inputSentence);


            Assert.AreEqual(100, percentage);
        }
    }
}