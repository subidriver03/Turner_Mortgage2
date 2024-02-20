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
                e.Handled = true;
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

            if (!double.TryParse(txtPrincipalWhole.Text, out double P) || string.IsNullOrWhiteSpace(txtPrincipalWhole.Text))
            {
                errorMessages.AppendLine("- The principal textbox must contain only digits.");
                inputIsValid = false;
            }

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
                else n *= 12;
            }
            else
            {
                errorMessages.AppendLine("- No term option has been selected.");
                inputIsValid = false;
            }


            if (cmbInterestValue.SelectedIndex == -1 || !double.TryParse(cmbInterestValue.SelectedItem?.ToString(), out annualRate))
            {
                errorMessages.AppendLine("- No interest rate has been selected.");
                inputIsValid = false;
            }

            if (!inputIsValid)
            {
                lblFinalResult.Visible = true;
                lblFinalResult.Text = "Errors found:\n" + errorMessages.ToString();
                return;
            }

           
            double r = annualRate / 100 / 12; 
            double M = P * (r * Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1);

            lblFinalResult.Visible = true;
            lblFinalResult.Text = $"Monthly Payment: {M:C}";

            
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipalWhole.Clear();

            
            rbtn30.Checked = true;
            rbtn15.Checked = false;
            rbtnOther.Checked = false;

            
            txtOther.Visible = false;
            txtOther.Clear(); 

            
            cmbInterestValue.SelectedIndex = -1;
            lblFinalResult.Text = "";

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
    


