namespace DataLoggingF26
{
    partial class DataLoggingForm
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
            ClearButton = new Button();
            ExitButton = new Button();
            ButtonGroupBox = new GroupBox();
            DisplayPictureBox = new PictureBox();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            BottomStatusStrip = new StatusStrip();
            ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(9, 22);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(75, 55);
            DrawButton.TabIndex = 0;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(90, 22);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 55);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(171, 22);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 55);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&it";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(DrawButton);
            ButtonGroupBox.Location = new Point(517, 225);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(260, 94);
            ButtonGroupBox.TabIndex = 3;
            ButtonGroupBox.TabStop = false;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = Color.Black;
            DisplayPictureBox.Location = new Point(12, 27);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(765, 192);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(786, 24);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(37, 20);
            FileTopMenuItem.Text = "&File";
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.Location = new Point(0, 325);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Size = new Size(786, 22);
            BottomStatusStrip.TabIndex = 6;
            BottomStatusStrip.Text = "statusStrip1";
            // 
            // DataLoggingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 347);
            Controls.Add(BottomStatusStrip);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "DataLoggingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datta Logging";
            ButtonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DrawButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox ButtonGroupBox;
        private PictureBox DisplayPictureBox;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private StatusStrip BottomStatusStrip;
    }
}
