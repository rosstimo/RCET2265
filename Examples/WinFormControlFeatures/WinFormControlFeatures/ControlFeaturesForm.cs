using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;

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
            [x] Save and restore clients using a file
            [ ] File dialogue controls
        */

        List<string> clientData = new();
        string currentDBFilePath = "";

        public ControlFeaturesForm()
        {
            InitializeComponent();

            SelectClientDBFile();

            if (clientData.Count == 0)
            {
                clientData.Add("$$$$");
                this.currentDBFilePath = $"..\\..\\..\\clientDB_{DateTime.Now.ToString("yyMMdd")}.cdb";
            }

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
            string currentRecord = $"{NameTextBox.Text}$${AgeTextBox.Text}$${PhoneTextBox.Text}";
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
            UpdateClientDBFile();
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

        void SelectClientDBFile()
        {
            DialogResult choice = DialogResult.Cancel;
            //OpenFileDialog1.InitialDirectory = "c:\\";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "Client Data|*.cdb|Documents (*.pdf)|*.pdf|All files (*.*)|*.*";
            choice = OpenFileDialog1.ShowDialog();

            if (choice == DialogResult.OK)
            {
                //open file
                this.currentDBFilePath = OpenFileDialog1.FileName;
                OpenClientDBFile(OpenFileDialog1.FileName);

            }
            else
            {
                //MessageBox.Show("Cancel");
            }
        }
        void OpenClientDBFile(string FilePath)
        {
            using (StreamReader testFile = new StreamReader(FilePath))
            {

                   this.clientData.Clear();
                //stops when it reaches the end of file
                do
                {
                    // Console.WriteLine(testFile.ReadLine());
                    this.clientData.Add(testFile.ReadLine());
                } while (testFile.EndOfStream == false);

            }
            //MessageBox.Show(FilePath);
        }

        void UpdateClientDBFile()
        {
            // open/create a new file to write text
            // overwrites existing content!!
            using (StreamWriter dbFile = File.CreateText(this.currentDBFilePath))
            {
                foreach (string thing in this.clientData)
                {
                    dbFile.WriteLine(thing);
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

        private void OpenTopStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectClientDBFile();
            SetDefaults();

        }
    }
}
