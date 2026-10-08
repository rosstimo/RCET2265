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
