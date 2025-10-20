namespace WinFormsControls
{
    public partial class ControlsForm : Form
    {
        public ControlsForm()
        {
            InitializeComponent();
            SetDefaults(); // set defaults when form loads
        }

        //Program Logic -------------------------------------------------------

        void SetDefaults()
        {
            radioButton1.Checked = true;
            radioButton6.Checked = true;
            radioButton9.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        //Event Handlers ------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

    }
}
