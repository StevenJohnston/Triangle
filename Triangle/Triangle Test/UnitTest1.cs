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
            Assert.AreEqual( 1, triangle.SideOne);
        }
        [TestMethod]
        public void TestSetGetSideLengthTwo()
        {
            Triangle triangle = new Triangle();
            triangle.SideTwo = 1;
            Assert.AreEqual(1, triangle.SideTwo);
        }
        [TestMethod]
        public void TestSetGetAngleOne()
        {
            Triangle triangle = new Triangle();
            triangle.AngleOne = 10.5;
            Assert.AreEqual( 10.5,triangle.AngleOne);
        }
        [TestMethod]
        public void TestSetGetAngleTwo()
        {
            Triangle triangle = new Triangle();
            triangle.AngleTwo = 10.5;
            Assert.AreEqual(10.5,triangle.AngleTwo);
        }
        [TestMethod]
        public void TestGetHypotenuse()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 3;
            triangle.SideTwo = 4;
            Assert.AreEqual(5, triangle.GetHypotenuse());
        }
        [TestMethod]
        public void TestGetArea()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 3;
            triangle.SideTwo = 4;
            Assert.AreEqual(6, triangle.GetArea());
        }

        [TestMethod]
        public void TestGetMissingAngle()
        {
            Triangle triangle = new Triangle();
            triangle.AngleOne = 45;
            triangle.AngleTwo = 90;
            Assert.AreEqual(6, triangle.GetMissingAngle());
        }
    }
}
