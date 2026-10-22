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
            OKButton = new Button();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.Location = new Point(344, 195);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(81, 40);
            OKButton.TabIndex = 0;
            OKButton.Text = "&OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // AboutForm
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OKButton;
            ClientSize = new Size(437, 247);
            Controls.Add(OKButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abou";
            ResumeLayout(false);
        }

        #endregion

        private Button OKButton;
    }
}