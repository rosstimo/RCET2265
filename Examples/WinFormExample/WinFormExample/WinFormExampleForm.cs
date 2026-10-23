namespace WinFormExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
            EvaluateFields();
        }

        static string userMessage = "";

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
            try
            {
                using (StreamReader reader = new StreamReader("..\\..\\..\\email.txt"))
                {
                    while ( !reader.EndOfStream )
                    {
                        ResultListBox.Items.Add(reader.ReadLine());
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("oops!");
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
            catch (Exception e)
            {
                //pass
            }
            return count;
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

            //ReadWholeFile();

            MessageBox.Show(CountLinesIn("testFile.txt").ToString());
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
    }
}
