namespace WinFormsExample
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = FirstNameTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
