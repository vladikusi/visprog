using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void butnumClick(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 42)
                mainLabel.Text += ((Button)sender).Text;
        }
        private void butclearClick(object sender, EventArgs e)
        {
            mainLabel.Text = string.Empty;
        }
        private void buteraseClick(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length > 0)
            {
                mainLabel.Text = mainLabel.Text.Remove(mainLabel.Text.Length - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
