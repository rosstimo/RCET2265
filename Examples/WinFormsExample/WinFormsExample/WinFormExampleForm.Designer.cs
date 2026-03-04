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
            DisplayLabel = new Label();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(17, 30);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(124, 75);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            ToolTip.SetToolTip(SubmitButton, "ALT+s");
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(277, 30);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 75);
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
            NameLabel.Location = new Point(17, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(82, 21);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(272, 31);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(82, 58);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(272, 31);
            AgeTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(17, 64);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 25);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(82, 95);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(272, 31);
            PhoneTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(17, 101);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(62, 25);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Phone";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(82, 132);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(272, 31);
            CityTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(17, 138);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(147, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(124, 75);
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
            ButtonGroupBox.Location = new Point(369, 314);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(419, 124);
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
            UserInfoGroupBox.Location = new Point(12, 40);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(370, 191);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(206, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(206, 324);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(29, 323);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(97, 29);
            ReverseRadioButton.TabIndex = 16;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(29, 254);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(86, 29);
            UpperCaseRadioButton.TabIndex = 1;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            ToolTip.SetToolTip(UpperCaseRadioButton, "Make Upper Case");
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            LowerRadioButton.AutoSize = true;
            LowerRadioButton.Location = new Point(29, 289);
            LowerRadioButton.Name = "LowerRadioButton";
            LowerRadioButton.Size = new Size(84, 29);
            LowerRadioButton.TabIndex = 16;
            LowerRadioButton.TabStop = true;
            LowerRadioButton.Text = "Lower";
            LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // DisplayLabel
            // 
            DisplayLabel.Cursor = Cursors.Hand;
            DisplayLabel.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(386, 61);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(384, 250);
            DisplayLabel.TabIndex = 17;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 18;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(54, 29);
            FileTopMenuItem.Text = "&File";
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(171, 34);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(171, 34);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(171, 34);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(65, 29);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(270, 34);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // WinFormExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayLabel);
            Controls.Add(LowerRadioButton);
            Controls.Add(ReverseRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form";
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
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
        private Label DisplayLabel;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
    }
}
