/*
    Name: Steven Johnston
    Date: 12/9/2015
    Assignment: #3
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNS
{
    public class Triangle
    {
        double angleTwo;
        double angleOne;
        double sideOne;
        double sideTwo;

        public double AngleOne
        {
            get
            {
                return angleOne;
            }

            set
            {
                angleOne = value;
            }
        }

        public double SideOne
        {
            get
            {
                return sideOne;
            }

            set
            {
                if(value > 0)
                    sideOne = value;
            }
        }

        public double SideTwo
        {
            get
            {
                return sideTwo;
            }

            set
            {
                if (value > 0)
                    sideTwo = value;
            }
        }

        public double AngleTwo
        {
            get
            {
                return angleTwo;
            }

            set
            {
                angleTwo = value;
            }
        }
        

        public double GetHypotenuse()
        {
            return Math.Sqrt(SideOne * sideOne + SideTwo * SideTwo);
        }

        public double GetArea()
        {
            return sideOne * sideTwo / 2;
        }

        public double GetMissingAngle()
        {
            return 180 - angleOne - angleTwo;
        }
    }
}
