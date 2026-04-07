using System.Drawing;
namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }
        
        void DrawLine()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen,0,0,DisplayPictureBox.Width,DisplayPictureBox.Height);

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
            g.DrawString("Hello!, Ladies and gentleman of the ages!!! This is a long line of text...",theFont, theBrush, bounds);

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
            Rectangle bounds = new Rectangle(10, 10, theImage.Width/2, theImage.Height/2);
            //g.DrawImage(theImage, 10,10 ); //Draw full size 
            g.DrawImage(theImage, bounds); //Fills rectangle
            //free up resources
            g.Dispose();
            theImage.Dispose();
        }





        //Event Handlers --------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
            DrawRectangle();
            DrawPie();
            DrawText();
            DrawImage();
        }
    }
}
