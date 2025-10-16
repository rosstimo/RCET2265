namespace WinFormsExample
{
    partial class ExampleForm
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
            SubmitButton = new Button();
            ExitButton = new Button();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            DisplayLabel = new Label();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(344, 262);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(167, 111);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(517, 262);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(167, 111);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(12, 71);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(113, 30);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(131, 71);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(175, 35);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(131, 112);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(175, 35);
            LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(12, 112);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(112, 30);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(131, 153);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(175, 35);
            AgeTextBox.TabIndex = 2;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(12, 153);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(50, 30);
            AgeLabel.TabIndex = 6;
            AgeLabel.Text = "Age";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(131, 194);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(175, 35);
            PhoneTextBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(12, 194);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(72, 30);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Phone";
            // 
            // DisplayLabel
            // 
            DisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            DisplayLabel.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(344, 65);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(340, 188);
            DisplayLabel.TabIndex = 10;
            // 
            // ExampleForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 386);
            Controls.Add(DisplayLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Name = "ExampleForm";
            Text = "Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private Label DisplayLabel;
    }
}
