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
            DrawVerticalLine(x);
            g.DrawLine(myPen, lastX, lastY, x, y);
            lastX = x;
            lastY = y;

            //free up resources
            g.Dispose();
            myPen.Dispose();
        }

        void DrawBufferSample (int index, Color color)
        {
            // constructor for graphics objet that draws on picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //constructor for pen
            Pen myPen = new Pen(color);
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(sx, -sy); // update scale and flip y +/- direction
            g.TranslateTransform(0, -1023); //move origin down to bottom left
            myPen.Color = Color.Red;
            g.DrawLine(myPen, index - 1, buffer.ElementAt(index - 2), index, buffer.ElementAt(index - 1));
            myPen.Color = Color.Green;
            g.DrawLine(myPen, index, buffer.ElementAt(index - 1), index + 1, buffer.ElementAt(index));

            //free up resources
            g.Dispose();
            myPen.Dispose();
        }
        void DrawVerticalLine(int x)
        {
            // constructor for graphics objet that draws on picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //constructor for pen
            Brush myBrush = new SolidBrush(Color.Red);
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(sx, -sy); // update scale and flip y +/- direction
            g.TranslateTransform(0, -1023); //move origin down to bottom left
            g.FillRectangle(myBrush, lastX, 0, x, 1023);
            //free up resources
            g.Dispose();
            myBrush.Dispose();
        }
        void DrawBuffer()
        {
            //DisplayPictureBox.Refresh(); Too slow. flicker
            lastX = 0;
            lastY = 0;
            for (int point = 0; point < buffer.Count; point++)
            {
                //DrawLine(point, buffer.ElementAt(point));
                if (point > 1)
                {
                //    DrawBufferSample(point - 1, Color.Black);
                    DrawBufferSample(point, Color.Lime);
                }
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
