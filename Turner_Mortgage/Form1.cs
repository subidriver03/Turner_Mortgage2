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

        private void btnCaclulate_Click(object sender, EventArgs e)
        {
                if (!double.TryParse(txtPrincipalWhole.Text, out double P))
                {
                    MessageBox.Show("Please enter a valid principal amount.");
                    txtPrincipalWhole.Clear();
                    txtPrincipalWhole.Focus();
                    return;
                }

                int n;
                if (rbtn15.Checked) n = 15 * 12;
                else if (rbtn30.Checked) n = 30 * 12;
                else if (!int.TryParse(txtOther.Text, out n) || n <= 0)
                {
                    MessageBox.Show("Please enter a valid number of years in 'Other'.");
                    txtOther.Clear();
                    txtOther.Focus();
                    return;
                }
                else n *= 12; // Convert years to months for 'Other'

                if (!double.TryParse(cmbInterestValue.SelectedItem.ToString(), out double annualRate))
                {
                    MessageBox.Show("Please select a valid interest rate.");
                    cmbInterestValue.Focus();
                    return;
                }
                double r = annualRate / 100 / 12; // Convert annual rate to monthly decimal rate

                double M = P * (r * Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1);
            lblFinalResult.Visible = true;
            lblFinalResult.Text = $"Monthly Payment: {M:C}";

            
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
    


