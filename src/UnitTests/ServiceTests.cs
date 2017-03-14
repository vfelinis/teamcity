using ConsoleApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class ServiceTests
    {
        [Test]
        public void SumTest()
        {
            Service service = new Service();
            var expected = 10;

            var actual = service.Sum(5, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
