using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WinFormsExample
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }
        // Program Logic ------------------------------------------------------

        void DisplayContent()
        {
            if (EvaluateFields() != "") // no news is good news
            {
                MessageBox.Show(EvaluateFields());
            }
            else
            {
                DisplayLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\nAge: {AgeTextBox.Text}\nPhone: {PhoneTextBox.Text}";
            }
        }

        string EvaluateFields()
        {
            string message = "";

            //test in reverse order for correct focus in tab order
            // Use distinct if statements to ensure all fields are checked
            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Focus();
                message += "Phone Number is Required\n";
            }

            // verifies if field is not empty and is a number
            try
            {
                int.Parse(AgeTextBox.Text);
            }
            catch (Exception)
            {
                AgeTextBox.Focus();
                message += "Valid Age is Required\n";
            }

            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Focus();
                message += "Last Name is Required\n";
            }

            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.Focus();
                message += "First Name is Required";
            }

            return message;

        }

        // Event Handlers -----------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DisplayContent();
        }
    }
}
