namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseMove;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseMove;
            DrawContextMenuItem.Click += DrawButton_Click;
            ClearContextMenuItem.Click += ClearButton_Click;
            ExitContextMenuItem.Click += ExitButton_Click;
            ShowSplashForm();
        }


        private int penSize = 1;
        private Color penColor = Color.Black, backgroundColor = Color.White;

        int lastX, lastY;
        void DrawLine(int x, int y)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen myPen = new Pen(penColor, penSize);
            g.DrawLine(myPen, lastX, lastY, x, y);


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

            g.DrawEllipse(myPen, 100, 100, 200, 200);

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

        void ShowSplashForm()
        {
            //instantiate a new instance of an AboutForm
            SplashForm splash = new SplashForm();

            //hide main form
            this.Hide();
            //show about and wait here
            splash.ShowDialog();
            //show main form again when about form closes
            this.Show();
        }

        // Event handlers below here ******************************************
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawLine();
            DrawRectangle();
            DrawEllipse();
            DrawString();
            ShowSplashForm();
        }
        private void DisplayPictureBox_MouseMove(object? sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y}) Button: {e.Button}";
            if (e.Button == MouseButtons.Left)
            {
                DrawLine(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                ColorPickerDialog.ShowDialog();
                penColor = ColorPickerDialog.Color;
            }
            lastX = e.X;
            lastY = e.Y;
        }

        private void ColorContextMenuItem_Click(object sender, EventArgs e)
        {
            //change pen color in dialogue
            ColorPickerDialog.ShowDialog();
            penColor = ColorPickerDialog.Color;
        }

        private void BackGroundContextMenuItem_Click(object sender, EventArgs e)
        {
            //change background color in dialogue
        }

        private void SizeContextMenuItem_Click(object sender, EventArgs e)
        {
            //change pen size in dialogue
        }

        private void AboutTopMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate a new instance of an AboutForm
            AboutForm about = new AboutForm();

            //hide main form
            this.Hide();
            //show about and wait here
            about.ShowDialog();
            //show main form again when about form closes
            this.Show();
        }

    }
}
