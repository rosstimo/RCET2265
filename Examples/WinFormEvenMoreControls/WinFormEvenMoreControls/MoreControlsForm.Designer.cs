namespace WinFormEvenMoreControls
{
    partial class MoreControlsForm
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
            SubmitButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            TopMenuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            FileTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem2 = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            SubmitContextMenuItem = new ToolStripMenuItem();
            CLearContextMenuItem = new ToolStripMenuItem();
            ExitContextMenuItem = new ToolStripMenuItem();
            DisplayListBox = new ListBox();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(329, 343);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(149, 95);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(484, 343);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(149, 95);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(639, 343);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 95);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(28, 28);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, FileTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 38);
            TopMenuStrip.TabIndex = 3;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(18, 34);
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem, submitToolStripMenuItem2 });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(62, 34);
            FileTopMenuItem.Text = "&File";
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(196, 40);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(196, 40);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(196, 40);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // submitToolStripMenuItem2
            // 
            submitToolStripMenuItem2.Name = "submitToolStripMenuItem2";
            submitToolStripMenuItem2.Size = new Size(196, 40);
            submitToolStripMenuItem2.Text = "&Submit";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(28, 28);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { SubmitContextMenuItem, CLearContextMenuItem, ExitContextMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(152, 112);
            // 
            // SubmitContextMenuItem
            // 
            SubmitContextMenuItem.Name = "SubmitContextMenuItem";
            SubmitContextMenuItem.Size = new Size(151, 36);
            SubmitContextMenuItem.Text = "Submit";
            SubmitContextMenuItem.Click += SubmitButton_Click;
            // 
            // CLearContextMenuItem
            // 
            CLearContextMenuItem.Name = "CLearContextMenuItem";
            CLearContextMenuItem.Size = new Size(151, 36);
            CLearContextMenuItem.Text = "Clear";
            CLearContextMenuItem.Click += ClearButton_Click;
            // 
            // ExitContextMenuItem
            // 
            ExitContextMenuItem.Name = "ExitContextMenuItem";
            ExitContextMenuItem.Size = new Size(151, 36);
            ExitContextMenuItem.Text = "Exit";
            ExitContextMenuItem.Click += ExitButton_Click;
            // 
            // DisplayListBox
            // 
            DisplayListBox.ContextMenuStrip = ContextMenuStrip;
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.ItemHeight = 30;
            DisplayListBox.Location = new Point(12, 41);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(776, 274);
            DisplayListBox.TabIndex = 4;
            // 
            // MoreControlsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayListBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "MoreControlsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "More Controls";
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ClearButton;
        private Button ExitButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem SubmitContextMenuItem;
        private ToolStripMenuItem CLearContextMenuItem;
        private ToolStripMenuItem ExitContextMenuItem;
        private ListBox DisplayListBox;
        private ToolStripMenuItem submitToolStripMenuItem2;
    }
}
