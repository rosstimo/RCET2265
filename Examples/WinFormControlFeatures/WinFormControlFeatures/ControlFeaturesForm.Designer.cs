namespace WinFormControlFeatures
{
    partial class ControlFeaturesForm
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
            InfoGroupBox = new GroupBox();
            PhoneTextBox = new TextBox();
            label2 = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            OutputGroupBox = new GroupBox();
            ButtonsGroupBox = new GroupBox();
            ExitButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            OptionsGroupBox = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            UpperRadioButton = new RadioButton();
            ResultListBox = new ListBox();
            InfoGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            ButtonsGroupBox.SuspendLayout();
            OptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(PhoneTextBox);
            InfoGroupBox.Controls.Add(label2);
            InfoGroupBox.Controls.Add(AgeTextBox);
            InfoGroupBox.Controls.Add(AgeLabel);
            InfoGroupBox.Controls.Add(NameTextBox);
            InfoGroupBox.Controls.Add(NameLabel);
            InfoGroupBox.Location = new Point(12, 12);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(433, 272);
            InfoGroupBox.TabIndex = 0;
            InfoGroupBox.TabStop = false;
            InfoGroupBox.Text = "Client Information";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(86, 126);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(264, 35);
            PhoneTextBox.TabIndex = 5;
            PhoneTextBox.TextChanged += Text_Changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 126);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 4;
            label2.Text = "Phone";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(86, 85);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(264, 35);
            AgeTextBox.TabIndex = 3;
            AgeTextBox.TextChanged += Text_Changed;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(6, 82);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(50, 30);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Age";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(86, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(264, 35);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += Text_Changed;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(69, 30);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(ResultListBox);
            OutputGroupBox.Location = new Point(451, 12);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(481, 272);
            OutputGroupBox.TabIndex = 1;
            OutputGroupBox.TabStop = false;
            OutputGroupBox.Text = "Result";
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Controls.Add(ExitButton);
            ButtonsGroupBox.Controls.Add(ClearButton);
            ButtonsGroupBox.Controls.Add(SubmitButton);
            ButtonsGroupBox.Location = new Point(451, 290);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Size = new Size(481, 218);
            ButtonsGroupBox.TabIndex = 3;
            ButtonsGroupBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(344, 135);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 77);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(207, 135);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 77);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(70, 135);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(131, 77);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // OptionsGroupBox
            // 
            OptionsGroupBox.Controls.Add(checkBox2);
            OptionsGroupBox.Controls.Add(checkBox1);
            OptionsGroupBox.Controls.Add(ReverseRadioButton);
            OptionsGroupBox.Controls.Add(LowerRadioButton);
            OptionsGroupBox.Controls.Add(UpperRadioButton);
            OptionsGroupBox.Location = new Point(12, 290);
            OptionsGroupBox.Name = "OptionsGroupBox";
            OptionsGroupBox.Size = new Size(433, 218);
            OptionsGroupBox.TabIndex = 2;
            OptionsGroupBox.TabStop = false;
            OptionsGroupBox.Text = "Options";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(207, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(137, 34);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(207, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 34);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(6, 114);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(109, 34);
            ReverseRadioButton.TabIndex = 2;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            LowerRadioButton.AutoSize = true;
            LowerRadioButton.Location = new Point(6, 74);
            LowerRadioButton.Name = "LowerRadioButton";
            LowerRadioButton.Size = new Size(143, 34);
            LowerRadioButton.TabIndex = 1;
            LowerRadioButton.TabStop = true;
            LowerRadioButton.Text = "Lower Case";
            LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperRadioButton
            // 
            UpperRadioButton.AutoSize = true;
            UpperRadioButton.Location = new Point(6, 34);
            UpperRadioButton.Name = "UpperRadioButton";
            UpperRadioButton.Size = new Size(144, 34);
            UpperRadioButton.TabIndex = 0;
            UpperRadioButton.TabStop = true;
            UpperRadioButton.Text = "Upper Case";
            UpperRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultListBox
            // 
            ResultListBox.FormattingEnabled = true;
            ResultListBox.ItemHeight = 30;
            ResultListBox.Location = new Point(6, 56);
            ResultListBox.Name = "ResultListBox";
            ResultListBox.Size = new Size(469, 184);
            ResultListBox.TabIndex = 0;
            // 
            // ControlFeaturesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 520);
            Controls.Add(ButtonsGroupBox);
            Controls.Add(OptionsGroupBox);
            Controls.Add(OutputGroupBox);
            Controls.Add(InfoGroupBox);
            Name = "ControlFeaturesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control Features";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ButtonsGroupBox.ResumeLayout(false);
            OptionsGroupBox.ResumeLayout(false);
            OptionsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InfoGroupBox;
        private GroupBox OutputGroupBox;
        private GroupBox ButtonsGroupBox;
        private GroupBox OptionsGroupBox;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox PhoneTextBox;
        private Label label2;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private RadioButton ReverseRadioButton;
        private RadioButton LowerRadioButton;
        private RadioButton UpperRadioButton;
        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox ResultListBox;
    }
}
