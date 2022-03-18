using System;
using System.Windows.Forms;

/***************************************************************
 * File: IncomeTaxCalculator.cs                                *
 * Author: Yosef D. Figueroa Sánchez 841-17-9954               *
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas              *
 * Date: 02/27/2022                                            *
 * Purpose: This aplication calculates de income tax provided  *
 * by the user. It chooses the income tax that needs to be     *
 * calculated depending on the amount provided.                *
 **************************************************************/

namespace Exercide2Exam1Final
{
    public partial class IncomeTaxCalculatorForm : Form
    {
        public IncomeTaxCalculatorForm()
        {
            InitializeComponent();
        }
        // Saves the amount provided by the user and checks that is a valid number, at the end it calculates
        //the income tax and shows the total un the second text box.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal taxableIncome;
            try
            {
                taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
                //checks that the number is positive
                if (taxableIncome < 0)
                {
                    throw new ArgumentOutOfRangeException("Integer must not be negative");
                }
                decimal totalTax = incomeTaxOwed(taxableIncome);
                //returns the total to the second text box
                txtIncomeTaxOwed.Text = totalTax.ToString("c");
            }
            //Catches any text that is not a number
            catch (FormatException)
            {
                MessageBox.Show("Check all entries are numbers.", "Format Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Catches negative numbers
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Integer must be a positive", "must be positive",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method that calculates the income tax owed and returns it to the user
        //uses a switch expression to choose the tax that will be calculated
        private static decimal incomeTaxOwed(decimal taxableIncome)
        {
            decimal incomeTaxOwed = taxableIncome switch
            {

                <= 9225 => 0.0M + Math.Truncate((taxableIncome - 0) * 0.10M),
                <= 37450 => 922.50M + Math.Truncate((taxableIncome - 9225) * 0.15M),
                <= 90750 => 5156.25M + Math.Truncate((taxableIncome - 37450) * 0.25M),
                <= 189300 => 18481.25M + Math.Truncate((taxableIncome - 90750) * 0.28M),
                <= 411500 => 46075.25M + Math.Truncate((taxableIncome - 189300) * 0.33M),
                <= 413200 => 119401.25M + Math.Truncate((taxableIncome - 411500) * 0.35M),
                _ => 19999625M + Math.Truncate((taxableIncome - 413200) * 0.396M)
            };
            return incomeTaxOwed;
        }
        //Button that closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
