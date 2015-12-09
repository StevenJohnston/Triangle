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
            triangle.SideOne = "";
            Assert.AreEqual(triangle.GetHypotenuse(), 1);
        }
    }
}
