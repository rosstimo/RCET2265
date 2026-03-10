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



        //Event handlers below here -------------------------------------------


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExampleMethod();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
