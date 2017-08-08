using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteStream.UnitTest
{
    [TestClass]
    public class firstCharTest
    {
        [TestMethod]
        public void firstCharTest_aAbBABacfe()
        {
            Stream stream = new Stream("aAbBABacfe");
            Assert.AreEqual(Program.firstChar(stream), char.Parse("e"));
        }

        [TestMethod]
        [ExpectedException(typeof(FirstCharException))]
        public void firstCharTest_aAbBABacfee()
        {
            Stream stream = new Stream("aAbBABacfee");
            Program.firstChar(stream);
        }

        [TestMethod]
        public void firstCharTest_Ba()
        {
            Stream stream = new Stream("Ba");
            Assert.AreEqual(Program.firstChar(stream), char.Parse("a"));
        }

        [TestMethod]
        public void firstCharTest_CdaTaFeiHoCi()
        {
            Stream stream = new Stream("CdaTaFeiHoCi");
            Assert.AreEqual(Program.firstChar(stream), char.Parse("e"));
        }

        [TestMethod]
        [ExpectedException(typeof(FirstCharException))]
        public void firstCharTest_CDFG()
        {
            Stream stream = new Stream("CDFG");
            Program.firstChar(stream);
        }

        [TestMethod]
        [ExpectedException(typeof(FirstCharException))]
        public void firstCharTestNull()
        {
            Stream stream = new Stream("");
            Program.firstChar(stream);
        }
    }
}
