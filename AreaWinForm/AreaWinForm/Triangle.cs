using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaWinForm
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtSideA.Text);
                double b = Convert.ToDouble(txtSideB.Text);
                double c = Convert.ToDouble(txtSideC.Text);

                if (a <= b + c && b <= a + c && c <= a + b)
                {
                    double s = (a + b + c) / 2;
                    double area  = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    double perimeter = a + b + c;
                    lblArea.Text = "Area = " + area;
                    lblPerimeter.Text = "Perimeter = " + perimeter;
                }
                else
                {
                    lblArea.Text = "Invalid Triangle";
                    lblPerimeter.Text = "";
                }
            }
            catch 
            {
                lblArea.Text = "Invalid input";
                lblPerimeter.Text = "";
            }
        }
    }
}
