namespace WinFormExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

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
            string prettyText = "";
            prettyText = $"{InfoTextBox.Text}, {NameTextBox.Text}, {AgeTextBox.Text}";
            ResultListBox.Items.Add(prettyText);
        }
    }
}
