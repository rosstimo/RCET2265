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
            components = new System.ComponentModel.Container();
            ButtonGroupBox = new GroupBox();
            DrawButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            DisplayPictureBox = new PictureBox();
            ContextMenuStrip = new ContextMenuStrip(components);
            DrawContextMenuItem = new ToolStripMenuItem();
            ColorContextMenuItem = new ToolStripMenuItem();
            BackGroundContextMenuItem = new ToolStripMenuItem();
            SizeContextMenuItem = new ToolStripMenuItem();
            ClearContextMenuItem = new ToolStripMenuItem();
            ExitContextMenuItem = new ToolStripMenuItem();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            EditTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            ColorPickerDialog = new ColorDialog();
            ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            ContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = Color.White;
            DisplayPictureBox.ContextMenuStrip = ContextMenuStrip;
            DisplayPictureBox.Location = new Point(12, 27);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(760, 293);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { DrawContextMenuItem, ColorContextMenuItem, BackGroundContextMenuItem, SizeContextMenuItem, ClearContextMenuItem, ExitContextMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(139, 136);
            // 
            // DrawContextMenuItem
            // 
            DrawContextMenuItem.Name = "DrawContextMenuItem";
            DrawContextMenuItem.Size = new Size(138, 22);
            DrawContextMenuItem.Text = "Draw";
            // 
            // ColorContextMenuItem
            // 
            ColorContextMenuItem.Name = "ColorContextMenuItem";
            ColorContextMenuItem.Size = new Size(138, 22);
            ColorContextMenuItem.Text = "Color";
            ColorContextMenuItem.Click += ColorContextMenuItem_Click;
            // 
            // BackGroundContextMenuItem
            // 
            BackGroundContextMenuItem.Name = "BackGroundContextMenuItem";
            BackGroundContextMenuItem.Size = new Size(138, 22);
            BackGroundContextMenuItem.Text = "Background";
            BackGroundContextMenuItem.Click += BackGroundContextMenuItem_Click;
            // 
            // SizeContextMenuItem
            // 
            SizeContextMenuItem.Name = "SizeContextMenuItem";
            SizeContextMenuItem.Size = new Size(138, 22);
            SizeContextMenuItem.Text = "Size";
            SizeContextMenuItem.Click += SizeContextMenuItem_Click;
            // 
            // ClearContextMenuItem
            // 
            ClearContextMenuItem.Name = "ClearContextMenuItem";
            ClearContextMenuItem.Size = new Size(138, 22);
            ClearContextMenuItem.Text = "Clear";
            // 
            // ExitContextMenuItem
            // 
            ExitContextMenuItem.Name = "ExitContextMenuItem";
            ExitContextMenuItem.Size = new Size(138, 22);
            ExitContextMenuItem.Text = "Exit";
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
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawMenuItem, ExitMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(37, 20);
            FileTopMenuItem.Text = "&File";
            // 
            // DrawMenuItem
            // 
            DrawMenuItem.Name = "DrawMenuItem";
            DrawMenuItem.Size = new Size(101, 22);
            DrawMenuItem.Text = "&Draw";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(101, 22);
            ExitMenuItem.Text = "E&xit";
            // 
            // EditTopMenuItem
            // 
            EditTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClearTopMenuItem });
            EditTopMenuItem.Name = "EditTopMenuItem";
            EditTopMenuItem.Size = new Size(39, 20);
            EditTopMenuItem.Text = "&Edit";
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(101, 22);
            ClearTopMenuItem.Text = "&Clear";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(44, 20);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(180, 22);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
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
            ContextMenuStrip.ResumeLayout(false);
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
        private ToolStripMenuItem DrawMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem DrawContextMenuItem;
        private ToolStripMenuItem ColorContextMenuItem;
        private ToolStripMenuItem BackGroundContextMenuItem;
        private ToolStripMenuItem SizeContextMenuItem;
        private ToolStripMenuItem ClearContextMenuItem;
        private ToolStripMenuItem ExitContextMenuItem;
        private ColorDialog ColorPickerDialog;
    }
}
