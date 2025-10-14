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
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(448, 327);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(167, 111);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(621, 327);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(167, 111);
            ExitButton.TabIndex = 1;
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
            FirstNameLabel.Click += label1_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(131, 71);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(175, 35);
            FirstNameTextBox.TabIndex = 3;
            // 
            // ExampleForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
