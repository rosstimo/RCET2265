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
            components = new System.ComponentModel.Container();
            DisplayPictureBox = new PictureBox();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            drawContextMenuItem = new ToolStripMenuItem();
            ClearContextMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            PenContextMenuItem = new ToolStripMenuItem();
            BackGroundContextMenuItem = new ToolStripMenuItem();
            PenSizeContextMenuItem = new ToolStripMenuItem();
            PenSizeComboBox = new ToolStripComboBox();
            DrawButton = new Button();
            ExitButton = new Button();
            PenColorDialog = new ColorDialog();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            CLearButton = new Button();
            BottomStatusStrip = new StatusStrip();
            DrawingStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            BottomStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.ContextMenuStrip = DisplayContextMenuStrip;
            DisplayPictureBox.Location = new Point(20, 48);
            DisplayPictureBox.Margin = new Padding(5);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(971, 296);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(28, 28);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { drawContextMenuItem, ClearContextMenuItem, colorToolStripMenuItem, PenSizeContextMenuItem });
            DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            DisplayContextMenuStrip.Size = new Size(164, 148);
            // 
            // drawContextMenuItem
            // 
            drawContextMenuItem.Name = "drawContextMenuItem";
            drawContextMenuItem.Size = new Size(163, 36);
            drawContextMenuItem.Text = "Draw";
            // 
            // ClearContextMenuItem
            // 
            ClearContextMenuItem.Name = "ClearContextMenuItem";
            ClearContextMenuItem.Size = new Size(163, 36);
            ClearContextMenuItem.Text = "Clear";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenContextMenuItem, BackGroundContextMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(163, 36);
            colorToolStripMenuItem.Text = "Color";
            // 
            // PenContextMenuItem
            // 
            PenContextMenuItem.Name = "PenContextMenuItem";
            PenContextMenuItem.Size = new Size(243, 40);
            PenContextMenuItem.Text = "Pen";
            // 
            // BackGroundContextMenuItem
            // 
            BackGroundContextMenuItem.Name = "BackGroundContextMenuItem";
            BackGroundContextMenuItem.Size = new Size(243, 40);
            BackGroundContextMenuItem.Text = "BackGround";
            // 
            // PenSizeContextMenuItem
            // 
            PenSizeContextMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenSizeComboBox });
            PenSizeContextMenuItem.Name = "PenSizeContextMenuItem";
            PenSizeContextMenuItem.Size = new Size(163, 36);
            PenSizeContextMenuItem.Text = "Pen Size";
            // 
            // PenSizeComboBox
            // 
            PenSizeComboBox.Name = "PenSizeComboBox";
            PenSizeComboBox.Size = new Size(121, 38);
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(586, 351);
            DrawButton.Margin = new Padding(3, 2, 3, 2);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(131, 32);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(860, 351);
            ExitButton.Margin = new Padding(3, 2, 3, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 32);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(28, 28);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(1016, 38);
            TopMenuStrip.TabIndex = 3;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(62, 34);
            FileTopMenuItem.Text = "&File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(179, 40);
            DrawTopMenuItem.Text = "&Draw";
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(179, 40);
            ClearTopMenuItem.Text = "&Clear";
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(179, 40);
            ExitTopMenuItem.Text = "E&xit";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(74, 34);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(315, 40);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // CLearButton
            // 
            CLearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CLearButton.Location = new Point(723, 351);
            CLearButton.Margin = new Padding(3, 2, 3, 2);
            CLearButton.Name = "CLearButton";
            CLearButton.Size = new Size(131, 32);
            CLearButton.TabIndex = 4;
            CLearButton.Text = "&Clear";
            CLearButton.UseVisualStyleBackColor = true;
            CLearButton.Click += Clear_Click;
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BottomStatusStrip.ImageScalingSize = new Size(28, 28);
            BottomStatusStrip.Items.AddRange(new ToolStripItem[] { DrawingStatusLabel });
            BottomStatusStrip.Location = new Point(0, 399);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Size = new Size(1016, 33);
            BottomStatusStrip.TabIndex = 5;
            BottomStatusStrip.Text = "statusStrip1";
            // 
            // DrawingStatusLabel
            // 
            DrawingStatusLabel.Name = "DrawingStatusLabel";
            DrawingStatusLabel.Size = new Size(178, 24);
            DrawingStatusLabel.Text = "Please Wait...";
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 432);
            Controls.Add(BottomStatusStrip);
            Controls.Add(CLearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(TopMenuStrip);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = TopMenuStrip;
            Margin = new Padding(5);
            MinimumSize = new Size(500, 413);
            Name = "GraphicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            BottomStatusStrip.ResumeLayout(false);
            BottomStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
        private ColorDialog PenColorDialog;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem drawContextMenuItem;
        private ToolStripMenuItem ClearContextMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem PenContextMenuItem;
        private ToolStripMenuItem BackGroundContextMenuItem;
        private ToolStripMenuItem PenSizeContextMenuItem;
        private ToolStripComboBox PenSizeComboBox;
        private Button CLearButton;
        private StatusStrip BottomStatusStrip;
        private ToolStripStatusLabel DrawingStatusLabel;
    }
}
