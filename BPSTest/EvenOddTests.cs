using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBPSConsoleApplication.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBPSConsoleApplication.Program.Tests
{
    [TestClass()]
    public class EvenOddTests
    {
        [TestMethod()]
        public void EDTest()
        {
            //arrange

            int input = 12;
            var expected = "12 is an even number";

            //act
            var actual= $"{input} is an even number";
            //assert


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ODTest()
        {
            //arrange

            int input = 13;
            var expected = "13 is an odd number";

            //act
            var actual = $"{input} is an odd number";
            //assert


            Assert.AreEqual(expected, actual);
        }

      
    }
}