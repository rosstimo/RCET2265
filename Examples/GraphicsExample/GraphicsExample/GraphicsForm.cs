namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseMove;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseMove;
        }


        void DrawLine()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            g.DrawLine(myPen, 0, 0, 100, 100);

            g.Dispose();
            myPen.Dispose();
        }

        void DrawRectangle()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Red);

            g.DrawRectangle(myPen, 100, 100, 200, 200);

            g.Dispose();
            myPen.Dispose();
        }

        void DrawEllipse()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Blue);

            g.DrawEllipse(myPen,100,100, 200, 200);

            g.Dispose();
            myPen.Dispose();
        }

        void DrawString()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Brush brush = new SolidBrush(Color.Black);
            Font theFont = new Font(FontFamily.GenericMonospace, 24);

            g.DrawString("Hello", theFont, brush, 100, 100);

            g.Dispose();
            brush.Dispose();
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
            DrawLine();
            DrawRectangle();
            DrawEllipse();
            DrawString(); 
        }
        private void DisplayPictureBox_MouseMove(object? sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y}) Button: {e.Button}";
        }
    }
}
