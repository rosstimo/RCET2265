namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculatorForm : Form
    {
        public TipAndTaxCalculatorForm()
        {
            InitializeComponent();
            SetDefaults();
        }
        /*
         TODO:
         [x] Set defaults
         [ ] Tip amount after discount include tax
         [ ] calculate state tax amount after discount exclude tip
         [ ] calculate discount amounts / total discount
         [ ] display original, discounts, tip, tax, amount due formatted as currency
        */

        // custom methods -----------------------------------------------------

        /// <summary>
        /// Resets all input fields and controls to their default values.
        /// </summary>
        /// <remarks>Use this method to clear user input and restore the initial state of the form. This
        /// is typically called when starting a new calculation or after completing an operation.</remarks>
        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            Tip15RadioButton.Checked = true;
            TipCustomTextBox.Text = "";
            TipCustomTextBox.Enabled = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
            DisplayLabel.Text = "";
            AllFeildsValid();
            DollarAmountTextBox.Select();

        }

        bool AllFeildsValid()
        {
            bool _valid = true;
            try
            {
                decimal.Parse(DollarAmountTextBox.Text);
                DollarAmountTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                DollarAmountTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }
            return _valid;
        }

        /// <summary>
        /// Calculates the tip amount based on the specified subtotal and the currently selected tip percentage option.
        /// </summary>
        /// <remarks>The tip percentage is determined by the selected radio button (15%, 18%, 20%, or a
        /// custom value). If no valid option is selected, the method returns 0.</remarks>
        /// <param name="thisAmount">The subtotal amount on which to calculate the tip. Must be a non-negative value.</param>
        /// <returns>The calculated tip amount as a decimal value. Returns 0 if no valid tip percentage option is selected.</returns>
        decimal CalculateTipOn(decimal thisAmount)
        {
            decimal subTotal = 0;
            switch (true)
            {
                case bool when Tip15RadioButton.Checked:
                    subTotal = thisAmount * 0.15m;
                    break;
                case bool when Tip18RadioButton.Checked:
                    subTotal = thisAmount * 0.18m;
                    break;
                case bool when Tip20RadioButton.Checked:
                    subTotal = thisAmount * 0.20m;
                    break;
                case bool when TipCustomRadioButton.Checked:
                    //TODO
                    break;
                default:
                    MessageBox.Show("This tip should never happen!");
                    break;
            }
            return subTotal;
        }

        // Event handlers below here ------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void DollarAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            AllFeildsValid();
        }

        private void TipCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TipCustomRadioButton.Checked)
            {
                TipCustomTextBox.Enabled = true;
            }
            else
            {
                TipCustomTextBox.Text = "";
                TipCustomTextBox.Enabled = false;
            }
        }
    }
}
