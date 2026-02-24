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
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            ClearButton = new Button();
            ButtonGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(17, 30);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(124, 75);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
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
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Location = new Point(369, 314);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(419, 124);
            ButtonGroupBox.TabIndex = 9;
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
            UserInfoGroupBox.TabIndex = 10;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(388, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 298);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Name = "WinFormExampleForm";
            Text = "Form1";
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}
