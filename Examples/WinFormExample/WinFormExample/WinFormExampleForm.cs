namespace WinFormExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
            EvaluateFields();
            UpdateCurrentFile();
            customerRecords = new string[CountLinesIn(currentFile), 4];
            FilePathStatusLabel.Text = currentFile;
            ReadWholeFile();
            DisplayCustomerRecords();
        }
        // global/class level variables ***************************************
        static string userMessage = "";
        static string currentFile = "none";

        static string[,] customerRecords; //= new string[0];




        // helper methods *****************************************************
        void SetDefaults()
        {
            InfoTextBox.Text = "";
            NameTextBox.Text = "";
            AgeTextBox.Text = "";

            DefaultRadioButton.Checked = true;
            UpperCaseRadioButton.Checked = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            InfoTextBox.Select();

        }

        bool EvaluateFields()
        {
            bool valid = true;

            try
            {
                int.Parse(AgeTextBox.Text);
                AgeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                //AgeTextBox.Select();
                AgeTextBox.BackColor = Color.LightYellow;
                userMessage += "Age must be a whole number\n";
            }

            if (NameTextBox.Text == "")
            {
                valid = false;
                //NameTextBox.Select();
                NameTextBox.BackColor = Color.LightYellow;
                userMessage += "Name is required\n";
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            if (InfoTextBox.Text == "")
            {
                valid = false;
                //InfoTextBox.Select();
                InfoTextBox.BackColor = Color.LightYellow;
                userMessage += "Info is required\n";
            }
            else
            {
                InfoTextBox.BackColor = Color.White;
            }
            SubmitButton.Enabled = valid;
            return valid;
        }

        void WriteToFile()
        {
            using (StreamWriter writer = File.CreateText("testFile.txt"))
            {
                writer.WriteLine("wake up neo...");
            }
        }

        void AppendToFile()
        {
            using (StreamWriter writer = File.AppendText("..\\..\\..\\testFile.txt"))
            {
                writer.WriteLine("follow the white rabbit...");
            }
        }

        void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader("testFile.txt"))
            {
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
                ResultListBox.Items.Add(reader.ReadLine());
            }
        }

        void ReadWholeFile()
        {
            int index = 0;
            string[] temp;
            try
            {
                using (StreamReader reader = new StreamReader(currentFile))
                {
                    while (!reader.EndOfStream)
                    {
                        //ResultListBox.Items.Add(reader.ReadLine());
                        temp = reader.ReadLine().Split(',');
                        if (temp.Length == 5)
                        {
                            temp[0] = temp[0].Replace("\"$$", ""); //clean first name text
                            customerRecords[index, 0] = temp[0];
                            customerRecords[index, 1] = temp[1];
                            customerRecords[index, 2] = temp[2];
                            temp[3] = temp[3].Replace("\"", ""); //clean email text
                            customerRecords[index, 3] = temp[3];
                            index++;
                        }

                    }
                }
                this.Text = index.ToString();
            }
            catch (System.IO.FileNotFoundException e)
            {
                //MessageBox.Show("oops!");
                UpdateCurrentFile();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }
        int CountLinesIn(string path)
        {
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        ++count;
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                UpdateCurrentFile();
            }
            catch (Exception e)
            {
                //pass
                MessageBox.Show(e.Message, "Error");
            }
            return count;
        }
        void UpdateCurrentFile()
        {
            //OpenCurrentFileDialog.InitialDirectory = "c:\\"; force directory
            OpenCurrentFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|C# Files (*.cs)|*.cs"; ;
            OpenCurrentFileDialog.FilterIndex = 1;
            OpenCurrentFileDialog.FileName = "";
            OpenCurrentFileDialog.ShowDialog();
            currentFile = OpenCurrentFileDialog.FileName;
            FilePathStatusLabel.Text = currentFile;
            //OpenCurrentFileDialog.RestoreDirectory = false; does not seem to do anything - TJR
        }

        void DisplayCustomerRecords()
        {
            try
            {
                for (int i = 0; i < customerRecords.GetUpperBound(0); i++)
                {
                    ResultListBox.Items.Add($"{customerRecords[i, 1]}, {customerRecords[i, 0]}");
                }
            }
            //catch (System.ArgumentNullException)
            //{
            //    // pass if customer record is null
            //}
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }
        // Event handlers below here ******************************************
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
            if (EvaluateFields())
            {
                string prettyText = "";
                prettyText = $"{InfoTextBox.Text}, {NameTextBox.Text}, {AgeTextBox.Text}";
                ResultListBox.Items.Add(prettyText);
            }
            else
            {
                MessageBox.Show(userMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userMessage = "";
            }
            //WriteToFile();

            //AppendToFile();

            //ReadFromFile();

            ReadWholeFile();

            //MessageBox.Show(CountLinesIn("testFile.txt").ToString());
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateFields();
        }

        private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = ResultListBox.SelectedIndex.ToString();
            InfoTextBox.Text = customerRecords[ResultListBox.SelectedIndex, 2];
            NameTextBox.Text = $"{customerRecords[ResultListBox.SelectedIndex, 0]} {customerRecords[ResultListBox.SelectedIndex, 1]}";
        }
    }
}
