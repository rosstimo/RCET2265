namespace ListExamples
{
    partial class ListExamplesForm
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
            SubmitButton = new Button();
            ClearButton = new Button();
            InfoGroupBox = new GroupBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            OutputGroupBox = new GroupBox();
            DisplayListBox = new ListBox();
            SelectionComboBox = new ComboBox();
            InfoGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 371);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 67);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(440, 371);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 67);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 371);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 67);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(CompanyLabel);
            InfoGroupBox.Controls.Add(CompanyTextBox);
            InfoGroupBox.Controls.Add(LastNameLabel);
            InfoGroupBox.Controls.Add(LastNameTextBox);
            InfoGroupBox.Controls.Add(FirstNameLabel);
            InfoGroupBox.Controls.Add(FirstNameTextBox);
            InfoGroupBox.Location = new Point(12, 27);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(300, 161);
            InfoGroupBox.TabIndex = 0;
            InfoGroupBox.TabStop = false;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(6, 101);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(89, 25);
            CompanyLabel.TabIndex = 5;
            CompanyLabel.Text = "Company";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(101, 98);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(167, 31);
            CompanyTextBox.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(6, 64);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(43, 25);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(101, 58);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(167, 31);
            LastNameTextBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 27);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(45, 25);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(101, 21);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(167, 31);
            FirstNameTextBox.TabIndex = 0;
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(DisplayListBox);
            OutputGroupBox.Controls.Add(SelectionComboBox);
            OutputGroupBox.Location = new Point(318, 27);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(470, 338);
            OutputGroupBox.TabIndex = 4;
            OutputGroupBox.TabStop = false;
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(6, 53);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(450, 279);
            DisplayListBox.TabIndex = 1;
            DisplayListBox.SelectedIndexChanged += DisplayListBox_SelectedIndexChanged;
            // 
            // SelectionComboBox
            // 
            SelectionComboBox.FormattingEnabled = true;
            SelectionComboBox.Location = new Point(6, 19);
            SelectionComboBox.Name = "SelectionComboBox";
            SelectionComboBox.Size = new Size(182, 33);
            SelectionComboBox.TabIndex = 0;
            // 
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputGroupBox);
            Controls.Add(InfoGroupBox);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Examples";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
        private GroupBox InfoGroupBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private Label CompanyLabel;
        private TextBox CompanyTextBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private GroupBox OutputGroupBox;
        private ListBox DisplayListBox;
        private ComboBox SelectionComboBox;
    }
}
