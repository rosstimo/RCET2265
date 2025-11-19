namespace GraphicsExample
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
            AboutLabel.Size = new Size(562, 280);
            AboutLabel.TabIndex = 0;
            AboutLabel.Text = "Drawing Program\r\nAcme Software LLC.\r\n\r\nContact:\r\n123 Wabbit Woad\r\nBeverly Hills CA 90210\r\n\r\nelmer.fudd@acme.com";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(443, 292);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(131, 59);
            OKButton.TabIndex = 1;
            OKButton.Text = "&OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 363);
            Controls.Add(OKButton);
            Controls.Add(AboutLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutForm";
            ResumeLayout(false);
        }

        #endregion

        private Label AboutLabel;
        private Button OKButton;
    }
}