using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphicExample
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            UpdateLabel();
        }

        void UpdateLabel()
        {
            AboutLabel.Text = $"Graphics Example \n" + 
            $"ACME Inc.\n" +
            $"123 Wabbit Woad \n" +
            $"Beverly Hills CA, 90210";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
