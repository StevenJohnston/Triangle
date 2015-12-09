/*
    Name: Steven Johnston
    Date: 12/9/2015
    Assignment: #3
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;
namespace Triangle_Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the set and get for  SideOne.
        /// </summary>
        [TestMethod]
        public void TestSetGetSideLengthOne()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 1;
            Assert.AreEqual( 1, triangle.SideOne);
        }
        /// <summary>
        /// Tests the set and get for  SideTwo.
        /// </summary>
        [TestMethod]
        public void TestSetGetSideLengthTwo()
        {
            Triangle triangle = new Triangle();
            triangle.SideTwo = 1;
            Assert.AreEqual(1, triangle.SideTwo);
        }
        /// <summary>
        /// Tests the set and get for  AngleOne.
        /// </summary>
        [TestMethod]
        public void TestSetGetAngleOne()
        {
            Triangle triangle = new Triangle();
            triangle.AngleOne = 10.5;
            Assert.AreEqual( 10.5,triangle.AngleOne);
        }
        /// <summary>
        /// Tests the set and get for  AngleTwo.
        /// </summary>
        [TestMethod]
        public void TestSetGetAngleTwo()
        {
            Triangle triangle = new Triangle();
            triangle.AngleTwo = 10.5;
            Assert.AreEqual(10.5,triangle.AngleTwo);
        }
        /// <summary>
        /// Tests the GetHypotenuse.
        /// </summary>
        [TestMethod]
        public void TestGetHypotenuse()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 3;
            triangle.SideTwo = 4;
            Assert.AreEqual(5, triangle.GetHypotenuse());
        }
        /// <summary>
        /// Tests the GetArea.
        /// </summary>
        [TestMethod]
        public void TestGetArea()
        {
            Triangle triangle = new Triangle();
            triangle.SideOne = 3;
            triangle.SideTwo = 4;
            Assert.AreEqual(6, triangle.GetArea());
        }
        /// <summary>
        /// Tests the GetMissingAngle.
        /// </summary>
        [TestMethod]
        public void TestGetMissingAngle()
        {
            Triangle triangle = new Triangle();
            triangle.AngleOne = 50;
            triangle.AngleTwo = 90;
            Assert.AreEqual(40, triangle.GetMissingAngle());
        }
    }
}
