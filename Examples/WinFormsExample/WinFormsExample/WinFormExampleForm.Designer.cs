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
            radioButton6 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(388, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 298);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(101, 206);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(141, 29);
            radioButton6.TabIndex = 17;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(101, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(101, 136);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(104, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(104, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
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
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LowerRadioButton);
            Controls.Add(ReverseRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(groupBox1);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Name = "WinFormExampleForm";
            Text = "Form1";
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton radioButton6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton ReverseRadioButton;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerRadioButton;
    }
}
