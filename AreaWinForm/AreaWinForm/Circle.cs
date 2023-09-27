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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(txtRadius.Text);

                double area = (3.14 * Math.Pow(r, 2));
                double perimeter = 3.14 * (r * 2);

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
