namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculatorForm : Form
    {
        public TipAndTaxCalculatorForm()
        {
            InitializeComponent();
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


        // Event handlers below here ------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
