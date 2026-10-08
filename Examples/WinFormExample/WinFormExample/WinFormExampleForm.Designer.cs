namespace WinFormExample
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
            ExitButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            InfoLabel = new Label();
            InfoTextBox = new TextBox();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            checkBox1 = new CheckBox();
            DefaultRadioButton = new RadioButton();
            ResultListBox = new ListBox();
            UpperCaseRadioButton = new RadioButton();
            checkBox2 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            checkBox3 = new CheckBox();
            LowerCaseRadioButton = new RadioButton();
            checkBox4 = new CheckBox();
            RemoveRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(472, 299);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 50);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(366, 299);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(100, 50);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(260, 299);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(100, 50);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(11, 20);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(31, 15);
            InfoLabel.TabIndex = 3;
            InfoLabel.Text = "Info:";
            // 
            // InfoTextBox
            // 
            InfoTextBox.Location = new Point(48, 12);
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(158, 23);
            InfoTextBox.TabIndex = 0;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(48, 41);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(158, 23);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(0, 49);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name:";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(48, 70);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(158, 23);
            AgeTextBox.TabIndex = 2;
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(12, 78);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(31, 15);
            AgeLabel.TabIndex = 7;
            AgeLabel.Text = "Age:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(124, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // DefaultRadioButton
            // 
            DefaultRadioButton.AutoSize = true;
            DefaultRadioButton.Location = new Point(24, 223);
            DefaultRadioButton.Name = "DefaultRadioButton";
            DefaultRadioButton.Size = new Size(63, 19);
            DefaultRadioButton.TabIndex = 3;
            DefaultRadioButton.TabStop = true;
            DefaultRadioButton.Text = "Default";
            DefaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultListBox
            // 
            ResultListBox.FormattingEnabled = true;
            ResultListBox.Location = new Point(260, 94);
            ResultListBox.Name = "ResultListBox";
            ResultListBox.Size = new Size(312, 199);
            ResultListBox.TabIndex = 10;
            ResultListBox.TabStop = false;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(6, 22);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(85, 19);
            UpperCaseRadioButton.TabIndex = 0;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper Case";
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(106, 23);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(24, 248);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(65, 19);
            ReverseRadioButton.TabIndex = 14;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(124, 249);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadioButton
            // 
            LowerCaseRadioButton.AutoSize = true;
            LowerCaseRadioButton.Location = new Point(6, 45);
            LowerCaseRadioButton.Name = "LowerCaseRadioButton";
            LowerCaseRadioButton.Size = new Size(82, 19);
            LowerCaseRadioButton.TabIndex = 16;
            LowerCaseRadioButton.TabStop = true;
            LowerCaseRadioButton.Text = "LowerCase";
            LowerCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(106, 46);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(82, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // RemoveRadioButton
            // 
            RemoveRadioButton.AutoSize = true;
            RemoveRadioButton.Location = new Point(24, 273);
            RemoveRadioButton.Name = "RemoveRadioButton";
            RemoveRadioButton.Size = new Size(107, 19);
            RemoveRadioButton.TabIndex = 18;
            RemoveRadioButton.TabStop = true;
            RemoveRadioButton.Text = "Remove Spaces";
            RemoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpperCaseRadioButton);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(LowerCaseRadioButton);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Location = new Point(260, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 76);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(groupBox1);
            Controls.Add(RemoveRadioButton);
            Controls.Add(ReverseRadioButton);
            Controls.Add(checkBox3);
            Controls.Add(ResultListBox);
            Controls.Add(DefaultRadioButton);
            Controls.Add(checkBox1);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(InfoTextBox);
            Controls.Add(InfoLabel);
            Controls.Add(SubmitButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForm Example Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SubmitButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private Label InfoLabel;
        private TextBox InfoTextBox;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private CheckBox checkBox1;
        private RadioButton DefaultRadioButton;
        private ListBox ResultListBox;
        private RadioButton UpperCaseRadioButton;
        private CheckBox checkBox2;
        private RadioButton ReverseRadioButton;
        private CheckBox checkBox3;
        private RadioButton LowerCaseRadioButton;
        private CheckBox checkBox4;
        private RadioButton RemoveRadioButton;
        private GroupBox groupBox1;
    }
}
