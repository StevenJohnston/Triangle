using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;
namespace Triangle_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetSideLengthOne()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 1;
            Assert.AreEqual(triangle.SideOne, 1);
        }
        [TestMethod]
        public void TestSetSideLengthTwo()
        {
            Triangle triangle = new Triangle();
            triangle.SideTwo = 1;
            Assert.AreEqual(triangle.SideTwo,1);
        }
    }
}
