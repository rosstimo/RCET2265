namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        int oldX;
        int oldY;

        public GraphicsForm()
        {
            InitializeComponent();
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
            Pen thePen = new Pen(Color.Black, 1);

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
        }
    }
}
