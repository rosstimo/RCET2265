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
            ButtonGroupBox = new GroupBox();
            DrawButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            DisplayPictureBox = new PictureBox();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            drawToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            EditTopMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(DrawButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Location = new Point(510, 326);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(262, 83);
            ButtonGroupBox.TabIndex = 3;
            ButtonGroupBox.TabStop = false;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(6, 22);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(79, 52);
            DrawButton.TabIndex = 0;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(176, 22);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(79, 52);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(91, 22);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(79, 52);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = Color.White;
            DisplayPictureBox.Location = new Point(12, 27);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(760, 293);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, EditTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(784, 24);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drawToolStripMenuItem, exitToolStripMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(37, 20);
            FileTopMenuItem.Text = "&File";
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(101, 22);
            drawToolStripMenuItem.Text = "&Draw";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(101, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // EditTopMenuItem
            // 
            EditTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            EditTopMenuItem.Name = "EditTopMenuItem";
            EditTopMenuItem.Size = new Size(39, 20);
            EditTopMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(101, 22);
            clearToolStripMenuItem.Text = "&Clear";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(44, 20);
            HelpTopMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "GraphicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grapics";
            ButtonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ButtonGroupBox;
        private Button DrawButton;
        private Button ExitButton;
        private Button ClearButton;
        private PictureBox DisplayPictureBox;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem EditTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
