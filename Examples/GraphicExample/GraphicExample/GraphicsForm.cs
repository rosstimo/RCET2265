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
        
        //text

        //image





        //Event Handlers --------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
        }
    }
}
