namespace GraphicExample
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AboutLabel = new Label();
            OKButton = new Button();
            SuspendLayout();
            // 
            // AboutLabel
            // 
            AboutLabel.Location = new Point(12, 9);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(282, 200);
            AboutLabel.TabIndex = 0;
            AboutLabel.Text = "label1";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(163, 212);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(131, 40);
            OKButton.TabIndex = 1;
            OKButton.Text = "&OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // AboutForm
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OKButton;
            ClientSize = new Size(321, 273);
            Controls.Add(OKButton);
            Controls.Add(AboutLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Label AboutLabel;
        private Button OKButton;
    }
}