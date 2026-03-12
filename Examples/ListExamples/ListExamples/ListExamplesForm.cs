namespace ListExamples
{
    public partial class ListExamplesForm : Form
    {
        public ListExamplesForm()
        {
            InitializeComponent();
        }
        //Custom Methods below here -------------------------------------------
        void ListExampleMethod()
        {
            List<string> names = new List<string>();
            names.Add("Sheila");
            names.Add("Bob");
            names.Add("Alex");
            //Console.WriteLine(names.Count); // 2
            this.Text = names.Count.ToString();
            names.Remove("Bob");
            this.Text = names.Count.ToString();
        }
        /*TODO
        [ ] Set defaults method. call on startup and Clear Button
            [ ] clear text boxes
            [ ] set focus to first name
            [ ] select index 0 of the combo box
        [ ] validate text boxes. blank light yellow, not blank white as you type
        [ ] submit button disabled unless all text boxes are valid. try a single validate method
        [ ] clear the text boxes on submit.
        [ ] Edit and/or remove selected item
        [ ] Optional: populate at least three list entries for testing
        */
        void LoadTestData()
        {
            DisplayListBox.Items.Add("Fudd,Elmer Acme");
            DisplayListBox.Items.Add("Blow,Joe Bazooka");
            DisplayListBox.Items.Add("Jane,Mary LastDanceStudio");
        }
        void SetDefaults()
        {
            //clear all text boxes
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";
            //set initial back color
            FirstNameTextBox.BackColor = Color.LightYellow;
            LastNameTextBox.BackColor = Color.LightYellow;
            CompanyTextBox.BackColor = Color.LightYellow;
            
            // reset combo box and list box selections
            if (SelectionComboBox.Items.Count > 0 & DisplayListBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
                DisplayListBox.SelectedIndex = 0;
            }
        }
        bool ValidateFeilds()
        {
            return false;
        }
        void AddItemToListBox()
        {
            DisplayListBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");
        }

        void AddItemToComboBox()
        {
            SelectionComboBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text}");
            if (SelectionComboBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
            }
        }



        //Event handlers below here -------------------------------------------


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ListExampleMethod();
            AddItemToListBox();
            AddItemToComboBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //isolate company
            string[] temp = DisplayListBox.SelectedItem.ToString().Split(" ");
            CompanyTextBox.Text = temp[1];
            //isolate lastName, firstName
            temp = temp[0].Split(",");
            FirstNameTextBox.Text = temp[1];
            LastNameTextBox.Text = temp[0];
        }

        private void SelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select the corosponding entry in the list box
            DisplayListBox.SelectedIndex = SelectionComboBox.SelectedIndex;
        }
    }
}
