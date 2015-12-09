using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;
namespace Triangle_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetGetSideLengthOne()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 1;
            Assert.AreEqual(triangle.SideOne, 1);
        }
        [TestMethod]
        public void TestSetGetSideLengthTwo()
        {
            Triangle triangle = new Triangle();
            triangle.SideTwo = 1;
            Assert.AreEqual(triangle.SideTwo,1);
        }
        [TestMethod]
        public void TestSetGetAngleOne()
        {
            Triangle triangle = new Triangle();
            triangle.AngleOne = 10.5;
            Assert.AreEqual(triangle.AngleOne, 10.5);
        }
        [TestMethod]
        public void TestSetGetAngleTwo()
        {
            Triangle triangle = new Triangle();
            triangle.AngleTwo = 10.5;
            Assert.AreEqual(triangle.AngleTwo, 10.5);
        }
        [TestMethod]
        public void TestGetHypotenuse()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 5;
            triangle.SideTwo = 10;
            triangle.AngleTwo = 10.5;
            Assert.AreEqual(triangle.GetHypotenuse(), 1);
        }
    }
}
