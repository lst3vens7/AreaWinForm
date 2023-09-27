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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.ShowDialog();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.ShowDialog();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShowDialog();
        }
    }
}
