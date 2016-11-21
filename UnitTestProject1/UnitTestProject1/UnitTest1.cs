using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod102()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.Fail();
        }
        [TestMethod]
        public void TestMethod103()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod104()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod105()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestMethod106()
        {
            Console.WriteLine("Hiiiasadasdas");
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("asdas");
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Hiiiasasdasds");
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("Hiiiasasdasdas");
            Assert.Inconclusive();
        }
    }
}
