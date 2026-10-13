namespace DataLoggingF26
{
    public partial class DataLoggingForm : Form
    {
        public DataLoggingForm()
        {
            InitializeComponent();
        }
        
        void DrawLine(int x, int y)
        {
            // constructor for graphics objet that draws on picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //constructor for pen
            Pen myPen = new Pen(Color.Lime);
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(sx, -sy); // update scale and flip y +/- direction
            g.TranslateTransform(0, -1023); //move origin down to bottom left
            g.DrawLine(myPen, 0, 0, x, y);

            //free up resources
            g.Dispose();
            myPen.Dispose();
        }




        // Event handlers below here ******************************************
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine(90,512);
        }
    }
}
