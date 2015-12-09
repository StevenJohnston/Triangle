using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;
namespace Triangle_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRightAngleHypotenuse()
        {
            Triangle triangle = new Triangle();
            Assert.AreEqual(triangle.GetHypotenuse(), 1);
        }
    }
}
