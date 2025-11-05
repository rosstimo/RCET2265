using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.Diagnostics.Eventing.Reader;

namespace WinFormControlFeatures
{
    public partial class ControlFeaturesForm : Form
    {
        /*TODO
            [x] Save client info in a data structure. (array, list, etc)
            [x] Use combobox to select existing client record
            [x] Use list box to display single client record
            [x] When selected populate text fields and listbox with client details
            [x] Submit will update client record or create it if it doesn't exist
            [x] May need a unique id number for each client to avoid duplicates
            [ ] Save and restore clients using a file
            [ ] File dialogue controls
        */

        List<string> clientData = new();

        public ControlFeaturesForm()
        {
            InitializeComponent();

            clientData.Add("$$$$");
            SetDefaults(); // after initialize
        }

        // Program Logic ------------------------------------------------------
        void SetDefaults()
        {
            // output
            UpdateClientComboBox();
            if (ClientComboBox.Items.Count > 0)
            {
                ClientComboBox.SelectedIndex = 0;
            }
            // information fields
            NameTextBox.Text = "";
            NameTextBox.Focus();
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            //options
            UpperRadioButton.Checked = true;
            FormatCheckBox.Checked = false;
            EmailCheckBox.Checked = false;

            ResultListBox.Items.Clear();

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
                if (_age <= 0 || _age >= 50)
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
            else if (LowerRadioButton.Checked)
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

        void UpdateClientData()
        {
            string currentRecord =$"{NameTextBox.Text}$${AgeTextBox.Text}$${PhoneTextBox.Text}";
            if (!this.clientData.Contains(currentRecord)) 
            {

                if (ClientComboBox.SelectedIndex >= 1)
                {
                    this.clientData.RemoveAt(ClientComboBox.SelectedIndex);
                    this.clientData.Insert(ClientComboBox.SelectedIndex, currentRecord);
                }
                else
                {
                    this.clientData.Add(currentRecord); // only if combobox selection is 0
                }


            }
            UpdateClientComboBox();
        }

        void UpdateClientComboBox()
        {
            string[] temp;
            ClientComboBox.Items.Clear();

            // make combobox content match content of clientData List
            // add names only
            foreach (string thing in this.clientData)
            {
                temp = thing.Split("$$");
                if (temp[0] == "")
                {
                    ClientComboBox.Items.Add("New");
                }
                else
                {
                    ClientComboBox.Items.Add(temp[0]);
                }
            }
            ClientComboBox.SelectedIndex = 0;
            DisplayResult();
        }

        void DisplayResult()
        {
            if (ValidateInputFields())
            {
                ResultListBox.Items.Clear();
                ResultListBox.Items.Add(FormatName());
                ResultListBox.Items.Add($"Max Heart Rate: {GetMaxHeartRate()} bpm");
                if (EmailCheckBox.Checked)
                {
                    ResultListBox.Items.Add(CreateEmail());
                }
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
            //DisplayResult();
            UpdateClientData();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp;
            this.Text = ClientComboBox.SelectedIndex.ToString();
            //get the value from this.clientData at index pointed to by combobox selection
            //ResultListBox.Items.Add(this.clientData[ClientComboBox.SelectedIndex]);
            temp = this.clientData[ClientComboBox.SelectedIndex].Split("$$");
            NameTextBox.Text = temp[0];
            AgeTextBox.Text = temp[1];
            PhoneTextBox.Text = temp[2];
            ResultListBox.Items.Clear(); // make sure list box is clear when "New" is selected
            DisplayResult();
           




        }
    }
}
