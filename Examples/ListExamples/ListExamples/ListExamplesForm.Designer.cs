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
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            InfoGroupBox.SuspendLayout();
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
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 371);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 67);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
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
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InfoGroupBox);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesForm";
            Text = "Form1";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
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
    }
}
