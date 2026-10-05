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
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(472, 299);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 50);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(366, 299);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(100, 50);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(260, 299);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(100, 50);
            SubmitButton.TabIndex = 3;
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
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(48, 41);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(158, 23);
            NameTextBox.TabIndex = 1;
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
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
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
    }
}
