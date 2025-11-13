namespace GraphicsExample
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
            DrawButton = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(657, 367);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(131, 71);
            DrawButton.TabIndex = 0;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DrawButton);
            Name = "GraphicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += GraphicsForm_Load;
            MouseMove += GraphicsForm_MouseMove;
            MouseDown += GraphicsForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Button DrawButton;
        private ColorDialog colorDialog1;
    }
}
