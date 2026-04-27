using System.Data.Common;

namespace WinFormsExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            CityRadioButton.CheckedChanged += CityRadioButton_CheckedChanged;
            LastNameRadioButton.CheckedChanged += CityRadioButton_CheckedChanged;
            FirstNameRadioButton.CheckedChanged += CityRadioButton_CheckedChanged;
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;

            SetDefaults();
        }



        string[,] customerData = new string[0,0] ; // persistent customer data
        private void SetDefaults()
        {
            NameTextBox.Text = "";
            NameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";
            //DisplayLabel.Text = "";

            UpperCaseRadioButton.Checked = true;
            CityRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SubmitTopMenuItem.Enabled = false;
        }

        private bool ValidateFields()
        {
            bool valid = true;
            string message = "";
            if (CityTextBox.Text == "")
            {
                message = "City is required\n" + message;
                CityTextBox.Focus();
            }
            if (PhoneTextBox.Text == "")
            {
                message = "Phone is required\n" + message;
                PhoneTextBox.Focus();
            }
            if (AgeTextBox.Text == "")
            {
                message = "Age is required\n" + message;
                AgeTextBox.Focus();
            }
            if (NameTextBox.Text == "")
            {
                message = "Name is required\n" + message;
                NameTextBox.Focus();
            }
            if (message != "")
            {
                valid = false;
                MessageBox.Show(message);
            }
            return valid;
        }
        private string LowerCase(string toLower)
        {
            if (LowerRadioButton.Checked)
            {
                return toLower.ToLower();
            }
            else
            {
                return toLower;
            }
        }
        private string UpperCase(string toUpper)
        {
            if (UpperCaseRadioButton.Checked)
            {
                return toUpper.ToUpper();
            }
            else
            {
                return toUpper;
            }
        }
        private string Reverse(string reverseThis)
        {
            if (ReverseRadioButton.Checked)
            {
                return new string(reverseThis.Reverse().ToArray());
            }
            else
            {
                return reverseThis;
            }
        }


        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");
                        _customerData[0, counter] = temp[0];
                        _customerData[1, counter] = temp[1];
                        _customerData[2, counter] = temp[2];
                        _customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            this.customerData = _customerData;
        }

        void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when CityRadioButton.Checked:
                    filterColumn = 2;
                    break;
                case bool when LastNameRadioButton.Checked:
                    filterColumn = 1;
                    break;
                case bool when FirstNameRadioButton.Checked:
                    filterColumn = 0;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() || FilterComboBox.SelectedIndex == 0) )
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
                }
                if (formattedRow != "")
                {
                    DisplayListBox.Items.Add(formattedRow);
                }
                formattedRow = "";
            }
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            FilterComboBox.Items.Clear();

            switch (true)
            {
                case bool when CityRadioButton.Checked:
                    column = 2;
                    break;
                case bool when LastNameRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FirstNameRadioButton.Checked:
                    column = 0;
                    break;
                //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column,row] != null && FilterComboBox.Items.Contains(this.customerData[column, row]) != true)
                {
                   
                    FilterComboBox.Items.Add(this.customerData[column, row]); //add city 
                }
            }
            FilterComboBox.Items.Add("~Select~");
            FilterComboBox.Sorted = true;
            FilterComboBox.SelectedIndex = 0;

        }

        // Event Handlers Below -----------------------------------------------
        private void CityRadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            DisplayData();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //this.Text = NameTextBox.Text;
                //UpperCase();
                //Reverse();
                //DisplayLabel.Text = Reverse(UpperCase(LowerCase(NameTextBox.Text + "\n" +
                //    AgeTextBox.Text + "\n" +
                //    PhoneTextBox.Text + "\n" +
                //    CityTextBox.Text)));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                NameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }
        }
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                AgeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }
        }

        private void AboutTopMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No help available");
        }

        private void UpperContextMenuItem_Click(object sender, EventArgs e)
        {
            UpperCaseRadioButton.Checked = true;
        }

        private void LowerContextMenuItem_Click(object sender, EventArgs e)
        {
            LowerRadioButton.Checked = true;
        }

        private void ReverseContextMenuItem_Click(object sender, EventArgs e)
        {
            ReverseRadioButton.Checked = true;
        }

        private void OpenTopMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string[,] fileData;
            MainOpenFileDialog.FileName = "";
            MainOpenFileDialog.Filter = "txt files (*.txt)|*.txt|wav files (*.wav)|*.wav|All files (*.*)|*.*";
            // if the user hits ok open the file and display file contents
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = MainOpenFileDialog.FileName;
                FileToArray(filePath);
                LoadFilterComboBox();
                //DisplayData();

            }

        }
    }
}
