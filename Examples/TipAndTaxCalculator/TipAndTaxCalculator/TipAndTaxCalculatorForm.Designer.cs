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
            TipCustom = new RadioButton();
            DiscountAAACheckBox = new CheckBox();
            DiscountDCCheckBox = new CheckBox();
            DiscountLabel = new Label();
            TipCustomTextBox = new TextBox();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(440, 361);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 77);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 361);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 77);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "C&lear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 361);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 77);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(147, 30);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(150, 31);
            DollarAmountTextBox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(12, 36);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(129, 25);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Dollar Amount";
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(440, 36);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(59, 25);
            DisplayLabel.TabIndex = 5;
            DisplayLabel.Text = "label2";
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Location = new Point(147, 67);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(72, 29);
            Tip15RadioButton.TabIndex = 6;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Location = new Point(147, 102);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(72, 29);
            Tip18RadioButton.TabIndex = 7;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Location = new Point(147, 137);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(72, 29);
            Tip20RadioButton.TabIndex = 8;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Location = new Point(12, 71);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(106, 25);
            TipLabel.TabIndex = 9;
            TipLabel.Text = "Tip Amount";
            // 
            // TipCustom
            // 
            TipCustom.AutoSize = true;
            TipCustom.Location = new Point(147, 172);
            TipCustom.Name = "TipCustom";
            TipCustom.Size = new Size(99, 29);
            TipCustom.TabIndex = 10;
            TipCustom.TabStop = true;
            TipCustom.Text = "Custom";
            TipCustom.UseVisualStyleBackColor = true;
            // 
            // DiscountAAACheckBox
            // 
            DiscountAAACheckBox.AutoSize = true;
            DiscountAAACheckBox.Location = new Point(147, 207);
            DiscountAAACheckBox.Name = "DiscountAAACheckBox";
            DiscountAAACheckBox.Size = new Size(74, 29);
            DiscountAAACheckBox.TabIndex = 11;
            DiscountAAACheckBox.Text = "AAA";
            DiscountAAACheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountDCCheckBox
            // 
            DiscountDCCheckBox.AutoSize = true;
            DiscountDCCheckBox.Location = new Point(147, 242);
            DiscountDCCheckBox.Name = "DiscountDCCheckBox";
            DiscountDCCheckBox.Size = new Size(134, 29);
            DiscountDCCheckBox.TabIndex = 12;
            DiscountDCCheckBox.Text = "Diner's Card";
            DiscountDCCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(12, 211);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(82, 25);
            DiscountLabel.TabIndex = 13;
            DiscountLabel.Text = "Discount";
            // 
            // TipCustomTextBox
            // 
            TipCustomTextBox.Location = new Point(252, 170);
            TipCustomTextBox.Name = "TipCustomTextBox";
            TipCustomTextBox.Size = new Size(81, 31);
            TipCustomTextBox.TabIndex = 14;
            TipCustomTextBox.TabStop = false;
            // 
            // TipAndTaxCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TipCustomTextBox);
            Controls.Add(DiscountLabel);
            Controls.Add(DiscountDCCheckBox);
            Controls.Add(DiscountAAACheckBox);
            Controls.Add(TipCustom);
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
        private RadioButton TipCustom;
        private CheckBox DiscountAAACheckBox;
        private CheckBox DiscountDCCheckBox;
        private Label DiscountLabel;
        private TextBox TipCustomTextBox;
    }
}
