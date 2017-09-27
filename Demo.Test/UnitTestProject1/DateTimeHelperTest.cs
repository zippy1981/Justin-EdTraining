using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class DateTimeHelperTest
    {
        [TestMethod]
        public void TestDateToString()
        {
            var helper = new DateTimeHelper();
            var date = helper.DateToString();
            Assert.AreEqual(DateTime.Today.ToShortDateString(), date);
        }
    }
}
