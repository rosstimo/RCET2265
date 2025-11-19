
namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        int oldX;
        int oldY;
        Color foreGround = Color.Black;
        int penWidth = 1;
        SplashForm sf = new SplashForm();

        public GraphicsForm()
        {

            sf.Show();// Show the splash screen form
            //System.Threading.Thread.Sleep(3000); //fully qualified name
            Thread.Sleep(3000); //short name. 3 second blocking delay
            sf.Hide(); // hide the splash screen form after delay

            InitializeComponent();

            UpdateStatusLabel();




        }
        // Program logic  -------------------------------------------------------------
        void DrawLine()
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Black, 3);

            g.DrawLine(thePen, 0, 100, 200, 100);

            g.Dispose();
            thePen.Dispose();
        }

        void DrawEllipse()
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Red, 3);

            g.DrawEllipse(thePen, 100, 100, 250, 250);

            g.Dispose();
            thePen.Dispose();
        }
        void DrawRectangle()
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Lime, 3);

            g.DrawRectangle(thePen, 100, 100, 250, 250);

            g.Dispose();
            thePen.Dispose();
        }

        void DrawPie()
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Blue, 3);
            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(100, 100, 250, 250);

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            // Draw pie to screen.
            g.DrawPie(thePen, rect, startAngle, sweepAngle);

            g.Dispose();
            thePen.Dispose();
        }

        void DrawText()
        {
            Graphics g = this.CreateGraphics();
            //Pen thePen = new Pen(Color.Cyan, 3);

            // Create string to draw.
            String drawString = "Sample Text";

            // Create font and brush.
            Font drawFont = new Font("Arial", 24);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(drawString, drawFont, drawBrush, 100, 100);

            g.Dispose();
            drawBrush.Dispose();
        }

        void MouseDraw(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(this.foreGround, this.penWidth);

            //if (oldX == 0 && oldY == 0)
            //{
            //    this.oldX = x;
            //    this.oldY = y;
            //}

            g.DrawLine(thePen, this.oldX, this.oldY, x, y);
            //this.oldX = x;
            //this.oldY = y;

            g.Dispose();
            thePen.Dispose();
        }

        void ChooseColor()
        {
            colorDialog1.ShowDialog();
            this.foreGround = colorDialog1.Color;
            UpdateStatusLabel();
        }

        void UpdateStatusLabel()
        {
            StatusLabel.Text = $"Color: {this.foreGround.Name} Width: {this.penWidth}";

        }



        // Event handlers -------------------------------------------------------------
        private void GraphicsForm_Load(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawEllipse();
            DrawRectangle();
            DrawPie();
            DrawText();
        }

        private void GraphicsForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"({e.X.ToString()},{e.Y.ToString()} Button: {e.Button})";

            if (e.Button == MouseButtons.Left)
            {
                MouseDraw(e.X, e.Y);
            }
            this.oldX = e.X;
            this.oldY = e.Y;
            if (e.Button == MouseButtons.Middle)
            {
                ChooseColor();
            }

        }

        private void GraphicsForm_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Text = e.Delta.ToString();

            if (this.penWidth > 1 && e.Delta < 0)
            {
                --this.penWidth;
            }
            else if (e.Delta > 0)
            {
                ++this.penWidth;
            }
            else
            {
                //pass
            }
            UpdateStatusLabel();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AboutForm ab = new AboutForm(); 
            ab.Show();
        }
    }
}
