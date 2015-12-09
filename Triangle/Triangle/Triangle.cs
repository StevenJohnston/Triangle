using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNS
{
    public class Triangle
    {
        double sideOne;
        double sideTwo;
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
    }
}
