namespace TipAndTaxCalculator
{
    partial class TipAndTaxCalculatorForm
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
            CalculateButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            DollarAmountTextBox = new TextBox();
            AmountLabel = new Label();
            DisplayLabel = new Label();
            Tip15RadioButton = new RadioButton();
            Tip18RadioButton = new RadioButton();
            Tip20RadioButton = new RadioButton();
            TipLabel = new Label();
            TipCustomRadioButton = new RadioButton();
            DiscountAAACheckBox = new CheckBox();
            DiscountDCCheckBox = new CheckBox();
            DiscountLabel = new Label();
            TipCustomTextBox = new TextBox();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(528, 433);
            CalculateButton.Margin = new Padding(4);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(134, 92);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(670, 433);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(134, 92);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "C&lear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(811, 433);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(134, 92);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(176, 36);
            DollarAmountTextBox.Margin = new Padding(4);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(179, 35);
            DollarAmountTextBox.TabIndex = 3;
            DollarAmountTextBox.TextChanged += DollarAmountTextBox_TextChanged;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(14, 43);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(149, 30);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Dollar Amount";
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("Consolas", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(528, 36);
            DisplayLabel.Margin = new Padding(4, 0, 4, 0);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(417, 393);
            DisplayLabel.TabIndex = 5;
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Location = new Point(176, 80);
            Tip15RadioButton.Margin = new Padding(4);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(77, 34);
            Tip15RadioButton.TabIndex = 6;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Location = new Point(176, 122);
            Tip18RadioButton.Margin = new Padding(4);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(77, 34);
            Tip18RadioButton.TabIndex = 7;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Location = new Point(176, 164);
            Tip20RadioButton.Margin = new Padding(4);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(77, 34);
            Tip20RadioButton.TabIndex = 8;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Location = new Point(14, 85);
            TipLabel.Margin = new Padding(4, 0, 4, 0);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(122, 30);
            TipLabel.TabIndex = 9;
            TipLabel.Text = "Tip Amount";
            // 
            // TipCustomRadioButton
            // 
            TipCustomRadioButton.AutoSize = true;
            TipCustomRadioButton.Location = new Point(176, 206);
            TipCustomRadioButton.Margin = new Padding(4);
            TipCustomRadioButton.Name = "TipCustomRadioButton";
            TipCustomRadioButton.Size = new Size(109, 34);
            TipCustomRadioButton.TabIndex = 10;
            TipCustomRadioButton.TabStop = true;
            TipCustomRadioButton.Text = "Custom";
            TipCustomRadioButton.UseVisualStyleBackColor = true;
            TipCustomRadioButton.CheckedChanged += TipCustomRadioButton_CheckedChanged;
            // 
            // DiscountAAACheckBox
            // 
            DiscountAAACheckBox.AutoSize = true;
            DiscountAAACheckBox.Location = new Point(176, 248);
            DiscountAAACheckBox.Margin = new Padding(4);
            DiscountAAACheckBox.Name = "DiscountAAACheckBox";
            DiscountAAACheckBox.Size = new Size(81, 34);
            DiscountAAACheckBox.TabIndex = 11;
            DiscountAAACheckBox.Text = "AAA";
            DiscountAAACheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountDCCheckBox
            // 
            DiscountDCCheckBox.AutoSize = true;
            DiscountDCCheckBox.Location = new Point(176, 290);
            DiscountDCCheckBox.Margin = new Padding(4);
            DiscountDCCheckBox.Name = "DiscountDCCheckBox";
            DiscountDCCheckBox.Size = new Size(152, 34);
            DiscountDCCheckBox.TabIndex = 12;
            DiscountDCCheckBox.Text = "Diner's Card";
            DiscountDCCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(14, 253);
            DiscountLabel.Margin = new Padding(4, 0, 4, 0);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(95, 30);
            DiscountLabel.TabIndex = 13;
            DiscountLabel.Text = "Discount";
            // 
            // TipCustomTextBox
            // 
            TipCustomTextBox.Location = new Point(302, 204);
            TipCustomTextBox.Margin = new Padding(4);
            TipCustomTextBox.Name = "TipCustomTextBox";
            TipCustomTextBox.Size = new Size(96, 35);
            TipCustomTextBox.TabIndex = 14;
            TipCustomTextBox.TabStop = false;
            // 
            // TipAndTaxCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(TipCustomTextBox);
            Controls.Add(DiscountLabel);
            Controls.Add(DiscountDCCheckBox);
            Controls.Add(DiscountAAACheckBox);
            Controls.Add(TipCustomRadioButton);
            Controls.Add(TipLabel);
            Controls.Add(Tip20RadioButton);
            Controls.Add(Tip18RadioButton);
            Controls.Add(Tip15RadioButton);
            Controls.Add(DisplayLabel);
            Controls.Add(AmountLabel);
            Controls.Add(DollarAmountTextBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Margin = new Padding(4);
            Name = "TipAndTaxCalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip & Tax";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox DollarAmountTextBox;
        private Label AmountLabel;
        private Label DisplayLabel;
        private RadioButton Tip15RadioButton;
        private RadioButton Tip18RadioButton;
        private RadioButton Tip20RadioButton;
        private Label TipLabel;
        private RadioButton TipCustomRadioButton;
        private CheckBox DiscountAAACheckBox;
        private CheckBox DiscountDCCheckBox;
        private Label DiscountLabel;
        private TextBox TipCustomTextBox;
    }
}
