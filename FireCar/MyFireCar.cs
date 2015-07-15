using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladderss;
using NUnit.Framework;

namespace FireCar
{
    [TestFixture]
    public class MyFireCar
    {
        [Test]
        public void testName() {
            var s = new Ladder().Get();
            Assert.That(s, Is.EqualTo("Fire chassis v1.0.1 and Ladder length 10"));

            var s1 = new WaterTank.WaterTank().Get();
            Assert.That(s1, Is.EqualTo("Fire chassis v1.0.1 and WaterTank length 20"));

        }
    }
}
