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
            submitToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            submitToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
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
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(484, 343);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(149, 95);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(639, 343);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 95);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
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
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { submitToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(62, 34);
            FileTopMenuItem.Text = "&File";
            // 
            // submitToolStripMenuItem
            // 
            submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            submitToolStripMenuItem.Size = new Size(196, 40);
            submitToolStripMenuItem.Text = "&Submit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(196, 40);
            clearToolStripMenuItem.Text = "&Clear";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(196, 40);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(28, 28);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { submitToolStripMenuItem1, clearToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(152, 112);
            // 
            // submitToolStripMenuItem1
            // 
            submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            submitToolStripMenuItem1.Size = new Size(151, 36);
            submitToolStripMenuItem1.Text = "Submit";
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(151, 36);
            clearToolStripMenuItem1.Text = "Clear";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(151, 36);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // MoreControlsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = ContextMenuStrip;
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
        private ToolStripMenuItem submitToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem submitToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
