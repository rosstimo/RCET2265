using System.Drawing;
namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;
            ClearTopMenuItem.Click += Clear_Click;
            ClearContextMenuItem.Click += Clear_Click;


        }

        private Color PenColor = Color.Black;
        private Color backGround = Color.White;
        private int penSize = 1;
        private int oldX, oldY;

        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Width = this.penSize;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }

        void DrawLine()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }

        void DrawEllipse()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 5;

            g.DrawEllipse(thePen, 0, 0, 100, 100);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }

        //rectangle
        void DrawRectangle()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Red);

            g.DrawRectangle(thePen, 100, 100, 200, 200);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawPie()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Yellow);
            SolidBrush theBrush = new SolidBrush(Color.Violet);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            // g.DrawPie(thePen, bounds, 0, 45);
            g.FillPie(theBrush, bounds, 0, 120);
            theBrush.Color = Color.Blue;
            g.FillPie(theBrush, bounds, 120, 120);
            theBrush.Color = Color.Yellow;
            g.FillPie(theBrush, bounds, 240, 120);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }


        //text
        void DrawText()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            SolidBrush theBrush = new SolidBrush(Color.Black);
            Font theFont = new Font("Arial", 12);
            Rectangle bounds = new Rectangle(300, 100, 200, 200);

            //g.DrawString("Hello!",theFont, theBrush, 0, DisplayPictureBox.Height / 2);
            g.DrawString("Hello!, Ladies and gentleman of the ages!!! This is a long line of text...", theFont, theBrush, bounds);

            //free up resources
            g.Dispose();
            theBrush.Dispose();
            theFont.Dispose();
        }

        //image
        void DrawImage()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // Create image.
            Image theImage = Image.FromFile("..\\..\\..\\grumpy_cat.png");
            Rectangle bounds = new Rectangle(10, 10, theImage.Width / 2, theImage.Height / 2);
            //g.DrawImage(theImage, 10,10 ); //Draw full size 
            g.DrawImage(theImage, bounds); //Fills rectangle
            //free up resources
            g.Dispose();
            theImage.Dispose();
        }

        
        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.PenColor = PenColorDialog.Color;

        }

        void DrawSinWave()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Blue);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360F;
            float scaleY = (DisplayPictureBox.Height / 200F) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);

            for (int currentX = 0; currentX < 360; currentX++)
            {
                //TODO convert degrees to radians
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            DisplayPictureBox.Refresh();
            Color oldColor = this.PenColor;
            this.PenColor = Color.Gray;
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }
            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
            this.PenColor = oldColor;
        }

        //Event Handlers --------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawLine();
            //DrawEllipse();
            //DrawRectangle();
            //DrawPie();
            //DrawText();
            //DrawImage();
            DrawGrid();
            DrawSinWave();
        }
        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y}) {e.Button}";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            //update last position on every move
            this.oldX = e.X;
            this.oldY = e.Y;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           DisplayPictureBox.Refresh();
        }
    }
}
//TODO
//[x] add clear button
//[x] anchor buttons
//[ ] change background color
//[x] add top menu
//[x] add context menu
//[ ] change pen size
//[ ] display coords, color(s), size in status strip
