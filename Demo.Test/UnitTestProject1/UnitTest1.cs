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
            var test = new ClassLibrary1.Class1();
            var date = test.DateToString();
            Assert.AreEqual(DateTime.Today.ToShortDateString(), date);
        }
    }
}
