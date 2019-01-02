using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charades.Tests
{
    [TestFixture]
    public class FirstUnitTests
    {
        [Test]
        public void TestNumbaOne()
        {
            var a = 10;
            var b = 5 * 2;

            Assert.AreEqual(a, b);
        }

        [Test]
        public void TestNumbaTwo()
        {
            var a = 10;
            var b = 5 * 3;

            Assert.AreNotEqual(a, b);
        }

        [Test]
        public void TestThatGonnaFail()
        {
            var a = 30;
            var b = 5 * 2;

            Assert.AreEqual(a, b);
        }
    }
}
