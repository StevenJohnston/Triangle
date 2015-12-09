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

        private void btnRightAngle_Click(object sender, EventArgs e)
        {
            myTriangle.SideOne = Convert.ToDouble(txtLengthOne.Text);
            myTriangle.SideTwo = Convert.ToDouble(txtLengthTwo.Text);
            txtLengthThree.Text = myTriangle.GetHypotenuse().ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            myTriangle.SideOne = Convert.ToDouble(txtLengthOne.Text);
            myTriangle.SideTwo = Convert.ToDouble(txtLengthTwo.Text);
            txtLengthThree.Text = myTriangle.GetArea().ToString();
        }

        private void btnMissingAngle_Click(object sender, EventArgs e)
        {
            myTriangle.AngleOne = Convert.ToDouble(txtAngleOne.Text);
            myTriangle.AngleTwo = Convert.ToDouble(txtAngleTwo.Text);
            txtAngleThree.Text = myTriangle.GetMissingAngle().ToString();
        }
    }
}
