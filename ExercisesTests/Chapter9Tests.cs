using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class Chapter9Tests
    {
        [TestMethod()]
        public void GetMaxTest()
        {
            int a = 10, b = 11, c = 12;
            int result = Chapter9.GetMax(a, Chapter9.GetMax(b, c));
            Assert.AreEqual(c, result);
        }
    }
}