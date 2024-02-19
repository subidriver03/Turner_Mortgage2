using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turner_Mortgage
{
    public partial class frmMortgageCalculator : Form
    {
        public frmMortgageCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPrincipalWhole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle the event, effectively ignoring the input
            }
        }

        private void txtPrincipalWhole_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbInterestValue_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            bool inputIsValid = true;
            double annualRate = 0.0;

            // Check if principal is valid
            if (!double.TryParse(txtPrincipalWhole.Text, out double P) || string.IsNullOrWhiteSpace(txtPrincipalWhole.Text))
            {
                errorMessages.AppendLine("- The principal textbox must contain only digits.");
                inputIsValid = false;
            }

            // Check if term is selected and valid
            int n = 0;
            if (rbtn15.Checked) n = 15 * 12;
            else if (rbtn30.Checked) n = 30 * 12;
            else if (rbtnOther.Checked)
            {
                if (!int.TryParse(txtOther.Text, out n) || n < 5 || n > 40)
                {
                    errorMessages.AppendLine("- For 'Other' term, the value must be a number between 5 and 40.");
                    inputIsValid = false;
                }
                else n *= 12; // Convert years to months for 'Other'
            }
            else
            {
                errorMessages.AppendLine("- No term option has been selected.");
                inputIsValid = false;
            }

            // Check if rate is selected
            if (cmbInterestValue.SelectedIndex == -1 || !double.TryParse(cmbInterestValue.SelectedItem?.ToString(), out annualRate))
            {
                errorMessages.AppendLine("- No interest rate has been selected.");
                inputIsValid = false;
            }

            // If any input is not valid, display errors and return
            if (!inputIsValid)
            {
                lblFinalResult.Visible = true;
                lblFinalResult.Text = "Errors found:\n" + errorMessages.ToString();
                return; // Stop further processing
            }

            // If input is valid, proceed with calculation
            double r = annualRate / 100 / 12; // Convert annual rate to monthly decimal rate
            double M = P * (r * Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1);

            lblFinalResult.Visible = true;
            lblFinalResult.Text = $"Monthly Payment: {M:C}";

            // Enable the reset button only after successful calculation
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipalWhole.Clear();

            // Reset RadioButton selection to default (e.g., 30 Years)
            rbtn30.Checked = true;
            rbtn15.Checked = false;
            rbtnOther.Checked = false;

            // Make sure the 'Other' TextBox is hidden
            txtOther.Visible = false;
            txtOther.Clear(); // Also clear any text if present

            // Reset the ComboBox selection to the first item or no selection
            cmbInterestValue.SelectedIndex = -1; // This removes any selection, you can set to 0 for selecting the first item

            // Clear the final result label
            lblFinalResult.Text = "";

            // Optionally, set focus back to the principal amount TextBox
            txtPrincipalWhole.Focus();
            btnReset.Enabled = false;
        }

        private void rbtnOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.Visible = rbtnOther.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
         this.Close();
            }

        private void lblFinalResult_Click(object sender, EventArgs e)
        {

        }

        private void lblFinalResult_Click_1(object sender, EventArgs e)
        {
            lblFinalResult.Visible = false;
        }
    }
    }
    


