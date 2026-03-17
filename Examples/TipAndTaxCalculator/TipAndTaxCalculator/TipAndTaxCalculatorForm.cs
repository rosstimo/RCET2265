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
         [ ] Set defaults
         [ ] Tip amount after discount exclude tax
         [ ] calculate state tax amount after discount exclude tip
         [ ] calculate discount amounts / total discount
         [ ] display original, discounts, tip, tax, amount due formatted as currency
        */

        // custom methods -----------------------------------------------------
        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            Tip15RadioButton.Checked = true;
            TipCustomTextBox.Text = "";
            TipCustomTextBox.Enabled = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
            DisplayLabel.Text = "";
            DollarAmountTextBox.Select();

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
    }
}
