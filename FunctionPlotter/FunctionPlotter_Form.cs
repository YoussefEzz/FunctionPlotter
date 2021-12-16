using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionPlotter
{
    public partial class FunctionPlotter_Form : Form
    {
        public FunctionPlotter_Form()
        {
            InitializeComponent();
        }

        private void Plotbutton_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(functiontextBox.Text);
            Parser parser = new Parser(scanner);

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            int min = int.Parse(mintextBox.Text);
            int max = int.Parse(maxtextBox.Text);

            plotchart.Series["Function Series"].Points.Clear();
            for (int x = min; x <= max; x++)
            {
                int y = parser.parse(x);
                plotchart.Series["Function Series"].Points.AddXY(x, y);
            }

            utility.closeScannerfile();




        }
    }
}
