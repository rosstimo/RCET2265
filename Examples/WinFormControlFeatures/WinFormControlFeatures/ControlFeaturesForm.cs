namespace WinFormControlFeatures
{
    public partial class ControlFeaturesForm : Form
    {
        public ControlFeaturesForm()
        {
            InitializeComponent();
        }

        // Program Logic ------------------------------------------------------
        void SetDefaults()
        {
            // information fields
            NameTextBox.Text = "";
            NameTextBox.Focus();
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            //options
            UpperRadioButton.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            // output

        }


        // Event Handlers------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
