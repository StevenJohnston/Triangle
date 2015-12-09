/*
    Name: Steven Johnston
    Date: 12/9/2015
    Assignment: #3
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleNS
{
    public partial class TriangleForm : Form
    {
        Triangle myTriangle = new Triangle();
        public TriangleForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculates the Hypotenuse of the triangle
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRightAngle_Click(object sender, EventArgs e)
        {
            myTriangle.SideOne = Convert.ToDouble(txtLengthOne.Text);
            myTriangle.SideTwo = Convert.ToDouble(txtLengthTwo.Text);
            txtLengthThree.Text = myTriangle.GetHypotenuse().ToString();
        }
        /// <summary>
        /// Calculates the Area of the triangle
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnArea_Click(object sender, EventArgs e)
        {
            myTriangle.SideOne = Convert.ToDouble(txtLengthOne.Text);
            myTriangle.SideTwo = Convert.ToDouble(txtLengthTwo.Text);
            txtLengthThree.Text = myTriangle.GetArea().ToString();
        }
        /// <summary>
        /// calculates the missing angle of the triangle
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnMissingAngle_Click(object sender, EventArgs e)
        {
            myTriangle.AngleOne = Convert.ToDouble(txtAngleOne.Text);
            myTriangle.AngleTwo = Convert.ToDouble(txtAngleTwo.Text);
            txtAngleThree.Text = myTriangle.GetMissingAngle().ToString();
        }
    }
}
