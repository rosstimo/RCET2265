using System.Diagnostics.Eventing.Reader;

namespace WinFormControlFeatures
{
    public partial class ControlFeaturesForm : Form
    {
        /*TODO
            [ ] Save client info in a data structure. (array, list, etc)
            [ ] Use list box to display single client record
            [ ] Use combobox to select existing client record
            [ ] When selected populate text fields and listbox with client details
            [ ] Submit will update client record or create it if it doesn't exist
            [ ] May need a unique id number for each client to avoid duplicates
            [ ] Save and restore clients using a file
            [ ] File dialogue controls
        */
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
            FormatCheckBox.Checked = false;
            EmailCheckBox.Checked = false;
            // output
            ResultListBox.Items.Clear();
            ClientComboBox.Items.Clear();

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
        
        string FormatName()
        {
            string _name = NameTextBox.Text;
            
            if (UpperRadioButton.Checked)
            {
                _name = _name.ToUpper();
            }
            else if(LowerRadioButton.Checked)
            {
                _name = _name.ToLower();
            }
            else
            {
                char[] chars = _name.ToCharArray();
                _name = "";
              for (int i = chars.GetUpperBound(0); i >= 0; i--)
              {
                _name += chars[i];
              }

            }

            if (FormatCheckBox.Checked)
            {
                return _name;
            }
            else
            {
                return NameTextBox.Text;
            }
        }

        int GetMaxHeartRate()
        {
            int maxHR = 0;
            
            // calculate max heart rate
            maxHR = 220 - int.Parse(AgeTextBox.Text);

            return maxHR;
        }

        string CreateEmail()
        {
            string _email = FormatName();
            _email = _email.Replace(" ", ".");
            _email = $"{_email}@acme.com";
            return _email;
        }

        void DisplayResult()
        {
            ClientComboBox.Items.Add(FormatName());
            ResultListBox.Items.Add(FormatName());
            ResultListBox.Items.Add($"Max Heart Rate: {GetMaxHeartRate()} bpm");
            if (EmailCheckBox.Checked)
            {
                ResultListBox.Items.Add(CreateEmail());
            }

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
            DisplayResult();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }
    }
}
