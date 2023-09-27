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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(txtHeight.Text);
                double w = Convert.ToDouble(txtWidth.Text);

                double area = h * w;
                double perimeter = (2 * h) + (2 * w);

                lblArea.Text = "Area = " + area;
                lblPerimeter.Text = "Perimeter = " + perimeter;
            }
            catch
            {
                lblArea.Text = "Invalid input";
                lblPerimeter.Text = "";
            }
        }
    }
}
