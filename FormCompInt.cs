using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterest {
    public partial class FormCompInt : Form {
        public FormCompInt() {
            InitializeComponent();
        }

        private void btCalc_Click(object sender, EventArgs e) {

            double initSum = 0, monthDep = 0, interest = 0, compInt = 0;
            double formula;
            int years = (int)numYear.Value;
            string output = "";

            try {
                initSum = Double.Parse(tBoxInitialSum.Text);
                monthDep = Double.Parse(tBoxMonthlyDep.Text);
                interest = Double.Parse(tBoxInterRate.Text);
                years = (int)numYear.Value;
            }
            catch (FormatException) {                                                               //Format exception for catching bad characters in input
                MessageBox.Show("Entered invalid characters", "Error");
            }

            formula = Math.Pow(1 + ((interest / 100) / 12), 12 * 1);                            //Formula for calculating compound interest
            compInt = initSum + (monthDep * 12) * formula;                                      //Calculating compound interest for first year that includes initial sum
            output = $"Year 1, total sum {String.Format("{0:0.00}", compInt)}\n";               //Output string with formating, that shows total sum with two decimal places

            for (int i = 2; i <= years; i++) {                                                  //Loop, in which is counted remained years form year 2 further
                formula = Math.Pow(1 + ((interest / 100) / 12), 12 * i);                        //Formula for calculating compound interest
                compInt += (monthDep * 12) * formula;                                           //Calculating compound interest for another years
                output += $"Year {i}, total sum {String.Format("{0:0.00}", compInt)}\n";
            }
            tBoxCalc.Text = output;
        }
    }
}
