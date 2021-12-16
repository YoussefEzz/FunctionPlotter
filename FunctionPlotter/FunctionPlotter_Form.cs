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
            if(!Validation.IntegerValidator(mintextBox.Text))
            {
                MessageBox.Show("min value must be an integer");
                return;
            }
            if(!Validation.IntegerValidator(maxtextBox.Text))
            {
                MessageBox.Show("max value must be an integer");
                return;
            }

            Scanner scanner = new Scanner(functiontextBox.Text);
            Parser parser = new Parser(scanner);
            

            int min = int.Parse(mintextBox.Text);
            int max = int.Parse(maxtextBox.Text);

            plotchart.Series["Function Series"].Points.Clear();
            for (int x = min; x <= max; x++)
            {
                try
                {
                    int y = parser.parse(x);
                    plotchart.Series["Function Series"].Points.AddXY(x, y);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    parser.reset();
                    break;
                }
                
                
            }

            utility.closeScannerfile();




        }
    }
}
