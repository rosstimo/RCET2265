namespace GraphicExample
{
    partial class GraphicsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.Location = new Point(20, 60);
            DisplayPictureBox.Margin = new Padding(5, 6, 5, 6);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(971, 350);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 496);
            Controls.Add(DisplayPictureBox);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(400, 400);
            Name = "GraphicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DisplayPictureBox;
    }
}
