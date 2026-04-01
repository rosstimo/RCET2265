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
         [x] Tip amount after discount include tax
         [x] calculate state tax amount after discount exclude tip
         [x] calculate discount amounts / total discount
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
            TipCustomTextBox.Text = "0";
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
            // validate dollar amount
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
            // validate custom tip amount
            try
            {
                decimal.Parse(TipCustomTextBox.Text);
                TipCustomTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                TipCustomTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }
            return _valid;
        }
        
        /// <summary>
        /// Calculates the AAA membership discount for the specified amount.
        /// </summary>
        /// <param name="thisAmount">The original amount to which the AAA discount will be applied. Must be a non-negative value.</param>
        /// <returns>The calculated discount amount, equal to 3 percent of the specified amount.</returns>
        decimal CalculateAAADiscountOn(decimal thisAmount)
        {
            return thisAmount * 0.03m;
        }
        /// <summary>
        /// Calculates the discount amount for a Diners Club card transaction based on the specified amount.
        /// </summary>
        /// <param name="thisAmount">The transaction amount on which to calculate the Diners Club card discount. Must be a non-negative value.</param>
        /// <returns>The discount amount to be applied to the transaction. The value is 5% of the specified amount.</returns>
        decimal CalculateDinersCardDiscountOn(decimal thisAmount)
        {
            return thisAmount * 0.05m;
        }
        /// <summary>
        /// Calculates the tax amount for the specified monetary value using a fixed tax rate.
        /// </summary>
        /// <param name="thisAmount">The monetary amount on which to calculate tax. Must be a non-negative value.</param>
        /// <returns>The calculated tax amount based on the specified value.</returns>
        decimal CalculateTaxOn(decimal thisAmount)
        { 
            return thisAmount * 0.06m;
        }

        /// <summary>
        /// Calculates the tip amount based on the specified subtotal and the currently selected tip percentage option.
        /// </summary>
        /// <remarks>The tip percentage is determined by the selected radio button (15%, 18%, 20%, or a
        /// custom value). If no valid option is selected, the method returns 0.</remarks>
        /// <param name="thisAmount">The subtotal amount on which to calculate the tip. Must be a non-negative value.</param>
        /// <returns>The calculated tip amount as a decimal value. Returns 0 if no valid tip percentage option is selected.</returns>
        decimal CalculateTipOn(decimal thisAmount , decimal customTip = 0)
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
                    subTotal = customTip;
                    break;
                default:
                    MessageBox.Show("This tip should never happen!");
                    break;
            }
            return subTotal;
        }
        void DisplayTransaction()
        {
            decimal originalAmount = 0;
            decimal totalDiscount = 0;
            decimal tax = 0;
            decimal tip = 0;
            decimal amountDue = 0;
            int padding = 15;
            if (AllFeildsValid())
            {
                originalAmount = decimal.Parse(DollarAmountTextBox.Text);
                totalDiscount += CalculateAAADiscountOn(originalAmount);// TODO check checkbox
                totalDiscount += CalculateDinersCardDiscountOn(originalAmount);// TODO check checkbox
                tax = CalculateTaxOn(originalAmount - totalDiscount);
                tip = CalculateTipOn(originalAmount - totalDiscount + tax);
                amountDue = originalAmount - totalDiscount + tax + tip;

                //TODO refactor per Luke
                DisplayLabel.Text = "Charges:".PadRight(padding) + $"{originalAmount.ToString("C")}\n" +
                "Discount:".PadRight(padding) + $"{totalDiscount.ToString("C")}\n" +
                "Sales Tax:".PadRight(padding) + $"{tax.ToString("C")}\n" +
                "Subtotal:".PadRight(padding) + $"??\n" +
                "Tip:".PadRight(padding) + $"{tip.ToString("C")}\n" +
                "Total:".PadRight(padding) + $"{amountDue.ToString("C")}";
            }
        

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
            DisplayTransaction();
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
