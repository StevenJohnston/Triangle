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
        /// <summary>
        /// Gets or sets the angle one.
        /// </summary>
        /// <value>
        /// The angle one.
        /// </value>
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
        /// <summary>
        /// Gets or sets the side one.
        /// </summary>
        /// <value>
        /// The side one.
        /// </value>
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
        /// <summary>
        /// Gets or sets the side two.
        /// </summary>
        /// <value>
        /// The side two.
        /// </value>
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
        /// <summary>
        /// Gets or sets the angle two.
        /// </summary>
        /// <value>
        /// The angle two.
        /// </value>
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

        /// <summary>
        /// Gets the hypotenuse.
        /// </summary>
        /// <returns></returns>
        public double GetHypotenuse()
        {
            return Math.Sqrt(SideOne * sideOne + SideTwo * SideTwo);
        }
        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return sideOne * sideTwo / 2;
        }
        /// <summary>
        /// Gets the missing angle.
        /// </summary>
        /// <returns></returns>
        public double GetMissingAngle()
        {
            return 180 - angleOne - angleTwo;
        }
    }
}
