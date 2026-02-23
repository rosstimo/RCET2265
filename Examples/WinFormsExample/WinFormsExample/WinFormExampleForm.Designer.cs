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
            SubmitButton = new Button();
            ExitButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(534, 363);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(124, 75);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(664, 363);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 75);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 52);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            NameLabel.Click += label1_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(77, 46);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(272, 31);
            NameTextBox.TabIndex = 3;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Name = "WinFormExampleForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private TextBox NameTextBox;
        protected Label NameLabel;
    }
}
