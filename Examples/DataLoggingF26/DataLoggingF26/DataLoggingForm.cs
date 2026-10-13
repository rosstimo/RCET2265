namespace DataLoggingF26
{
    public partial class DataLoggingForm : Form
    {
        public DataLoggingForm()
        {
            InitializeComponent();
        }

        Queue<int> buffer = new Queue<int>();

        int lastX, lastY;
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
            g.DrawLine(myPen, lastX, lastY, x, y);
            lastX = x;
            lastY = y;

            //free up resources
            g.Dispose();
            myPen.Dispose();
        }

        void DrawBuffer()
        {
            //DisplayPictureBox.Refresh(); Too slow. flicker
            lastX = 0;
            lastY = 0;
            for (int point = 0; point < buffer.Count; point++)
            {
                DrawLine(point, buffer.ElementAt(point));
            }
        }

        int GetFakeData()
        {
            Random randy = new Random();
            return randy.Next(1024);
        }

        void GetDataSample()
        {
            if (buffer.Count >= 100)
            {
                buffer.Dequeue();
            }
            buffer.Enqueue(GetFakeData());
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
            //DrawLine(90,512);

            if (SampleTimer.Enabled)
            {
                SampleTimer.Enabled = false;
            }
            else
            {
                SampleTimer.Enabled= true;
            }
        }

        private void SampleTimer_Tick(object sender, EventArgs e)
        {
            GetDataSample();
            DrawBuffer();
        }
    }
}
