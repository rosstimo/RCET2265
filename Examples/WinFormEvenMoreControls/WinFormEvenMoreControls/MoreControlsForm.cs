namespace WinFormEvenMoreControls
{
    public partial class MoreControlsForm : Form
    {
        public MoreControlsForm()
        {
            InitializeComponent();
        }

        //Program Logic -------------------------------------------------------

        string BuildString()
        {
            string message = "";

            for (int i = 0; i<=10; i++)
            {
                message += "test";
            }
            return message;
        }

        int RandomNumberInRange(int min = 0, int max = 10)
        {
            Random randomNumberInator = new Random();

            return randomNumberInator.Next(min, max + 1);

        }
        void TestRandom()
        {
            int[] count = new int[11];
            string line = "";

            for (int i = 0;i<=10000;i++)
            {
                count[RandomNumberInRange()] += 1;
            }
            
            foreach (int thingy in count)
            {
               line += thingy + " | ";
            }

            DisplayListBox.Items.Add(line);

        }


        int NumberAround(int myNumber)
        {
            RandomNumberInRange();
            return 10;
        }


        //Event Handlers ------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //DisplayListBox.Items.Add(BuildString());
           TestRandom();
        }
    }
}
