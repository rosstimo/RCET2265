namespace WinFormsExample
{
    partial class WinFormExampleForm
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
            ExitButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            ClearButton = new Button();
            ButtonGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            ToolTip = new ToolTip(components);
            FormatGroupBox = new GroupBox();
            FormatContextMenuStrip = new ContextMenuStrip(components);
            UpperContextMenuItem = new ToolStripMenuItem();
            LowerContextMenuItem = new ToolStripMenuItem();
            ReverseContextMenuItem = new ToolStripMenuItem();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            OpenTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            MainOpenFileDialog = new OpenFileDialog();
            DisplayListBox = new ListBox();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            FormatGroupBox.SuspendLayout();
            FormatContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(20, 36);
            SubmitButton.Margin = new Padding(4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(149, 90);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            ToolTip.SetToolTip(SubmitButton, "ALT+s");
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(332, 36);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 90);
            ExitButton.TabIndex = 6;
            ExitButton.TabStop = false;
            ExitButton.Text = "E&xit";
            ToolTip.SetToolTip(ExitButton, "ALT+x");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(20, 32);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(69, 30);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(98, 25);
            NameTextBox.Margin = new Padding(4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(326, 35);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(98, 70);
            AgeTextBox.Margin = new Padding(4);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(326, 35);
            AgeTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(20, 77);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(50, 30);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(98, 114);
            PhoneTextBox.Margin = new Padding(4);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(326, 35);
            PhoneTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(20, 121);
            PhoneLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(72, 30);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Phone";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(98, 158);
            CityTextBox.Margin = new Padding(4);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(326, 35);
            CityTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(20, 166);
            CityLabel.Margin = new Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(48, 30);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(176, 36);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(149, 90);
            ClearButton.TabIndex = 5;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ToolTip.SetToolTip(ClearButton, "ALT+c");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Location = new Point(443, 377);
            ButtonGroupBox.Margin = new Padding(4);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Padding = new Padding(4);
            ButtonGroupBox.Size = new Size(503, 149);
            ButtonGroupBox.TabIndex = 5;
            ButtonGroupBox.TabStop = false;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(NameTextBox);
            UserInfoGroupBox.Controls.Add(NameLabel);
            UserInfoGroupBox.Controls.Add(PhoneTextBox);
            UserInfoGroupBox.Controls.Add(AgeLabel);
            UserInfoGroupBox.Controls.Add(PhoneLabel);
            UserInfoGroupBox.Controls.Add(AgeTextBox);
            UserInfoGroupBox.Controls.Add(CityTextBox);
            UserInfoGroupBox.Controls.Add(CityLabel);
            UserInfoGroupBox.Location = new Point(14, 48);
            UserInfoGroupBox.Margin = new Padding(4);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Padding = new Padding(4);
            UserInfoGroupBox.Size = new Size(444, 229);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(220, 78);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(137, 34);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(220, 120);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(137, 34);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(7, 119);
            ReverseRadioButton.Margin = new Padding(4);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(109, 34);
            ReverseRadioButton.TabIndex = 16;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(7, 36);
            UpperCaseRadioButton.Margin = new Padding(4);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(94, 34);
            UpperCaseRadioButton.TabIndex = 1;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            ToolTip.SetToolTip(UpperCaseRadioButton, "Make Upper Case");
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            LowerRadioButton.AutoSize = true;
            LowerRadioButton.Location = new Point(7, 78);
            LowerRadioButton.Margin = new Padding(4);
            LowerRadioButton.Name = "LowerRadioButton";
            LowerRadioButton.Size = new Size(93, 34);
            LowerRadioButton.TabIndex = 16;
            LowerRadioButton.TabStop = true;
            LowerRadioButton.Text = "Lower";
            LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatGroupBox
            // 
            FormatGroupBox.ContextMenuStrip = FormatContextMenuStrip;
            FormatGroupBox.Controls.Add(UpperCaseRadioButton);
            FormatGroupBox.Controls.Add(checkBox2);
            FormatGroupBox.Controls.Add(LowerRadioButton);
            FormatGroupBox.Controls.Add(checkBox4);
            FormatGroupBox.Controls.Add(ReverseRadioButton);
            FormatGroupBox.Location = new Point(14, 284);
            FormatGroupBox.Margin = new Padding(4);
            FormatGroupBox.Name = "FormatGroupBox";
            FormatGroupBox.Padding = new Padding(4);
            FormatGroupBox.Size = new Size(392, 241);
            FormatGroupBox.TabIndex = 19;
            FormatGroupBox.TabStop = false;
            FormatGroupBox.Text = "Format Options";
            ToolTip.SetToolTip(FormatGroupBox, "Select Text Formmatting Options");
            // 
            // FormatContextMenuStrip
            // 
            FormatContextMenuStrip.ImageScalingSize = new Size(24, 24);
            FormatContextMenuStrip.Items.AddRange(new ToolStripItem[] { UpperContextMenuItem, LowerContextMenuItem, ReverseContextMenuItem });
            FormatContextMenuStrip.Name = "FormatContextMenuStrip";
            FormatContextMenuStrip.Size = new Size(193, 112);
            // 
            // UpperContextMenuItem
            // 
            UpperContextMenuItem.Name = "UpperContextMenuItem";
            UpperContextMenuItem.Size = new Size(192, 36);
            UpperContextMenuItem.Text = "Upper Case";
            UpperContextMenuItem.Click += UpperContextMenuItem_Click;
            // 
            // LowerContextMenuItem
            // 
            LowerContextMenuItem.Name = "LowerContextMenuItem";
            LowerContextMenuItem.Size = new Size(192, 36);
            LowerContextMenuItem.Text = "Lower Case";
            LowerContextMenuItem.Click += LowerContextMenuItem_Click;
            // 
            // ReverseContextMenuItem
            // 
            ReverseContextMenuItem.Name = "ReverseContextMenuItem";
            ReverseContextMenuItem.Size = new Size(192, 36);
            ReverseContextMenuItem.Text = "Reverse";
            ReverseContextMenuItem.Click += ReverseContextMenuItem_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Padding = new Padding(7, 2, 0, 2);
            TopMenuStrip.Size = new Size(960, 38);
            TopMenuStrip.TabIndex = 18;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenTopMenuItem, SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(62, 34);
            FileTopMenuItem.Text = "&File";
            // 
            // OpenTopMenuItem
            // 
            OpenTopMenuItem.Name = "OpenTopMenuItem";
            OpenTopMenuItem.Size = new Size(315, 40);
            OpenTopMenuItem.Text = "&Open";
            OpenTopMenuItem.Click += OpenTopMenuItem_Click;
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(315, 40);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(315, 40);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(315, 40);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitButton_Click;
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
            AboutTopMenuItem.Size = new Size(188, 40);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // MainOpenFileDialog
            // 
            MainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(463, 73);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(461, 334);
            DisplayListBox.TabIndex = 20;
            // 
            // WinFormExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(960, 540);
            Controls.Add(DisplayListBox);
            Controls.Add(FormatGroupBox);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Margin = new Padding(4);
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form";
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            FormatGroupBox.ResumeLayout(false);
            FormatGroupBox.PerformLayout();
            FormatContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private TextBox NameTextBox;
        protected Label NameLabel;
        private TextBox AgeTextBox;
        protected Label AgeLabel;
        private TextBox PhoneTextBox;
        protected Label PhoneLabel;
        private TextBox CityTextBox;
        protected Label CityLabel;
        private Button ClearButton;
        private GroupBox ButtonGroupBox;
        private GroupBox UserInfoGroupBox;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private RadioButton ReverseRadioButton;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerRadioButton;
        private ToolTip ToolTip;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private GroupBox FormatGroupBox;
        private ContextMenuStrip FormatContextMenuStrip;
        private ToolStripMenuItem UpperContextMenuItem;
        private ToolStripMenuItem LowerContextMenuItem;
        private ToolStripMenuItem ReverseContextMenuItem;
        private ToolStripMenuItem OpenTopMenuItem;
        private OpenFileDialog MainOpenFileDialog;
        private ListBox DisplayListBox;
    }
}
