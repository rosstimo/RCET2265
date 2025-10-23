namespace WinFormEvenMoreControls
{
    public partial class MoreControlsForm : Form
    {
        public MoreControlsForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Text = "Clear";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = "Submit";
        }
    }
}
