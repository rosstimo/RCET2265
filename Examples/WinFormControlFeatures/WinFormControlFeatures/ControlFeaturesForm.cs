namespace WinFormControlFeatures
{
    public partial class ControlFeaturesForm : Form
    {
        public ControlFeaturesForm()
        {
            InitializeComponent();

            SetDefaults(); // after initialize
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

            ValidateInputFields();

        }

        bool ValidateInputFields()
        {
            bool allFieldsAreValid = true;
            NameTextBox.BackColor = Color.White;
            AgeTextBox.BackColor = Color.White;
            PhoneTextBox.BackColor = Color.White;
            int _age = 0;
            
            if (PhoneTextBox.Text == "")
            {
                allFieldsAreValid = false;
                PhoneTextBox.BackColor = Color.LightYellow;
            }

            try
            {
                _age = int.Parse(AgeTextBox.Text);
                if (_age <=0 || _age >= 50)
                {
                    allFieldsAreValid = false;
                    AgeTextBox.BackColor = Color.LightYellow;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                AgeTextBox.BackColor = Color.LightYellow;
                //AgeTextBox.Focus();
            }

            // name should not be empty
            if (NameTextBox.Text == "")
            {
                allFieldsAreValid = false;
                NameTextBox.BackColor = Color.LightYellow;
                //NameTextBox.Focus();
            }




                SubmitButton.Enabled = allFieldsAreValid;
                return allFieldsAreValid;
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

        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }
    }
}
