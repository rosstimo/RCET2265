namespace WinFormExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
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
            }
            catch (Exception)
            {
                valid = false;
                AgeTextBox.Select();
                userMessage += "Age must be a whole number\n";
            }

            if (NameTextBox.Text == "")
            {
                valid = false;
                NameTextBox.Select();
                userMessage += "Name is required\n";
            }

            if (InfoTextBox.Text == "")
            {
                valid = false;
                InfoTextBox.Select();
                userMessage +="Info is required\n";
            }

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
                MessageBox.Show(userMessage,"Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                userMessage = "";
            }
        }
    }
}
