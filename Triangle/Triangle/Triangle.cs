using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNS
{
    public class Triangle
    {
        double sideOne, sideTwo, sideThree;
        double angleOne, angleTwo, angleThree;

        public double SideOne
        {
            get
            {
                return sideOne;
            }

            set
            {
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
                sideTwo = value;
            }
        }

        public double SideThree
        {
            get
            {
                return sideThree;
            }

            set
            {
                sideThree = value;
            }
        }

        public double AngleOne
        {
            get
            {
                return AngleOne1;
            }

            set
            {
                AngleOne1 = value;
            }
        }

        public double AngleTwo
        {
            get
            {
                return AngleTwo1;
            }

            set
            {
                AngleTwo1 = value;
            }
        }

        public double AngleOne1
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

        public double AngleTwo1
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

        public double AngleThree
        {
            get
            {
                return angleThree;
            }

            set
            {
                angleThree = value;
            }
        }

        double GetHypotenuse()
        {
            return 0;
        }
        double GetMissingAngle()
        {
            return 0;
        }
    }
}
